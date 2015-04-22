using System;
using System.Xml.Serialization;

namespace Cielo4Net
{
    /// <summary>
    ///     Captura Total e Parcial.
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "http://ecommerce.cbmp.com.br")]
    [XmlRoot("requisicao-captura", Namespace = "http://ecommerce.cbmp.com.br", IsNullable = false)]
    public class CaptureTransaction : Request
    {
        /// <summary>
        ///     Recupera ou define valor a ser capturado. Caso não seja informado, será uma captura total.
        /// </summary>
        [XmlElement("valor")]
        public int? Amount { get; set; }

        /// <summary>
        ///     Recupera ou define montante do valor a ser capturado que deve ser destinado à Infraero. Este campo é obrigatório
        ///     quando a transação possui taxa de embarque e a captura for parcial.
        /// </summary>
        [XmlElement("taxa-embarque")]
        public int? DepartureTax { get; set; }

        /// <summary>
        ///     Deve serializar propriedade amount
        /// </summary>
        /// <returns></returns>
        public bool ShouldSerializeAmount()
        {
            return Amount != null;
        }

        /// <summary>
        ///     Deve serializar propriedade taxa de embarque
        /// </summary>
        /// <returns></returns>
        public bool ShouldSerializeDepartureTax()
        {
            return DepartureTax != null;
        }
    }
}