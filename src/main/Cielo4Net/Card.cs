using System;
using System.Xml.Serialization;

namespace Cielo4Net
{
    /// <summary>
    ///     Dados do cartão.
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "http://ecommerce.cbmp.com.br")]
    public class Card
    {
        /// <summary>
        ///     Recupera ou define número do cartão.
        /// </summary>
        [XmlElement("numero")]
        public long Number { get; set; }

        /// <summary>
        ///     Recupera ou define validade do cartão no formato aaaamm. Exemplo: 201212 (dez/2012).
        /// </summary>
        [XmlElement("validade")]
        public int Expiration { get; set; }

        /// <summary>
        ///     Recupera ou define indicador sobre o envio do Código de segurança.
        /// </summary>
        [XmlElement("indicador")]
        public CardSecurityCodeStatus SecurityCodeStatus { get; set; }

        /// <summary>
        ///     Recupera ou define código de segurança, obrigatório se indicador for Provided.
        /// </summary>
        [XmlElement("codigo-seguranca")]
        public string SecurityCode { get; set; }

        /// <summary>
        ///     Recupera ou define nome impresso no cartão.
        /// </summary>
        [XmlElement("nome-portador")]
        public string Name { get; set; }

        /// <summary>
        ///     Recupera ou define token que deve ser utilizado em substituição aos dados do cartão para uma autorização direta ou
        ///     uma transação recorrente. Não é permitido o envio do token junto com os dados do cartão na mesma transação.
        /// </summary>
        [XmlElement("token")]
        public string Token { get; set; }

        /// <summary>
        ///     Deve serializar propriedade status do código de segurança
        /// </summary>
        /// <returns></returns>
        public bool ShouldSerializeSecurityCodeStatus()
        {
            return SecurityCodeStatus != CardSecurityCodeStatus.None;
        }

        /// <summary>
        ///     Deve serializar propriedade código de segurança
        /// </summary>
        /// <returns></returns>
        public bool ShouldSerializeSecurityCode()
        {
            return !string.IsNullOrWhiteSpace(SecurityCode);
        }

        /// <summary>
        ///     Deve serializar propriedade token
        /// </summary>
        /// <returns></returns>
        public bool ShouldSerializeToken()
        {
            return !string.IsNullOrWhiteSpace(Token);
        }

        /// <summary>
        ///     Deve serializar propriedade nome
        /// </summary>
        /// <returns></returns>
        public bool ShouldSerializeName()
        {
            return !string.IsNullOrWhiteSpace(Name);
        }
    }
}