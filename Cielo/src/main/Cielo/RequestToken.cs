using System;
using System.Xml.Serialization;

namespace Cielo
{
    [Serializable]
    [XmlType(Namespace = "http://ecommerce.cbmp.com.br")]
    [XmlRoot("requisicao-token", Namespace = "http://ecommerce.cbmp.com.br", IsNullable = false)]
    public class RequestToken : Message
    {
        public RequestToken()
        {
            Authentication = new Authentication();
        }

        [XmlElement("dados-ec")]
        public Authentication Authentication { get; set; }

        [XmlElement("dados-portador")]
        public Card Card { get; set; }
    }
}