namespace CoreBankingSystem.BLL.Models
{
    public class Deposit
    {
        public double DepositAmount { get; set; }
        public double InterestRate { get; set; }
        public int DepositTermMonths { get; set; }

        public int ClientId { get; set; }
        public Client Client { get; set; }

        /// <summary>
        /// Метод для вычисления суммы по окончании срока депозита с начисленными процентами
        /// </summary>
        /// <returns>Общую сумму</returns>
        public double CalculateTotalAmount()
        {
            double totalAmount = DepositAmount * Math.Pow(1 + InterestRate / 100 / 12, DepositTermMonths);
            return totalAmount;
        }

        /// <summary>
        /// Метод для вывода информации о депозите
        /// </summary>
        public void DisplayDepositDetails()
        {
            Console.WriteLine($"Deposit Amount: {DepositAmount:C}");
            Console.WriteLine($"Interest Rate: {InterestRate}%");
            Console.WriteLine($"Deposit Term: {DepositTermMonths} months");
            Console.WriteLine($"Total Amount after Deposit Term: {CalculateTotalAmount():C}");
        }
    }
}
