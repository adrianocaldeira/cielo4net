using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Cielo4Net
{
    /// <summary>
    ///     Retorno de erro.
    /// </summary>
    [Serializable]
    [DebuggerStepThrough]
    [XmlType(Namespace = "http://ecommerce.cbmp.com.br")]
    [XmlRoot("erro", Namespace = "http://ecommerce.cbmp.com.br", IsNullable = false)]
    public class ErrorResult
    {
        /// <summary>
        ///     Recupera ou define código.
        /// </summary>
        [XmlElement("codigo")]
        public string Code { get; set; }

        /// <summary>
        ///     Recupera ou define mensagem.
        /// </summary>
        [XmlElement("mensagem")]
        public string Message { get; set; }
    }
}