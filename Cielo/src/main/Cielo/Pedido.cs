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
    public class Pedido
    {
        public Pedido()
        {
            Moeda = Moeda.Real;
            Idioma = Idioma.Pt;
            DataHora = DateTime.Now;
        }

        public Pedido(string numero, decimal valor, string descricao) : this()
        {
            Numero = numero;
            Valor = valor.SomenteNumeros();
            Descricao = descricao;
        }

        public string Numero { get; private set; }
        public Moeda Moeda { get; set; }
        public DateTime DataHora { get; private set; }
        public string Descricao { get; private set; }
        public Language Idioma { get; set; }
        public string DescricaoParaFatura { get; set; }
        public int TaxaEmbarque { get; set; }
        public int Valor { get; private set; }
    }

    [XmlType]
    [Serializable]
    public class Autenticacao
    {
        [XmlElementAttribute("numero")]
        public string Numero { get; set; }
        [XmlElementAttribute("chave")]
        public string Chave { get; set; }
    }
}