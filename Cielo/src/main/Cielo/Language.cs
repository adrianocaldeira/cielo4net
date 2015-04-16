using System;
using System.Xml.Serialization;

namespace Cielo
{
    [XmlType]
    [Serializable]
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