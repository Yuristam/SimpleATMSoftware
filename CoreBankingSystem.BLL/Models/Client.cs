namespace CoreBankingSystem.BLL.Models
{
    public class Client
    {
        public Guid ClientId { get; set; }
        public string Name { get; set; }
        public int Login { get; set; }
        public string Password { get; set; }

        public ICollection<Account> Accounts { get; set; } = new List<Account>();
        public ICollection<Deposit> Deposits { get; set; } = new List<Deposit>();
        public ICollection<Loan> Loans { get; set; } = new List<Loan>();
    }
}
