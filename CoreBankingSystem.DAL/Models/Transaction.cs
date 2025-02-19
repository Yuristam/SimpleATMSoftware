using CoreBankingSystem.DAL.Enums;

namespace CoreBankingSystem.DAL.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public DateTime TransactionDate { get; set; }
        public decimal Amount { get; set; }
        public TransactionType TransactionType { get; set; }
        public int SenderAccount { get; set; }
        public int ReceiverAccount { get; set; }

        public int AccountId { get; set; }
        public Account Account { get; set; }
    }
}
