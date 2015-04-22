using System;
using System.Xml.Serialization;

namespace Cielo4Net
{
    /// <summary>
    /// Consulta de uma transação através do TID informado.
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "http://ecommerce.cbmp.com.br")]
    [XmlRoot("requisicao-consulta", Namespace = "http://ecommerce.cbmp.com.br", IsNullable = false)]
    public class RequestTransaction : Request
    {
    }
}