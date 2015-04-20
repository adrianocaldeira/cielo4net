using System;
using System.Xml.Serialization;

namespace Cielo
{
    /// <summary>
    /// Autenticação com Cielo
    /// </summary>
    [XmlType]
    [Serializable]
    public class Authentication
    {
        public Authentication()
        {
            Number = Configuration.Number;
            Key = Configuration.Key;
        }

        /// <summary>
        /// Número de afiliação da loja com a Cielo.
        /// </summary>
        [XmlElement("numero")]
        public string Number { get; set; }

        /// <summary>
        /// Chave de acesso da loja atribuída pela Cielo.
        /// </summary>
        [XmlElement("chave")]
        public string Key { get; set; }
    }
}