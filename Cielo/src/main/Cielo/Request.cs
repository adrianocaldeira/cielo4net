using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Cielo
{
    [Serializable]
    [XmlInclude(typeof(RequestTransaction))]
    [XmlType(Namespace = "http://ecommerce.cbmp.com.br")]
    public class Request : Message
    {
        public Request()
        {
            Authentication = new Authentication();
        }

        [XmlElement("tid")]
        public string Tid { get; set; }

        [XmlElement("dados-ec")]
        public Authentication Authentication { get; set; }
    }

    [Serializable]
    [XmlTypeAttribute(Namespace = "http://ecommerce.cbmp.com.br")]
    [XmlRootAttribute("requisicao-consulta", Namespace = "http://ecommerce.cbmp.com.br", IsNullable = false)]
    public class RequestTransaction : Request
    {
    }
}
