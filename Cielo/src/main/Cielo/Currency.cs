using System;
using System.Xml.Serialization;

namespace Cielo
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://ecommerce.cbmp.com.br")]
    public enum Currency
    {
        [XmlEnum("986")] Real
    }
}