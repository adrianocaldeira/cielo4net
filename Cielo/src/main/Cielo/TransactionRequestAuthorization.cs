using System;
using System.Xml.Serialization;

namespace Cielo
{
    [XmlType]
    [Serializable]
    public enum TransactionRequestAuthorization
    {
        [XmlEnum("0")]
        NotAuthorize,

        [XmlEnum("1")]
        AuthorizeOnlyIfAuthenticated,

        [XmlEnum("2")]
        AllowAuthenticatedAndUnauthenticated,

        [XmlEnum("3")]
        AuthorizeWithoutGoingThroughAuthentication = 4,

        [XmlEnum("4")]
        RecurringTransaction
    }
}