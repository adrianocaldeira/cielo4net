using System;
using System.Xml.Serialization;

namespace Cielo
{
    [XmlType]
    [Serializable]
    public class PaymentMethod
    {
        public PaymentMethod()
        {
            Parcel = 1;
        }

        [XmlElement("bandeira")]
        public PaymentMethodBrand Brand { get; set; }

        [XmlElement("produto")]
        public PaymentMethodProduct Product { get; set; }

        [XmlElement("parcelas")]
        public int Parcel { get; set; }
    }
}