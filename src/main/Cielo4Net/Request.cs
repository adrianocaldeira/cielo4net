using System;
using System.Xml.Serialization;

namespace Cielo4Net
{
    /// <summary>
    ///     Requisição base
    /// </summary>
    [Serializable]
    [XmlInclude(typeof (RequestTransaction))]
    [XmlInclude(typeof (AuthorizeTransaction))]
    [XmlInclude(typeof (CancellationTransaction))]
    [XmlInclude(typeof (CaptureTransaction))]
    [XmlType(Namespace = "http://ecommerce.cbmp.com.br")]
    public class Request : Message
    {
        /// <summary>
        ///     Inicializa uma nova instância da classe <see cref="Request" />. Na inicialização a propriedade Authentication é
        ///     automaticamente instânciada.
        /// </summary>
        public Request()
        {
            Authentication = new Authentication();
        }

        /// <summary>
        ///     Identificador da transação.
        /// </summary>
        [XmlElement("tid")]
        public string Tid { get; set; }

        /// <summary>
        ///     Recupera ou define <see cref="Authentication"/>.
        /// </summary>
        [XmlElement("dados-ec")]
        public Authentication Authentication { get; set; }
    }
}