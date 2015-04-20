using System;
using System.Xml.Serialization;

namespace Cielo
{
    [Serializable]
    [XmlType(Namespace = "http://ecommerce.cbmp.com.br")]
    [XmlRoot("requisicao-consulta", Namespace = "http://ecommerce.cbmp.com.br", IsNullable = false)]
    public class RequestTransaction : Request
    {
    }
}