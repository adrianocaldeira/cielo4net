

using System;
using System.Xml.Serialization;

namespace Cielo
{
    [Serializable]
    [XmlType]
    public enum PagamentoProduto
    {
        [XmlEnumAttribute("1")]
        CreditoAVista,

        [XmlEnumAttribute("2")]
        ParceladoLoja,

        [XmlEnumAttribute("A")]
        Debito
    }

    /// <summary>
    ///     Bandeiras aceita pela Cielo
    /// </summary>
    [Serializable]
    [XmlType]    
    public enum PagamentoBandeira
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