using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Cielo4Net
{
    /// <summary>
    ///     Resultado de cancelamento da transação.
    /// </summary>
    [XmlType]
    [Serializable]
    public class TransactionResultCancellation
    {
        /// <summary>
        ///     Recupera ou define lista de <see cref="TransactionResultCancellationItem" />.
        /// </summary>
        [XmlElement("cancelamento")]
        public List<TransactionResultCancellationItem> Items { get; set; }
    }
}