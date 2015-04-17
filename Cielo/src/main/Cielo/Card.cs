using System;
using System.Xml.Serialization;

namespace Cielo
{
    [XmlType]
    [Serializable]
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
