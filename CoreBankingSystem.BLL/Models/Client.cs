namespace CoreBankingSystem.BLL.Models
{
    public class Client
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Login { get; set; }
        public string Password { get; set; } = string.Empty;

        public ICollection<Account> Accounts { get; set; } = new List<Account>();
        public ICollection<Deposit> Deposits { get; set; } = new List<Deposit>();
        public ICollection<Loan> Loans { get; set; } = new List<Loan>();
    }
}
