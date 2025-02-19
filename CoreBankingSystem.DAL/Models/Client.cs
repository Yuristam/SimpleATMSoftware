namespace CoreBankingSystem.DAL.Models
{
    public class Client : User
    {
        public Client(int id, string firstName, string lastName, string login, string password, string confirmPassword) 
            : base(id, firstName, lastName, login, password, confirmPassword)
        {
        }

        public int PhoneNumber { get; set; }

        public int AddressId { get; set; }
        public Address Address { get; set; }

        public ICollection<Account> Accounts { get; set; } = new List<Account>();
        public ICollection<Deposit> Deposits { get; set; } = new List<Deposit>();
        public ICollection<Loan> Loans { get; set; } = new List<Loan>();
    }
}
