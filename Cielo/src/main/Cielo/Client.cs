using System;
using System.IO;
using System.Net;
using System.Text;
using Cielo.Extensions;

namespace Cielo
{
    public class Client
    {
        public Client()
        {
            Encoding = Encoding.GetEncoding("iso-8859-1");
        }

        public Client(Encoding encoding) : this()
        {
            Encoding = encoding;
        }

        public Encoding Encoding { get; private set; }

        public ClientResult CaptureTransaction(string tId)
        {
            return CaptureTransaction(tId, 0);
        }

        public ClientResult CaptureTransaction(string tId, decimal amount)
        {
            return CaptureTransaction(tId, amount, 0);
        }

        public ClientResult CaptureTransaction(string tId, decimal amount, decimal departureTax)
        {
            var captureTransaction = new CaptureTransaction
            {
                Id = Guid.NewGuid().ToString("N"),
                Tid = tId,
                Amount = amount == 0 ? null : new int?(amount.OnlyNumbers()),
                DepartureTax = departureTax == 0 ? null : new int?(departureTax.OnlyNumbers())
            };

            return Send(captureTransaction.ToXml(Encoding));
        }

        public ClientResult CancelTransaction(string tId)
        {
            return CancelTransaction(tId, 0);
        }

        public ClientResult CancelTransaction(string tId, decimal amount)
        {
            var cancellationTransaction = new CancellationTransaction
            {
                Id = Guid.NewGuid().ToString("N"),
                Tid = tId,
                Amount = amount == 0 ? null : new int?(amount.OnlyNumbers())
            };

            return Send(cancellationTransaction.ToXml(Encoding));
        }

        public ClientResult AuthorizeTransaction(string tId)
        {
            var authorizeTransaction = new AuthorizeTransaction
            {
                Id = Guid.NewGuid().ToString("N"),
                Tid = tId
            };

            return Send(authorizeTransaction.ToXml(Encoding));
        }

        public ClientResult GetTransaction(string tId)
        {
            var requestTransaction = new RequestTransaction
            {
                Id = Guid.NewGuid().ToString("N"),
                Tid = tId
            };

            return Send(requestTransaction.ToXml(Encoding));
        }

        public ClientResult GetToken(long number, int expiration)
        {
            return GetToken(number, expiration, null);
        }

        public ClientResult GetToken(long number, int expiration, string name)
        {
            return GetToken(new Card
            {
                Expiration = expiration,
                Name = name,
                Number = number
            });
        }

        public ClientResult GetToken(Card card)
        {
            var requestToken = new RequestToken
            {
                Id = Guid.NewGuid().ToString("N"),
                Card = card
            };

            return Send(requestToken.ToXml(Encoding));
        }

        public ClientResult CreateTransaction(Order order, PaymentMethodBrand brand, string returnUrl)
        {
            return CreateTransaction(order, new PaymentMethod
            {
                Brand = brand,
                Parcel = 1,
                Product = PaymentMethodProduct.CreditOneParcel 
            }, returnUrl);
        }
        
        public ClientResult CreateTransaction(Order order, PaymentMethod paymentMethod, string returnUrl)
        {
            return CreateTransaction(new Transaction
            {
                Capture = true,
                AuthorizationType = TransactionAuthorizationType.AllowAuthenticatedAndUnauthenticated,
                Order = order,
                Id = order.Number,
                PaymentMethod = paymentMethod,
                ReturnUrl = returnUrl
            });
        }

        public ClientResult CreateTransaction(Transaction transaction)
        {
            return Send(transaction.ToXml(Encoding));
        }

        public ClientResult Send(string xml)
        {
            var request = (HttpWebRequest)WebRequest.Create(Configuration.Url);
            var data = string.Format("mensagem={0}", xml);
            string content;

            request.ContentLength = Encoding.GetBytes(data).Length;
            request.ContentType = string.Format("application/x-www-form-urlencoded; charset={0}", Encoding.WebName);
            request.Method = "POST";

            using (var streamWriter = new StreamWriter(request.GetRequestStream(), Encoding))
            {
                streamWriter.Write(data);
            }

            var response = (HttpWebResponse)request.GetResponse();

            using (var streamReader = new StreamReader(response.GetResponseStream(), Encoding))
            {
                content = streamReader.ReadToEnd();
            }

            var result = new ClientResult();

            if (response.StatusCode != HttpStatusCode.OK)
            {
                var message = string.Format("Error sending message.\n\nContent:\n{0}\n", response);
                
                throw new Exception(message);
            }

            if (content.Contains("</transacao>"))
            {
                result.Transaction = content.ToObject<TransactionResult>(Encoding);
                result.Transaction.Xml = content;
            }
            else if (content.Contains("</erro>"))
            {
                result.Error = content.ToObject<ErrorResult>(Encoding);
            }
            else if (content.Contains("</retorno-token>"))
            {
                result.Token = content.ToObject<TokenResult>(Encoding);
            }

            return result;
        }
    }
}