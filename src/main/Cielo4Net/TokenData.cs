using System;
using System.Xml.Serialization;

namespace Cielo4Net
{
    /// <summary>
    ///     Dados do token do cartão de crédito.
    /// </summary>
    [XmlType]
    [Serializable]
    public class TokenData
    {
        /// <summary>
        ///     Recupera ou define código.
        /// </summary>
        [XmlElement("codigo-token")]
        public string Code { get; set; }

        /// <summary>
        ///     Recupera ou define <see cref="TokenStatus" />.
        /// </summary>
        [XmlElement("status")]
        public TokenStatus Status { get; set; }

        /// <summary>
        ///     Recupera ou define número do cartão truncado.
        /// </summary>
        [XmlElement("numero-cartao-truncado")]
        public string TruncateCardNumber { get; set; }
    }
}