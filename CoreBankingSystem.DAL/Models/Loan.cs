namespace CoreBankingSystem.DAL.Models
{
    public class Loan
    {
        public double LoanAmount { get; set; } // Сумма кредита
        public double InterestRate { get; set; } // Процентная ставка
        public int LoanTermMonths { get; set; } // Срок кредита в месяцах

        public Loan(double loanAmount, double interestRate, int loanTermMonths)
        {
            LoanAmount = loanAmount;
            InterestRate = interestRate;
            LoanTermMonths = loanTermMonths;
        }

        // Метод для вычисления ежемесячного платежа по кредиту
        public double CalculateMonthlyPayment()
        {
            double monthlyInterestRate = InterestRate / 100 / 12;
            double monthlyPayment = LoanAmount * monthlyInterestRate /
                (1 - Math.Pow(1 + monthlyInterestRate, -LoanTermMonths));

            return monthlyPayment;
        }

        // Метод для вычисления общей суммы выплат по кредиту
        public double CalculateTotalRepayment()
        {
            return CalculateMonthlyPayment() * LoanTermMonths;
        }

        // Метод для вывода информации о кредите
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
