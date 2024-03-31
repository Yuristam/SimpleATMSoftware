namespace SimpleATMSoftware.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public DateTime TransactionDate { get; set; }
        public decimal Sum { get; set; }
        public int SenderAccount { get; set; }
        public int ReceiverAccount { get; set; }
    }
}
