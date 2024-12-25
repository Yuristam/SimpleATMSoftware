namespace CoreBankingSystem.DAL.Models
{
    public class Deposit
    {
        public double DepositAmount { get; set; } // Сумма депозита
        public double InterestRate { get; set; } // Процентная ставка
        public int DepositTermMonths { get; set; } // Срок депозита в месяцах

        // Конструктор для инициализации данных депозита
        public Deposit(double depositAmount, double interestRate, int depositTermMonths)
        {
            DepositAmount = depositAmount;
            InterestRate = interestRate;
            DepositTermMonths = depositTermMonths;
        }

        // Метод для вычисления суммы по окончании срока депозита с начисленными процентами
        public double CalculateTotalAmount()
        {
            double totalAmount = DepositAmount * Math.Pow(1 + InterestRate / 100 / 12, DepositTermMonths);
            return totalAmount;
        }

        // Метод для вывода информации о депозите
        public void DisplayDepositDetails()
        {
            Console.WriteLine($"Deposit Amount: {DepositAmount:C}");
            Console.WriteLine($"Interest Rate: {InterestRate}%");
            Console.WriteLine($"Deposit Term: {DepositTermMonths} months");
            Console.WriteLine($"Total Amount after Deposit Term: {CalculateTotalAmount():C}");
        }
    }
}
