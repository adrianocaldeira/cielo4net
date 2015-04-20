using System;
using System.Xml.Serialization;

namespace Cielo
{
    [XmlType]
    [Serializable]
    public class Token
    {
        [XmlElement("dados-token")]
        public TokenData Data { get; set; }
    }
}