using System;
using System.Xml.Serialization;

namespace Cielo
{
    [Serializable]
    [XmlInclude(typeof(Transaction))]
    [XmlInclude(typeof(TransactionResult))]
    [XmlInclude(typeof(Request))]
    [XmlType(Namespace = "http://ecommerce.cbmp.com.br")]
    public class Message
    {
        public Message()
        {
            Version = Version.V130;
        }

        [XmlAttribute("id")]
        public string Id { get; set; }

        [XmlAttribute("versao")]
        public Version Version { get; set; }
    }
}