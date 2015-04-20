using System;
using System.Xml.Serialization;

namespace Cielo
{
    [Serializable]
    [XmlInclude(typeof(RequestTransaction))]
    [XmlInclude(typeof(AuthorizeTransaction))]
    [XmlInclude(typeof(CancellationTransaction))]
    [XmlInclude(typeof(CaptureTransaction))]
    [XmlType(Namespace = "http://ecommerce.cbmp.com.br")]
    public class Request : Message
    {
        public Request()
        {
            Authentication = new Authentication();
        }

        /// <summary>
        /// Identificador da transação.
        /// </summary>
        [XmlElement("tid")]
        public string Tid { get; set; }

        /// <summary>
        /// Autenticação
        /// </summary>
        [XmlElement("dados-ec")]
        public Authentication Authentication { get; set; }
    }
}
