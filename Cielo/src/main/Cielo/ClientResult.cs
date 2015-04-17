namespace Cielo
{
    public class ClientResult
    {
        public ErrorResult Error { get; set; }
        public TransactionResult Transaction { get; set; }

        public bool IsError
        {
            get { return Error != null; }
        }

        public bool IsTransaction
        {
            get { return Transaction != null; }
        }
    }
}