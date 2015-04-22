using System;
using System.Xml.Serialization;

namespace Cielo4Net
{
    /// <summary>
    ///     Item de <see cref="TransactionResultCancellation" />.
    /// </summary>
    [XmlType]
    [Serializable]
    public class TransactionResultCancellationItem
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

        /// <summary>
        ///     Recupera ou define data e hora.
        /// </summary>
        [XmlElement("data-hora")]
        public DateTime Date { get; set; }

        /// <summary>
        ///     Recupera ou define valor.
        /// </summary>
        [XmlElement("valor")]
        public int Amount { get; set; }

        /// <summary>
        ///     Recupera ou define taxa de embarque.
        /// </summary>
        [XmlElement("taxa-embarque")]
        public int DepartureTax { get; set; }
    }
}