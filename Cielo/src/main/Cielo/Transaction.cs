using System;
using System.Xml.Serialization;

namespace Cielo
{
    [Serializable]
    [XmlType(Namespace = "https://qasecommerce.cielo.com.br")]
    [XmlRoot("requisicao-transacao", Namespace = "https://qasecommerce.cielo.com.br", IsNullable = false)]
    public class Transaction
    {
        public Transaction()
        {
            Version = Version.V130;
        }
        [XmlAttribute("id")]
        public string Id { get; set; }

        [XmlElement("versao")]
        public Version Version { get; set; }

        [XmlElement("dados-ec")]
        public Authentication Autenticacao { get; set; }

        [XmlElement("forma-pagamento")]
        public Pagamento Pagamento { get; set; }
    }
}