using System;
using System.Xml.Serialization;

namespace Cielo
{
    [Serializable]
    [XmlType(Namespace = "https://qasecommerce.cielo.com.br")]
    [XmlRoot("requisicao-transacao", Namespace = "https://qasecommerce.cielo.com.br", IsNullable = false)]
    public class TransactionRequest
    {
        public TransactionRequest()
        {
            Version = Version.V130;
        }

        [XmlAttribute("id")]
        public string Id { get; set; }

        [XmlAttribute("versao")]
        public Version Version { get; set; }

        [XmlElement("dados-ec")]
        public Authentication Authentication { get; set; }

        [XmlElement("dados-portador")]
        public Card Card { get; set; }

        [XmlElement("dados-pedido")]
        public Order Order { get; set; }

        [XmlElement("forma-pagamento")]
        public PaymentMethod PaymentMethod { get; set; }

        [XmlElement("url-retorno")]
        public string ReturnUrl { get; set; }

        [XmlElement("autorizar")]
        public TransactionRequestAuthorization AuthorizationType { get; set; }

        [XmlElement("capturar")]
        public bool Capture { get; set; }

        [XmlElement("bin")]
        public int Bin { get; set; }

        [XmlElement("gerar-token")]
        public bool GenerateToken { get; set; }

    }
}