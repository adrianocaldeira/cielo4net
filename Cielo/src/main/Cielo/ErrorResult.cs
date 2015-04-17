using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Cielo
{
    [Serializable]
    [DebuggerStepThrough]
    [XmlType(Namespace = "http://ecommerce.cbmp.com.br")]
    [XmlRoot("erro", Namespace = "http://ecommerce.cbmp.com.br", IsNullable = false)]
    public class ErrorResult
    {
        [XmlElement("codigo")]
        public string Code { get; set; }

        [XmlElement("mensagem")]
        public string Message { get; set; }
    }
}