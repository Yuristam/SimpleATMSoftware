namespace CoreBankingSystem.DAL.Models
{
    /// <summary>
    /// Loan
    /// </summary>
    public class Loan
    {
        /// <summary>
        /// Сумма кредита
        /// </summary>
        public double LoanAmount { get; set; } 

        /// <summary>
        /// Процентная ставка
        /// </summary>
        public double InterestRate { get; set; } 

        /// <summary>
        /// Срок кредита в месяцах
        /// </summary>
        public int LoanTermMonths { get; set; }

        /// <summary>
        /// User Id
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// User Model
        /// </summary>
        public User User { get; set; }

        /// <summary>
        /// Конструктор для инициализации данных кредита
        /// </summary>
        /// <param name="loanAmount"></param>
        /// <param name="interestRate"></param>
        /// <param name="loanTermMonths"></param>
        /// <param name="userId">User ID</param>
        /// <param name="user">User</param>
        public Loan(double loanAmount, double interestRate, int loanTermMonths, int userId, User user)
        {
            LoanAmount = loanAmount;
            InterestRate = interestRate;
            LoanTermMonths = loanTermMonths;
            UserId = userId;
            User = user;
        }

        /// <summary>
        /// Метод для вычисления ежемесячного платежа по кредиту
        /// </summary>
        /// <returns>Ежемесячная выплата</returns>
        public double CalculateMonthlyPayment()
        {
            double monthlyInterestRate = InterestRate / 100 / 12;
            double monthlyPayment = LoanAmount * monthlyInterestRate /
                (1 - Math.Pow(1 + monthlyInterestRate, -LoanTermMonths));

            return monthlyPayment;
        }

        /// <summary>
        /// Метод для вычисления общей суммы выплат по кредиту
        /// </summary>
        /// <returns>Общая сумма выплаты</returns>
        public double CalculateTotalRepayment()
        {
            return CalculateMonthlyPayment() * LoanTermMonths;
        }

        /// <summary>
        /// Метод для вывода информации о кредите
        /// </summary>
        public void DisplayLoanDetails()
        {
            Console.WriteLine($"Loan Amount: {LoanAmount:C}");
            Console.WriteLine($"Interest Rate: {InterestRate}%");
            Console.WriteLine($"Loan Term: {LoanTermMonths} months");
            Console.WriteLine($"Monthly Payment: {CalculateMonthlyPayment():C}");
            Console.WriteLine($"Total Repayment: {CalculateTotalRepayment():C}");
        }
    }
}
