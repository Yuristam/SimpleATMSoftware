namespace CoreBankingSystem.DAL.Models
{
    public class Deposit
    {
        public int Id { get; set; }
        public string DepositType { get; set; }
        public decimal Amount { get; set; }
        public decimal InterestRate { get; set; }
        public byte DepositTermMonths { get; set; }

        public int ClientId { get; set; }
        public Client Client { get; set; }

        /// <summary>
        /// Метод для вычисления суммы по окончании срока депозита с начисленными процентами
        /// </summary>
        /// <returns>Общую сумму</returns>
        public decimal CalculateTotalAmount()
        {
            if (DepositTermMonths <= 0)
                throw new ArgumentException("Deposit term must be greater than zero.");

            if (InterestRate == 0)
                return Amount; // Без процентов просто возвращаем изначальную сумму

            decimal monthlyInterestRate = InterestRate / 100 / 12;
            decimal totalAmount = Amount * (decimal)Math.Pow((double)(1 + monthlyInterestRate), DepositTermMonths);

            return totalAmount;
        }

        /// <summary>
        /// Метод для вывода информации о депозите
        /// </summary>
        public void DisplayDepositDetails()
        {
            Console.WriteLine($"Deposit Amount: {Amount:C}");
            Console.WriteLine($"Interest Rate: {InterestRate}%");
            Console.WriteLine($"Deposit Term: {DepositTermMonths} months");
            Console.WriteLine($"Total Amount after Deposit Term: {CalculateTotalAmount():C}");
        }
    }
}
