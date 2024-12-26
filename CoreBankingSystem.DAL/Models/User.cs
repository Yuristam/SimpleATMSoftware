namespace CoreBankingSystem.DAL.Models
{
    /// <summary>
    /// User Model
    /// </summary>
    public class User
    {
        /// <summary>
        /// User Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// First Name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Last Name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Full Name
        /// </summary>
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        /// <summary>
        /// Short Name
        /// </summary>
        public string ShortName
        {
            get
            {
                return $"{FirstName} {LastName.Substring(0, 1)}.";
            }
        }

        /// <summary>
        /// User Login (6-digit number)
        /// </summary>
        public int Login { get; set; }

        /// <summary>
        /// PIN (4-digit number)
        /// </summary>
        public int PIN { get; set; }

        /// <summary>
        /// User Password
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// User Account
        /// </summary>
        public ICollection<Account> Accounts { get; set; } = new List<Account>();
        
        /// <summary>
        /// Deposits
        /// </summary>
        public ICollection<Deposit> Deposits { get; set; } = new List<Deposit>();
        
        /// <summary>
        /// Loans
        /// </summary>
        public ICollection<Loan> Loans { get; set; } = new List<Loan>();
    }
}