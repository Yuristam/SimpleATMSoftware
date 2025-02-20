using CoreBankingSystem.DAL.Enums;

namespace CoreBankingSystem.DAL.Models
{
    public class Account
    {
        public int Id { get; set; }
        public long AccountNumber { get; set; }
        public AccountType AccountType { get; set; }
        public decimal Balance { get; set; }
        public Currency Currency { get; set; }

        public ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
        public byte TransactionsLimitPerDay { get; set; }
        public bool IsAccountBlocked { get; set; }

        public int ClientId { get; set; }
        public Client Client { get; set; }
    }
}
