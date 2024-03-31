namespace SimpleATMSoftware.Models
{
    public class User
    {
        /// <summary>
        /// User Id
        /// </summary>
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
        public string ShortName
        {
            get
            {
                return $"{FirstName} {LastName.Substring(0, 1)}.";
            }
        }
        /// <summary>
        /// 16-digit number
        /// </summary>
        public long Account { get; set; }
        /// <summary>
        /// 6-digit number
        /// </summary>
        public int Login { get; set; }
        /// <summary>
        /// 4-digit number
        /// </summary>
        public int PIN { get; set; }
        /// <summary>
        /// User Password
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// User Balance
        /// </summary>
        public decimal Balance { get; set; }
        /// <summary>
        /// User transactions
        /// </summary>
        public List<Transaction> UserTransactions { get; set; } = new List<Transaction>();
        /// <summary>
        /// Transactions Limit Per Day
        /// </summary>
        public byte TransactionsPerDay { get; set; } = 10;
    }
}
