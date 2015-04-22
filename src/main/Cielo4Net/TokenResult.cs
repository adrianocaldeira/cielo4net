using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Cielo4Net
{
    /// <summary>
    ///     Retorno de token do cartão de crédito.
    /// </summary>
    [Serializable]
    [DebuggerStepThrough]
    [XmlType(Namespace = "http://ecommerce.cbmp.com.br")]
    [XmlRoot("retorno-token", Namespace = "http://ecommerce.cbmp.com.br", IsNullable = false)]
    public class TokenResult
    {
        /// <summary>
        ///     Recupera ou define <see cref="Token" />.
        /// </summary>
        [XmlElement("token")]
        public Token Token { get; set; }
    }
}