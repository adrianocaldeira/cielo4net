using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Cielo
{
    [XmlType]
    [Serializable]
    public class TransactionResultCancellation
    {
        [XmlElement("cancelamento")]
        public List<TransactionResultCancellationItem> Items { get; set; }
    }
}