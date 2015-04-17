using System;
using System.Net;
using System.Text;
using RestSharp;

namespace Cielo
{
    public class Client
    {
        public Client()
        {
            Encoding = Encoding.GetEncoding("iso-8859-1");
            RestClient = new RestClient(Configuration.Url);
        }

        public Client(Encoding encoding) : this()
        {
            Encoding = encoding;
        }

        public RestClient RestClient { get; private set; }

        public Encoding Encoding { get; private set; }

        public ClientResult GetTransaction(string tId)
        {
            return GetTransaction(new TransactionResult { Tid = tId });
        }

        public ClientResult GetTransaction(TransactionResult transactionResult)
        {
            var requestTransaction = new RequestTransaction
            {
              Id  = Guid.NewGuid().ToString("N"),
              Tid = transactionResult.Tid
            };

            return Send(requestTransaction.ToXml(Encoding));
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
            var request = new RestRequest("servicos/ecommwsec.do", Method.POST);
            
            request.AddHeader("Content-Type", string.Format("application/x-www-form-urlencoded; charset={0}", Encoding.WebName));
            request.RequestFormat = DataFormat.Xml;
            request.AddParameter("mensagem", xml);

            var response = RestClient.Execute(request);
            var result = new ClientResult();

            if (response.StatusCode != HttpStatusCode.OK)
            {
                var message = string.Format("Error sending message.\n\nContent:\n{0}\n", response.Content);

                if (response.ErrorException != null)
                {
                    throw new Exception(message, response.ErrorException);
                }
                
                throw new Exception(message);
            }

            if (response.Content.Contains("</transacao>"))
            {
                result.Transaction = response.Content.ToObject<TransactionResult>(Encoding);
                result.Transaction.Xml = response.Content;
            }
            else if (response.Content.Contains("</erro>"))
            {
                result.Error = response.Content.ToObject<ErrorResult>(Encoding);
            }
            
            return result;
        }
    }
}