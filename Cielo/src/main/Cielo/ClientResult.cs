namespace Cielo
{
    public class ClientResult
    {
        public ErrorResult Error { get; set; }
        public TransactionResult Transaction { get; set; }
        public TokenResult Token { get; set; }

        public bool IsError
        {
            get { return Error != null; }
        }

        public bool IsTransaction
        {
            get { return Transaction != null; }
        }

        public bool IsToken
        {
            get { return Token != null; }
        }
    }
}