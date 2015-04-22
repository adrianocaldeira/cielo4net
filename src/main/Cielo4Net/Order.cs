using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
using Cielo4Net.Extensions;

namespace Cielo4Net
{
    /// <summary>
    ///     Pedido
    /// </summary>
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://ecommerce.cbmp.com.br")]
    public class Order
    {
        /// <summary>
        ///     Inicializa uma nova instância da classe <see cref="Order" />. A moeda nessa inicializar será o real, o idioma
        ///     português e data e hora a atual.
        /// </summary>
        public Order()
        {
            Currency = Currency.Real;
            Language = Language.Portuguese;
            Date = DateTime.Now;
        }

        /// <summary>
        ///     Inicializa uma nova instância da classe <see cref="Order" />.
        /// </summary>
        /// <param name="number">Número do pedido da loja. Recomenda-se que seja um valor único por pedido.</param>
        /// <param name="amount">
        ///     Valor a ser cobrado pelo pedido (já deve incluir valores de frete, embrulho, custos extras, taxa
        ///     de embarque, etc). Esse valor é o que será debitado do consumidor.
        /// </param>
        /// <param name="description">Descrição do pedido.</param>
        public Order(string number, decimal amount, string description) : this()
        {
            Number = number;
            Amount = amount.OnlyNumbers();
            Description = description;
        }

        /// <summary>
        ///     Recupera ou define o número do pedido da loja. Recomenda-se que seja um valor único por pedido.
        /// </summary>
        [XmlElement("numero")]
        public string Number { get; set; }

        /// <summary>
        ///     Recupera ou define o valor a ser cobrado pelo pedido (já deve incluir valores de frete, embrulho, custos extras,
        ///     taxa de embarque, etc). Esse valor é o que será debitado do consumidor.
        /// </summary>
        [XmlElement("valor")]
        public int Amount { get; set; }

        /// <summary>
        ///     Recupera ou define <see cref="Currency" />.
        /// </summary>
        [XmlElement("moeda")]
        public Currency Currency { get; set; }

        /// <summary>
        ///     Recupera ou define a data e hora do pedido.
        /// </summary>
        [XmlElement("data-hora")]
        public DateTime Date { get; set; }

        /// <summary>
        ///     Recupera ou define descrição.
        /// </summary>
        [XmlElement("descricao")]
        public string Description { get; set; }

        /// <summary>
        ///     Recupera ou define <see cref="Language" />.
        /// </summary>
        [XmlElement("idioma")]
        public Language Language { get; set; }

        /// <summary>
        ///     Recupera ou define o valor destinado à taxa de embarque.
        /// </summary>
        [XmlElement("taxa-embarque")]
        public int DepartureTax { get; set; }

        /// <summary>
        ///     Recupera ou define texto impresso na fatura do portador. Texto de até 13 caracteres que será exibido na fatura do
        ///     portador, após o nome do Estabelecimento Comercial.
        /// </summary>
        [XmlElement("soft-descriptor")]
        public string ShortDescription { get; set; }
    }
}