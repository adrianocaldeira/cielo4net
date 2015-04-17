using System;
using System.Xml.Serialization;

namespace Cielo
{
    [XmlType]
    [Serializable]
    public enum PaymentMethodProduct
    {
        [XmlEnum("1")]
        CreditOneParcel,

        [XmlEnum("2")]
        Installment,

        [XmlEnum("A")]
        Debit
    }
}