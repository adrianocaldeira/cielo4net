using System;
using System.Xml.Serialization;

namespace Cielo
{
    [Serializable()]
    [XmlType(Namespace = "https://ecommerce.cbmp.com.br")]
    public enum Idioma
    {
        PT,
        EN,
        ES,
    }
}