using System;
using System.Xml.Serialization;

namespace Cielo4Net
{
    /// <summary>
    ///     Criação de um token associada a um cartão de crédito, para viabilizar o envio de transações sem o cartão.
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "http://ecommerce.cbmp.com.br")]
    [XmlRoot("requisicao-token", Namespace = "http://ecommerce.cbmp.com.br", IsNullable = false)]
    public class RequestToken : Message
    {
        /// <summary>
        ///     Inicializa uma nova instância da classe <see cref="RequestToken" />. Na inicialização a propriedade Authentication
        ///     é automaticamente instânciada.
        /// </summary>
        public RequestToken()
        {
            Authentication = new Authentication();
        }

        /// <summary>
        ///     Recupera ou define <see cref="Authentication" />.
        /// </summary>
        [XmlElement("dados-ec")]
        public Authentication Authentication { get; set; }

        /// <summary>
        ///     Recupera ou define <see cref="Card" />.
        /// </summary>
        [XmlElement("dados-portador")]
        public Card Card { get; set; }
    }
}