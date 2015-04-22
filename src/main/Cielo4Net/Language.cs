using System;
using System.Xml.Serialization;

namespace Cielo4Net
{
    /// <summary>
    ///     Idioma do pedido: PT (português), EN (inglês) ou ES (espanhol). Com base nessa informação é definida a língua a ser
    ///     utilizada nas telas da Cielo. Caso não seja enviado, o sistema assumirá “PT”.
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://ecommerce.cbmp.com.br")]
    public enum Language
    {
        /// <summary>
        ///     Português
        /// </summary>
        [XmlEnum("PT")] Portuguese,

        /// <summary>
        ///     Inglês
        /// </summary>
        [XmlEnum("EN")] English,

        /// <summary>
        ///     Espanhol
        /// </summary>
        [XmlEnum("ES")] Spanish
    }
}