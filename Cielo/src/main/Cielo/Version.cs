using System;
using System.Xml.Serialization;

namespace Cielo
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://ecommerce.cbmp.com.br")]
    public enum Version
    {
        [XmlEnum("1.2.0")]
        V120,
        [XmlEnum("1.2.1")]
        V121,
        [XmlEnum("1.3.0")]
        V130
    }
}