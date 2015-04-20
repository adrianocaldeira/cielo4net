using System;
using System.Xml.Serialization;

namespace Cielo
{
    /// <summary>
    ///     Dados do cartão
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "http://ecommerce.cbmp.com.br")]
    public class Card
    {
        /// <summary>
        ///     Número do cartão.
        /// </summary>
        [XmlElement("numero")]
        public long Number { get; set; }

        /// <summary>
        ///     Validade do cartão no formato aaaamm. Exemplo: 201212 (dez/2012).
        /// </summary>
        [XmlElement("validade")]
        public int Expiration { get; set; }

        /// <summary>
        ///     Indicador sobre o envio do Código de segurança
        /// </summary>
        [XmlElement("indicador")]
        public CardSecurityCodeStatus SecurityCodeStatus { get; set; }

        /// <summary>
        ///     Código de segurança, obrigatório se indicador = 1
        /// </summary>
        [XmlElement("codigo-seguranca")]
        public int SecurityCode { get; set; }

        /// <summary>
        ///     Nome impresso no cartão.
        /// </summary>
        [XmlElement("nome-portador")]
        public string Name { get; set; }

        /// <summary>
        ///     Token que deve ser utilizado em substituição aos dados do cartão para uma autorização direta ou uma transação
        ///     recorrente. Não é permitido o envio do token junto com os dados do cartão na mesma transação.
        /// </summary>
        [XmlElement("token")]
        public string Token { get; set; }

        public bool ShouldSerializeSecurityCodeStatus()
        {
            return SecurityCodeStatus != CardSecurityCodeStatus.None;
        }

        public bool ShouldSerializeSecurityCode()
        {
            return SecurityCode != 0;
        }

        public bool ShouldSerializeToken()
        {
            return !string.IsNullOrWhiteSpace(Token);
        }

        public bool ShouldSerializeName()
        {
            return !string.IsNullOrWhiteSpace(Name);
        }
    }
}