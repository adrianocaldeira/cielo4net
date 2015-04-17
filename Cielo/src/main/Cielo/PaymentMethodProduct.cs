using System;
using System.Xml.Serialization;

namespace Cielo
{
    /// <summary>
    /// Código do produto
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://ecommerce.cbmp.com.br")]
    public enum PaymentMethodProduct
    {
        /// <summary>
        ///     Crédito à Vista
        /// </summary>
        [XmlEnum("1")] CreditOneParcel,

        /// <summary>
        ///     Parcelado loja
        /// </summary>
        [XmlEnum("2")] Installment,

        /// <summary>
        ///     Débito
        /// </summary>
        [XmlEnum("A")] Debit
    }
}