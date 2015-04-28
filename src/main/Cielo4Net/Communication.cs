using System;
using System.IO;
using System.Net;
using System.Text;
using Cielo4Net.Extensions;
using log4net;

namespace Cielo4Net
{
    /// <summary>
    ///     Comunicação com a Cielo.
    /// </summary>
    public class Communication
    {
        /// <summary>
        ///     Inicializa uma nova instância da classe <see cref="Communication" /> onde o encoding será iso-8859-1.
        /// </summary>
        public Communication()
        {
            Encoding = Encoding.GetEncoding("iso-8859-1");
            Log = LogManager.GetLogger("Cielo4Net");
        }

        /// <summary>
        ///     Inicializa uma nova instância da classe <see cref="Communication" /> informando o encoding.
        /// </summary>
        /// <param name="encoding">
        ///     <see cref="Encoding" />
        /// </param>
        public Communication(Encoding encoding) : this()
        {
            Encoding = encoding;
        }

        /// <summary>
        ///     Recupera ou define o encoding.
        /// </summary>
        public Encoding Encoding { get; private set; }

        /// <summary>
        ///     Recupera ou define <see cref="ILog" />
        /// </summary>
        public ILog Log { get; set; }

        /// <summary>
        ///     Captura transação através do identificador da transação. O valor a ser caputrado será total.
        /// </summary>
        /// <param name="tId">Identificador da transação.</param>
        /// <returns>
        ///     <see cref="CommunicationResult" />
        /// </returns>
        public CommunicationResult CaptureTransaction(string tId)
        {
            return CaptureTransaction(tId, 0);
        }

        /// <summary>
        ///     Captura transação através do identificador da transação e valor. O valor a ser caputrado será total caso o valor
        ///     for menor ou igual a zero.
        /// </summary>
        /// <param name="tId">Identificador da transação.</param>
        /// <param name="amount">Valor a ser caputrado.</param>
        /// <returns>
        ///     <see cref="CommunicationResult" />
        /// </returns>
        public CommunicationResult CaptureTransaction(string tId, decimal amount)
        {
            return CaptureTransaction(tId, amount, 0);
        }

        /// <summary>
        ///     Captura transação através do identificador da transação, valor e taxa de embarque. O valor a ser caputrado será
        ///     total caso o valor
        ///     for menor ou igual a zero.
        /// </summary>
        /// <param name="tId">Identificador da transação.</param>
        /// <param name="amount">Valor a ser caputrado.</param>
        /// <param name="departureTax">Taxa de embarque.</param>
        /// <returns>
        ///     <see cref="CommunicationResult" />
        /// </returns>
        public CommunicationResult CaptureTransaction(string tId, decimal amount, decimal departureTax)
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

        /// <summary>
        ///     Cancela o valor total através do identificador da transação.
        /// </summary>
        /// <param name="tId">Identificador da transação.</param>
        /// <returns>
        ///     <see cref="CommunicationResult" />
        /// </returns>
        public CommunicationResult CancelTransaction(string tId)
        {
            return CancelTransaction(tId, 0);
        }

        /// <summary>
        ///     Cancela o valor total ou parcial através do identificador da transação. O valor a ser cancelado será total caso o
        ///     valor for menor ou igual a zero.
        /// </summary>
        /// <param name="tId">Identificador da transação.</param>
        /// <param name="amount">Valor a ser cancelado.</param>
        /// <returns>
        ///     <see cref="CommunicationResult" />
        /// </returns>
        public CommunicationResult CancelTransaction(string tId, decimal amount)
        {
            var cancellationTransaction = new CancellationTransaction
            {
                Id = Guid.NewGuid().ToString("N"),
                Tid = tId,
                Amount = amount == 0 ? null : new int?(amount.OnlyNumbers())
            };

            return Send(cancellationTransaction.ToXml(Encoding));
        }

        /// <summary>
        ///     Autorização de uma transação previamente gerada.
        /// </summary>
        /// <param name="tId">Identificador da transação.</param>
        /// <returns>
        ///     <see cref="CommunicationResult" />
        /// </returns>
        public CommunicationResult AuthorizeTransaction(string tId)
        {
            var authorizeTransaction = new AuthorizeTransaction
            {
                Id = Guid.NewGuid().ToString("N"),
                Tid = tId
            };

            return Send(authorizeTransaction.ToXml(Encoding));
        }

        /// <summary>
        ///     Recupera uma transação através do identificador da transação.
        /// </summary>
        /// <param name="tId">Identificador da transação.</param>
        /// <returns>
        ///     <see cref="CommunicationResult" />
        /// </returns>
        public CommunicationResult GetTransaction(string tId)
        {
            var requestTransaction = new RequestTransaction
            {
                Id = Guid.NewGuid().ToString("N"),
                Tid = tId
            };

            return Send(requestTransaction.ToXml(Encoding));
        }

        /// <summary>
        ///     Solicita a criação de um token associada a um cartão de crédito, para viabilizar o envio de transações sem o
        ///     cartão.
        /// </summary>
        /// <param name="number">Número do cartão.</param>
        /// <param name="expiration">Validade do cartão no formato aaaamm. Exemplo: 201212 (dez/2012).</param>
        /// <returns>
        ///     <see cref="CommunicationResult" />
        /// </returns>
        public CommunicationResult GetToken(long number, int expiration)
        {
            return GetToken(number, expiration, null);
        }

