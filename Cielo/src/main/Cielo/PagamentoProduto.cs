using System;
using System.Xml.Serialization;

namespace Cielo
{
    [XmlType]
    [Serializable]
    public enum PagamentoProduto
    {
        [XmlEnum("1")]
        CreditoAVista,

        [XmlEnum("2")]
        ParceladoLoja,

        [XmlEnum("A")]
        Debito
    }
}