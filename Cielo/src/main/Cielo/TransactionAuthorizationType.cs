using System;
using System.Xml.Serialization;

namespace Cielo
{
    /// <summary>
    ///     Indicador de autorização:
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://ecommerce.cbmp.com.br")]
    public enum TransactionAuthorizationType
    {
        /// <summary>
        ///     Não autorizar (somente autenticar)
        /// </summary>
        [XmlEnum("0")] NotAuthorize,

        /// <summary>
        ///     Autorizar somente se autenticada
        /// </summary>
        [XmlEnum("1")] AuthorizeOnlyIfAuthenticated,

        /// <summary>
        ///     Autorizar autenticada e não autenticada
        /// </summary>
        [XmlEnum("2")] AllowAuthenticatedAndUnauthenticated,

        /// <summary>
        ///     Autorizar sem passar por autenticação (somente para crédito) – também conhecida como “Autorização Direta”. Obs.:
        ///     Para Diners, Discover, Elo, Amex, Aura e JCB o valor será sempre “3”, pois estas bandeiras não possuem programa de
        ///     autenticação.
        /// </summary>
        [XmlEnum("3")] AuthorizeWithoutGoingThroughAuthentication = 4,

        /// <summary>
        ///     Transação Recorrente
        /// </summary>
        [XmlEnum("4")] RecurringTransaction
    }
}