        /// <summary>
        ///     Solicita a criação de um token associada a um cartão de crédito, para viabilizar o envio de transações sem o
        ///     cartão.
        /// </summary>
        /// <param name="number">Número do cartão.</param>
        /// <param name="expiration">Validade do cartão no formato aaaamm. Exemplo: 201212 (dez/2012).</param>
        /// <param name="name">Nome impresso no cartão.</param>
        /// <returns>
        ///     <see cref="CommunicationResult" />
        /// </returns>
        public CommunicationResult GetToken(long number, int expiration, string name)
        {
            return GetToken(new Card
            {
                Expiration = expiration,
                Name = name,
                Number = number
            });
        }

        /// <summary>
        ///     Solicita a criação de um token associada a um cartão de crédito, para viabilizar o envio de transações sem o
        ///     cartão.
        /// </summary>
        /// <param name="card">
        ///     <see cref="Card" />
        /// </param>
        /// <returns>
        ///     <see cref="CommunicationResult" />
        /// </returns>
        public CommunicationResult GetToken(Card card)
        {
            var requestToken = new RequestToken
            {
                Id = Guid.NewGuid().ToString("N"),
                Card = card
            };

            return Send(requestToken.ToXml(Encoding));
        }

        /// <summary>
        ///     Cria uma transação com a Cielo.
        /// </summary>
        /// <param name="order">
        ///     <see cref="Order" />
        /// </param>
        /// <param name="brand">
        ///     <see cref="PaymentMethodBrand" />
        /// </param>
        /// <param name="returnUrl">
        ///     URL da página de retorno. É para essa página que a Cielo vai direcionar o browser ao fim da
        ///     autenticação ou da autorização. Não é obrigatório apenas para autorização direta, porém o campo dever ser inserido
        ///     como nulo ou vazio.
        /// </param>
        /// <returns>
        ///     <see cref="CommunicationResult" />
        /// </returns>
        public CommunicationResult CreateTransaction(Order order, PaymentMethodBrand brand, string returnUrl)
        {
            return CreateTransaction(order, new PaymentMethod
            {
                Brand = brand,
                Parcel = 1,
                Product = PaymentMethodProduct.CreditOneParcel
            }, returnUrl);
        }

        /// <summary>
        ///     Cria uma transação com a Cielo.
        /// </summary>
        /// <param name="order">
        ///     <see cref="Order" />
        /// </param>
        /// <param name="paymentMethod">
        ///     <see cref="PaymentMethod" />
        /// </param>
        /// <param name="returnUrl">
        ///     URL da página de retorno. É para essa página que a Cielo vai direcionar o browser ao fim da
        ///     autenticação ou da autorização. Não é obrigatório apenas para autorização direta, porém o campo dever ser inserido
        ///     como nulo ou vazio.
        /// </param>
        /// <returns>
        ///     <see cref="CommunicationResult" />
        /// </returns>
        public CommunicationResult CreateTransaction(Order order, PaymentMethod paymentMethod, string returnUrl)
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

        /// <summary>
        ///     Cria uma transação com a Cielo.
        /// </summary>
        /// <param name="transaction">
        ///     <see cref="Transaction" />
        /// </param>
        /// <returns>
        ///     <see cref="CommunicationResult" />
        /// </returns>
        public CommunicationResult CreateTransaction(Transaction transaction)
        {
            if (string.IsNullOrEmpty(transaction.Id))
            {
                transaction.Id = Guid.NewGuid().ToString("N");
            }

            return Send(transaction.ToXml(Encoding));
        }

        private CommunicationResult Send(string xml)
        {
            var request = (HttpWebRequest) WebRequest.Create(Configuration.Url);
            var data = string.Format("mensagem={0}", xml);
            string content;

            Log.Debug(string.Format("Xml enviado:\n{0}", xml));

            request.ContentLength = Encoding.GetBytes(data).Length;
            request.ContentType = string.Format("application/x-www-form-urlencoded; charset={0}", Encoding.WebName);
            request.Method = "POST";

            using (var streamWriter = new StreamWriter(request.GetRequestStream(), Encoding))
            {
                streamWriter.Write(data);
            }

            var response = (HttpWebResponse) request.GetResponse();
            var responseStream = response.GetResponseStream();

            if (responseStream == null)
            {
                return new CommunicationResult
                {
                    Error = new ErrorResult
                    {
                        Code = "99999",
                        Message = "Transação não obteve resposta"
                    }
                };
            }

            using (var streamReader = new StreamReader(responseStream, Encoding))
            {
                content = streamReader.ReadToEnd();
            }

            var result = new CommunicationResult
            {
                SentXml = xml
            };

            if (response.StatusCode != HttpStatusCode.OK)
            {
                var message = string.Format("Erro ao enviar mensagem.\n\nContent:\n{0}\n", response);

                Log.Debug(message);

                throw new Exception(message);
            }

            result.ReceivedXml = content;

            Log.Debug(string.Format("Xml recebido:\n{0}", result.ReceivedXml));

            if (content.Contains("</transacao>"))
            {
                result.Transaction = content.ToObject<TransactionResult>(Encoding);
            }
            else if (content.Contains("</erro>"))
            {
                result.Error = content.ToObject<ErrorResult>(Encoding);

                Log.Debug("Retorno de erro proveniente da Cielo");
                Log.Debug(string.Format("Código: {0}\nMensage: {1}", result.Error.Code, result.Error.Message));
            }
            else if (content.Contains("</retorno-token>"))
            {
                result.Token = content.ToObject<TokenResult>(Encoding);
            }

            return result;
        }
    }
}