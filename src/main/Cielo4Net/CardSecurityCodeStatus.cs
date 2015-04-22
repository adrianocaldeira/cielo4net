using System;
using System.Xml.Serialization;

namespace Cielo4Net
{
    /// <summary>
    ///     Status do código de segurança do cartão.
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://ecommerce.cbmp.com.br")]
    public enum CardSecurityCodeStatus
    {
        /// <summary>
        ///     Nenhum.
        /// </summary>
        None,

        /// <summary>
        ///     Não informado.
        /// </summary>
        [XmlEnum("0")] NotProvided,

        /// <summary>
        ///     Informado.
        /// </summary>
        [XmlEnum("1")] Provided,

        /// <summary>
        ///     Ilegível.
        /// </summary>
        [XmlEnum("2")] Unreadable,

        /// <summary>
        ///     Inexistente.
        /// </summary>
        [XmlEnum("9")] Absent
    }
}