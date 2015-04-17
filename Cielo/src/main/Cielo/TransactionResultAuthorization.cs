using System;
using System.Xml.Serialization;

namespace Cielo
{
    [XmlType]
    [Serializable]
    public class TransactionResultAuthorization
    {
        [XmlElement("codigo")]
        public string Code { get; set; }

        [XmlElement("mensagem")]
        public string Message { get; set; }

        [XmlElement("data-hora")]
        public DateTime Date { get; set; }

        [XmlElement("valor")]
        public int Amount { get; set; }

        [XmlElement("lr")]
        public int Lr { get; set; }

        [XmlElement("nsu")]
        public int Nsu { get; set; }
    }
}