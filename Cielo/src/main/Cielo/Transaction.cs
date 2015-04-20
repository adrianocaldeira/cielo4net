using System;
using System.Xml.Serialization;

namespace Cielo
{
    [Serializable]
    [XmlType(Namespace = "http://ecommerce.cbmp.com.br")]
    [XmlRoot("requisicao-transacao", Namespace = "http://ecommerce.cbmp.com.br", IsNullable = false)]
    public class Transaction : Message
    {
        public Transaction()
        {
            Authentication = new Authentication();
            AuthorizationType = TransactionAuthorizationType.AllowAuthenticatedAndUnauthenticated;
            Capture = true;
        }

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
        public TransactionAuthorizationType AuthorizationType { get; set; }

        [XmlElement("capturar")]
        public bool Capture { get; set; }

        [XmlElement("campo-livre")]
        public string FreeField { get; set; }

        [XmlElement("bin")]
        public int? Bin { get; set; }

        [XmlElement("gerar-token")]
        public bool? GenerateToken { get; set; }

        [XmlText]
        [XmlElement("avs")]
        public string Avs { get; set; }

        public bool ShouldSerializeFreeField()
        {
            return !string.IsNullOrWhiteSpace(FreeField);
        }

        public bool ShouldSerializeBin()
        {
            return Bin != null;
        }

        public bool ShouldSerializeGenerateToken()
        {
            return GenerateToken != null;
        }

        public bool ShouldSerializeAvs()
        {
            return !string.IsNullOrWhiteSpace(Avs);
        }
    }
}