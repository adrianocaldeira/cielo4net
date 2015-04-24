using System.Xml.Serialization;

namespace Cielo4Net
{
    /// <summary>
    ///     Retorno de comunicação com a Cielo.
    /// </summary>
    public class CommunicationResult
    {
        /// <summary>
        ///     Recupera ou define <see cref="ErrorResult" />.
        /// </summary>
        public ErrorResult Error { get; set; }

        /// <summary>
        ///     Recupera ou define <see cref="TransactionResult" />.
        /// </summary>
        public TransactionResult Transaction { get; set; }

        /// <summary>
        ///     Recupera ou define <see cref="TokenResult" />.
        /// </summary>
        public TokenResult Token { get; set; }
        
        /// <summary>
        ///     Recupera ou define XML de retorno.
        /// </summary>
        [XmlIgnore]
        public string Xml { get; set; }

        /// <summary>
        ///     É um erro.
        /// </summary>
        public bool IsError
        {
            get { return Error != null; }
        }

        /// <summary>
        ///     É uma transação.
        /// </summary>
        public bool IsTransaction
        {
            get { return Transaction != null; }
        }

        /// <summary>
        ///     É um token.
        /// </summary>
        public bool IsToken
        {
            get { return Token != null; }
        }
    }
}