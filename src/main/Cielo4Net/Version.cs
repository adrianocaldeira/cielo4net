using System;
using System.Xml.Serialization;

namespace Cielo4Net
{
    /// <summary>
    ///     Versão.
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://ecommerce.cbmp.com.br")]
    public enum Version
    {
        /// <summary>
        ///     1.2.0
        /// </summary>
        [XmlEnum("1.2.0")] V120,

        /// <summary>
        ///     1.2.1
        /// </summary>
        [XmlEnum("1.2.1")] V121,

        /// <summary>
        ///     1.3.0
        /// </summary>
        [XmlEnum("1.3.0")] V130
    }
}