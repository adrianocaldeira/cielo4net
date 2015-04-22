using System;
using System.Xml.Serialization;

namespace Cielo4Net
{
    /// <summary>
    ///     Autenticação do resultado da autorização.
    /// </summary>
    [XmlType]
    [Serializable]
    public class TransactionResultAuthentication
    {
        /// <summary>
        ///     ´Recupera ou define código do processamento.
        /// </summary>
        [XmlElement("codigo")]
        public string Code { get; set; }

        /// <summary>
        ///     Recupera ou define detalhe do processamento.
        /// </summary>
        [XmlElement("mensagem")]
        public string Message { get; set; }

        /// <summary>
        ///     Recupera ou define data e hora do processamento.
        /// </summary>
        [XmlElement("data-hora")]
        public DateTime Date { get; set; }

        /// <summary>
        ///     Recupera ou define valor do processamento sem pontuação. Os dois últimos dígitos são os centavos.
        /// </summary>
        [XmlElement("valor")]
        public int Amount { get; set; }

        /// <summary>
        ///     Recupera ou define ECI(Eletronic Commerce Indicator) representa o quão segura é uma transação.
        /// </summary>
        [XmlElement("eci")]
        public int Eci { get; set; }
    }
}