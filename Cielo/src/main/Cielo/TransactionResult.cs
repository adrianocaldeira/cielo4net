using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Cielo
{
    [Serializable]
    [DebuggerStepThrough]
    [XmlType(Namespace = "http://ecommerce.cbmp.com.br")]
    [XmlRoot("transacao", Namespace = "http://ecommerce.cbmp.com.br", IsNullable = false)]
    public class TransactionResult : Message
    {
        [XmlElement("tid")]
        public string Tid { get; set; }

        [XmlElement("dados-pedido")]
        public Order Order { get; set; }

        [XmlElement("forma-pagamento")]
        public PaymentMethod PaymentMethod { get; set; }

        [XmlElement("status")]
        public TransactionResultStatus Status { get; set; }

        [XmlElement("url-autenticacao")]
        public string UrlAuthentication { get; set; }

        [XmlElement("autenticacao")]
        public TransactionResultAuthentication Authentication { get; set; }

        [XmlElement("autorizacao")]
        public TransactionResultAuthorization Authorization { get; set; }

        [XmlElement("captura")]
        public TransactionResultCapture Capture { get; set; }

        [XmlElement("cancelamentos")]
        public TransactionResultCancellation Cancellation { get; set; }

        [XmlIgnore]
        public string Xml { get; set; }
    }
}