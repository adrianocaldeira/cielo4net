using System;
using System.Xml.Serialization;

namespace Cielo4Net
{
    /// <summary>
    /// Bandeira do cartão.
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://ecommerce.cbmp.com.br")]
    public enum PaymentMethodBrand
    {
        /// <summary>
        ///     Visa
        /// </summary>
        [XmlEnum("visa")]
        Visa,

        /// <summary>
        ///     Mastercard
        /// </summary>
        [XmlEnum("mastercard")]
        Mastercard,

        /// <summary>
        ///     Diners
        /// </summary>
        [XmlEnum("diners")]
        Diners,

        /// <summary>
        ///     Discover
        /// </summary>
        [XmlEnum("discover")]
        Discover,

        /// <summary>
        ///     Elo
        /// </summary>
        [XmlEnum("elo")]
        Elo,

        /// <summary>
        ///     Amex
        /// </summary>
        [XmlEnum("amex")]
        Amex,

        /// <summary>
        ///     Jcb
        /// </summary>
        [XmlEnum("jcb")]
        Jcb,

        /// <summary>
        ///     Aura
        /// </summary>
        [XmlEnum("aura")]
        Aura
    }
}