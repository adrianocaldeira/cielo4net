using System;
using System.Xml.Serialization;

namespace Cielo4Net
{
    /// <summary>
    /// Token do cartão de crédito.
    /// </summary>
    [XmlType]
    [Serializable]
    public class Token
    {
        /// <summary>
        /// Recupera ou define <see cref="TokenData"/>.
        /// </summary>
        [XmlElement("dados-token")]
        public TokenData Data { get; set; }
    }
}