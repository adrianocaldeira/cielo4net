using System;
using System.Xml.Serialization;

namespace Cielo
{
    [XmlType]
    [Serializable]
    public class Pagamento
    {
        public Pagamento()
        {
            Parcelas = 1;
        }
        [XmlElement("bandeira")]
        public PagamentoBandeira Bandeira { get; set; }
        [XmlElement("produto")]
        public PagamentoProduto Produto { get; set; }
        [XmlElement("parcelas")]
        public int Parcelas { get; set; }
    }
}