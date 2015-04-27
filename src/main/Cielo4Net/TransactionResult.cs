using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Cielo4Net
{
    /// <summary>
    ///     Resultado da transação.
    /// </summary>
    [Serializable]
    [DebuggerStepThrough]
    [XmlType(Namespace = "http://ecommerce.cbmp.com.br")]
    [XmlRoot("transacao", Namespace = "http://ecommerce.cbmp.com.br", IsNullable = false)]
    public class TransactionResult : Message
    {
        /// <summary>
        ///     Recupera ou define identificador da transação.
        /// </summary>
        [XmlElement("tid")]
        public string Tid { get; set; }

        /// <summary>
        ///     Recupera ou define <see cref="Order" />.
        /// </summary>
        [XmlElement("dados-pedido")]
        public Order Order { get; set; }

        /// <summary>
        ///     Recupera ou define <see cref="PaymentMethod" />.
        /// </summary>
        [XmlElement("forma-pagamento")]
        public PaymentMethod PaymentMethod { get; set; }

        /// <summary>
        ///     Recupera ou define <see cref="TransactionResultStatus" />.
        /// </summary>
        [XmlElement("status")]
        public TransactionResultStatus Status { get; set; }

        /// <summary>
        ///     Recupera ou define URL de redirecionamento à Cielo.
        /// </summary>
        [XmlElement("url-autenticacao")]
        public string UrlAuthentication { get; set; }

        /// <summary>
        ///     Recupera ou define <see cref="TransactionResultAuthentication" />.
        /// </summary>
        [XmlElement("autenticacao")]
        public TransactionResultAuthentication Authentication { get; set; }

        /// <summary>
        ///     Recupera ou define <see cref="TransactionResultAuthorization" />.
        /// </summary>
        [XmlElement("autorizacao")]
        public TransactionResultAuthorization Authorization { get; set; }

        /// <summary>
        ///     Recupera ou define <see cref="TransactionResultCapture" />.
        /// </summary>
        [XmlElement("captura")]
        public TransactionResultCapture Capture { get; set; }

        /// <summary>
        ///     Recupera ou define <see cref="TransactionResultCancellation" />.
        /// </summary>
        [XmlElement("cancelamentos")]
        public TransactionResultCancellation Cancellation { get; set; }

        /// <summary>
        ///     Recupera ou define <see cref="Token" />.
        /// </summary>
        [XmlElement("token")]
        public Token Token { get; set; }
    }
}