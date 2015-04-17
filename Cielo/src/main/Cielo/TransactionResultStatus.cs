using System;
using System.Xml.Serialization;

namespace Cielo
{
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://ecommerce.cbmp.com.br")]
    public enum TransactionResultStatus
    {
        /// <summary>
        ///     Transação Criada
        /// </summary>
        [XmlEnum("0")] Built = 0,

        /// <summary>
        ///     Transação em Andamento
        /// </summary>
        [XmlEnum("1")] InProgress = 1,

        /// <summary>
        ///     Transação Autenticada
        /// </summary>
        [XmlEnum("2")] Authenticated = 2,

        /// <summary>
        ///     Transação não Autenticada
        /// </summary>
        [XmlEnum("3")] NotAuthenticated = 3,

        /// <summary>
        ///     Transação Autorizada
        /// </summary>
        [XmlEnum("4")] Authorized = 4,

        /// <summary>
        ///     Transação não Autorizada
        /// </summary>
        [XmlEnum("5")] NotAuthorized = 5,

        /// <summary>
        ///     Transação Capturada
        /// </summary>
        [XmlEnum("6")] Captured = 6,

        /// <summary>
        ///     Transação Cancelada
        /// </summary>
        [XmlEnum("9")] Canceled = 9,

        /// <summary>
        ///     Transação em Autenticação
        /// </summary>
        [XmlEnum("10")] InAuthentication = 10,

        /// <summary>
        ///     Transação em Cancelamento
        /// </summary>
        [XmlEnum("12")] InCancellation = 12
    }
}