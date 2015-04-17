using System;
using System.Xml.Serialization;

namespace Cielo
{
    [XmlType]
    [Serializable]
    public class TransactionResultAuthentication
    {
        [XmlElement("codigo")]
        public string Code { get; set; }

        [XmlElement("mensagem")]
        public string Message { get; set; }

        [XmlElement("data-hora")]
        public DateTime Date { get; set; }

        [XmlElement("valor")]
        public int Amount { get; set; }

        [XmlElement("eci")]
        public int Eci { get; set; }
    }
}