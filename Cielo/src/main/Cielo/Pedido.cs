using System;
using System.Xml.Serialization;
using Cielo.Extensions;

namespace Cielo
{
    [Serializable]
    //[DebuggerStepThrough]
    //[DesignerCategory("code")]
    [XmlType(Namespace = "https://ecommerce.cbmp.com.br")]
    public class Pedido
    {
        public Pedido()
        {
            Moeda = Moeda.Real;
            Idioma = Idioma.PT;
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
        public Idioma Idioma { get; set; }
        public string DescricaoParaFatura { get; set; }
        public int TaxaEmbarque { get; set; }
        public int Valor { get; private set; }
    }

    [Serializable]
    [XmlTypeAttribute(Namespace = "https://qasecommerce.cielo.com.br")]
    [XmlRootAttribute("requisicao-transacao", Namespace = "https://qasecommerce.cielo.com.br", IsNullable = false)]
    public class Transacao
    {
        [XmlElementAttribute("dados-ec")]
        public Autenticacao Autenticacao { get; set; }
        [XmlElementAttribute("forma-pagamento")]
        public Pagamento Pagamento { get; set; }
    }

    [XmlType]
    [Serializable]
    public class Pagamento
    {
        public Pagamento()
        {
            Parcelas = 1;
        }
        [XmlElementAttribute("bandeira")]
        public PagamentoBandeira Bandeira { get; set; }
        [XmlElementAttribute("produto")]
        public PagamentoProduto Produto { get; set; }
        [XmlElementAttribute("parcelas")]
        public int Parcelas { get; set; }
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