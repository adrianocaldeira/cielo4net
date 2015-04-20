using System;
using System.Xml.Serialization;

namespace Cielo
{
    /// <summary>
    ///    Cancelamento Total e Parcial
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "http://ecommerce.cbmp.com.br")]
    [XmlRoot("requisicao-cancelamento", Namespace = "http://ecommerce.cbmp.com.br", IsNullable = false)]
    public class CancellationTransaction : Request
    {
        /// <summary>
        /// Valor a ser cancelado. Caso não seja informado, será um cancelamento total.
        /// </summary>
        [XmlElement("valor")]
        public int? Amount { get; set; }

        /// <summary>
        /// Deve serializar propriedade amount
        /// </summary>
        /// <returns></returns>
        public bool ShouldSerializeAmount()
        {
            return Amount != null;
        }
    }
}