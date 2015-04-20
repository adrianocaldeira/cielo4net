using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Cielo
{
    [Serializable]
    [DebuggerStepThrough]
    [XmlType(Namespace = "http://ecommerce.cbmp.com.br")]
    [XmlRoot("retorno-token", Namespace = "http://ecommerce.cbmp.com.br", IsNullable = false)]
    public class TokenResult
    {
        [XmlElement("token")]
        public Token Token { get; set; }
    }
}