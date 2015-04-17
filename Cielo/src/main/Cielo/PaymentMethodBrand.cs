

using System;
using System.Xml.Serialization;

namespace Cielo
{
    [Serializable]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://ecommerce.cbmp.com.br")]
    public enum PaymentMethodBrand
    {
        /// <summary>
        ///     Visa
        /// </summary>
        [XmlEnumAttribute("visa")]
        Visa,

        /// <summary>
        ///     Mastercard
        /// </summary>
        [XmlEnumAttribute("mastercard")]
        Mastercard,

        /// <summary>
        ///     Diners
        /// </summary>
        [XmlEnumAttribute("diners")]
        Diners,

        /// <summary>
        ///     Discover
        /// </summary>
        [XmlEnumAttribute("discover")]
        Discover,

        /// <summary>
        ///     Elo
        /// </summary>
        [XmlEnumAttribute("elo")]
        Elo,

        /// <summary>
        ///     Amex
        /// </summary>
        [XmlEnumAttribute("amex")]
        Amex,

        /// <summary>
        ///     Jcb
        /// </summary>
        [XmlEnumAttribute("jcb")]
        Jcb,

        /// <summary>
        ///     Aura
        /// </summary>
        [XmlEnumAttribute("aura")]
        Aura
    }
}