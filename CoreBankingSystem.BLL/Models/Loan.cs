namespace CoreBankingSystem.BLL.Models
{
    public class Loan
    {
        public int Id { get; set; }
        public double LoanAmount { get; set; } 
        public double InterestRate { get; set; } 
        public int LoanTermMonths { get; set; }

        public Guid ClientId { get; set; }
        public Client Client { get; set; }

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
