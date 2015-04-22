using System;
using System.Xml.Serialization;

namespace Cielo4Net
{
    /// <summary>
    ///     Status do token do cartão de crédito.
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://ecommerce.cbmp.com.br")]
    public enum TokenStatus
    {
        /// <summary>
        ///     Bloqueado
        /// </summary>
        [XmlEnum("0")] Blocked,

        /// <summary>
        ///     Desbloqueado
        /// </summary>
        [XmlEnum("1")] Unlocked
    }
}