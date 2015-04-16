using System;
using System.Xml.Serialization;

namespace Cielo
{
    [XmlType]
    [Serializable]
    public class Authentication
    {
        [XmlElement("numero")]
        public string Number { get; set; }
        [XmlElement("chave")]
        public string Key { get; set; }
    }
}