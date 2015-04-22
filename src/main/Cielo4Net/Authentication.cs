using System;
using System.Xml.Serialization;

namespace Cielo4Net
{
    /// <summary>
    ///     Autenticação com Cielo.
    /// </summary>
    [XmlType]
    [Serializable]
    public class Authentication
    {
        /// <summary>
        ///     Inicializa uma nova instância da classe <see cref="Authentication" />. Na inicialização o número e afilização e
        ///     chave de acesso é definida automaticamente através da configuração (app.config ou web.config).
        /// </summary>
        public Authentication()
        {
            Number = Configuration.Number;
            Key = Configuration.Key;
        }

        /// <summary>
        ///     Recupera ou define número de afiliação da loja com a Cielo.
        /// </summary>
        [XmlElement("numero")]
        public string Number { get; set; }

        /// <summary>
        ///     Recupera ou define chave de acesso da loja atribuída pela Cielo.
        /// </summary>
        [XmlElement("chave")]
        public string Key { get; set; }
    }
}