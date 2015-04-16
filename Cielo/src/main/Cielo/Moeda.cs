using System;
using System.Xml.Serialization;

namespace Cielo
{
    [XmlType]
    [Serializable]
    public enum Moeda
    {
        [XmlEnum("986")]
        Real
    }
}