namespace CoreBankingSystem.DAL.Models
{
    public class Loan
    {
        public int Id { get; set; }
        public string LoanType { get; set; }
        public decimal Amount { get; set; }
        public decimal InterestRate { get; set; }
        public byte LoanTermMonths { get; set; }

        public int ClientId { get; set; }
        public Client Client { get; set; }

        /// <summary>
        /// Метод для вычисления ежемесячного платежа по кредиту
        /// </summary>
        /// <returns>Ежемесячная выплата</returns>
        public decimal CalculateMonthlyPayment()
        {
            if (LoanTermMonths <= 0)
                throw new ArgumentException("Loan term must be greater than zero.");

            if (InterestRate == 0)
                return Amount / LoanTermMonths; // Без процентов — простой дележ

            decimal monthlyInterestRate = InterestRate / 100 / 12;
            decimal denominator = 1 - (decimal)Math.Pow((double)(1 + monthlyInterestRate), -LoanTermMonths);

            if (denominator == 0)
                throw new DivideByZeroException("Invalid calculation. Check input values.");

            return Amount * monthlyInterestRate / denominator;
        }

        /// <summary>
        /// Метод для вычисления общей суммы выплат по кредиту
        /// </summary>
        /// <returns>Общая сумма выплаты</returns>
        public decimal CalculateTotalRepayment()
        {
            return CalculateMonthlyPayment() * LoanTermMonths;
        }

        /// <summary>
        /// Метод для вывода информации о кредите
        /// </summary>
        public void DisplayLoanDetails()
        {
            Console.WriteLine($"Loan Amount: {Amount:C}");
            Console.WriteLine($"Interest Rate: {InterestRate}%");
            Console.WriteLine($"Loan Term: {LoanTermMonths} months");
            Console.WriteLine($"Monthly Payment: {CalculateMonthlyPayment():C}");
            Console.WriteLine($"Total Repayment: {CalculateTotalRepayment():C}");
        }
    }
}
