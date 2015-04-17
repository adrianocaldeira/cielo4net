using System;
using System.Xml.Serialization;

namespace Cielo
{
    [XmlType]
    [Serializable]
    public enum CardSecurityCodeStatus
    {
        [XmlEnum("0")] NotProvided,
        [XmlEnum("1")] Provided,
        [XmlEnum("2")] Unreadable,
        [XmlEnum("9")] Absent
    }
}