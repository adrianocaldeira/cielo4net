using System;
using System.Xml.Serialization;

namespace Cielo
{
    [XmlType]
    [Serializable]
    public class TokenData
    {
        [XmlElement("codigo-token")]
        public string Code { get; set; }

        [XmlElement("status")]
        public TokenStatus Status { get; set; }

        [XmlElement("numero-cartao-truncado")]
        public string TruncateCardNumber { get; set; }
    }
}