using System;
using System.Xml.Serialization;

namespace Cielo
{
    [XmlType]
    [Serializable]
    public class Authentication
    {
        public Authentication()
        {
            Number = Configuration.Number;
            Key = Configuration.Key;
        }

        [XmlElement("numero")]
        public string Number { get; set; }

        [XmlElement("chave")]
        public string Key { get; set; }
    }
}