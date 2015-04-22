using System;
using System.Xml.Serialization;

namespace Cielo4Net
{
    /// <summary>
    ///     Base para comunicação com a Cielo
    /// </summary>
    [Serializable]
    [XmlInclude(typeof (Transaction))]
    [XmlInclude(typeof (TransactionResult))]
    [XmlInclude(typeof (Request))]
    [XmlInclude(typeof (RequestToken))]
    [XmlType(Namespace = "http://ecommerce.cbmp.com.br")]
    public class Message
    {
        /// <summary>
        ///     Inicializa uma nova instância da classe <see cref="Message" />.
        /// </summary>
        public Message()
        {
            Version = Version.V130;
        }

        /// <summary>
        ///     Recupera ou define identificador da comunicação com a cielo.
        /// </summary>
        [XmlAttribute("id")]
        public string Id { get; set; }

        /// <summary>
        ///     Recupera ou define a versão da mensagem.
        /// </summary>
        [XmlAttribute("versao")]
        public Version Version { get; set; }
    }
}