using System;
using System.Xml.Serialization;

namespace Cielo4Net
{
    /// <summary>
    ///     Forma de pagamento
    /// </summary>
    [XmlType]
    [Serializable]
    public class PaymentMethod
    {
        /// <summary>
        ///     Inicializa uma nova instância da classe <see cref="PaymentMethod" />.
        /// </summary>
        public PaymentMethod()
        {
            Parcel = 1;
        }

        /// <summary>
        ///     Recupera ou define <see cref="PaymentMethodBrand" />.
        /// </summary>
        [XmlElement("bandeira")]
        public PaymentMethodBrand Brand { get; set; }

        /// <summary>
        ///     Recupera ou define <see cref="PaymentMethodProduct" />.
        /// </summary>
        [XmlElement("produto")]
        public PaymentMethodProduct Product { get; set; }

        /// <summary>
        ///     Recupera ou define número de parcelas. Para crédito à vista ou débito, utilizar “1”.
        /// </summary>
        [XmlElement("parcelas")]
        public int Parcel { get; set; }
    }
}