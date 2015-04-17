using System;
using System.Xml.Serialization;

namespace Cielo
{
    [XmlType]
    [Serializable]
    public enum Currency
    {
        [XmlEnum("986")] Real
    }
}