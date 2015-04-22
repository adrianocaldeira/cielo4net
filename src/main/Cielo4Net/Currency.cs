using System;
using System.Xml.Serialization;

namespace Cielo4Net
{
    /// <summary>
    ///     Moeda.
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://ecommerce.cbmp.com.br")]
    public enum Currency
    {
        /// <summary>
        ///     Real
        /// </summary>
        [XmlEnum("986")] Real
    }
}