using System;
using System.Xml.Serialization;

namespace Cielo
{
    [Serializable]
    [XmlType(Namespace = "http://ecommerce.cbmp.com.br")]
    public class Card
    {
        [XmlElement("numero")]
        public int Number { get; set; }

        [XmlElement("validade")]
        public int Expiration { get; set; }

        [XmlElement("indicador")]
        public CardSecurityCodeStatus SecurityCodeStatus { get; set; }

        [XmlElement("codigo-seguranca")]
        public int SecurityCode { get; set; }

        [XmlElement("nome-portador")]
        public string Name { get; set; }

        [XmlElement("token")]
        public string Token { get; set; }
    }
}
