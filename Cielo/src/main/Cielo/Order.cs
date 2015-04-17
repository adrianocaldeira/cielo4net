using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
using Cielo.Extensions;

namespace Cielo
{
    [XmlType]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    public class Order
    {
        public Order()
        {
            Currency = Currency.Real;
            Language = Language.Portuguese;
            Date = DateTime.Now;
        }

        public Order(string number, decimal amount, string description) : this()
        {
            Number = number;
            Amount = amount.OnlyNumbers();
            Description = description;
        }

        [XmlElement("numero")]
        public string Number { get; set; }

        [XmlElement("moeda")]
        public Currency Currency { get; set; }

        [XmlElement("data-hora")]
        public DateTime Date { get; set; }

        [XmlElement("descricao")]
        public string Description { get; set; }

        [XmlElement("idioma")]
        public Language Language { get; set; }

        [XmlElement("soft-descriptor")]
        public string ShortDescription { get; set; }

        [XmlElement("taxa-embarque")]
        public int DepartureTax { get; set; }

        [XmlElement("valor")]
        public int Amount { get; set; }
    }
}