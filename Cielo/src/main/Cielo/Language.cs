using System;
using System.Xml.Serialization;

namespace Cielo
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://ecommerce.cbmp.com.br")]
    public enum Language
    {
        [XmlEnum("PT")]
        Portuguese,
        [XmlEnum("EN")]
        English,
        [XmlEnum("ES")]
        Spanish,
    }
}