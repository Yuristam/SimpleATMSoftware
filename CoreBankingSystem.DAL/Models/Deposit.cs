namespace CoreBankingSystem.DAL.Models
{
    /// <summary>
    /// Deposit
    /// </summary>
    public class Deposit
    {
        /// <summary>
        /// Сумма Депозита
        /// </summary>
        public double DepositAmount { get; set; }

        /// <summary>
        /// Процентная ставка
        /// </summary>
        public double InterestRate { get; set; }
        
        /// <summary>
        /// Срок депозита в месяцах
        /// </summary>
        public int DepositTermMonths { get; set; }

        /// <summary>
        /// User Id
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// User Model
        /// </summary>
        public User User { get; set; }


        /// <summary>
        /// Конструктор для инициализации данных депозита
        /// </summary>
        /// <param name="depositAmount">Сумма Депозита</param>
        /// <param name="interestRate">Процентная ставка</param>
        /// <param name="depositTermMonths">Срок депозита в месяцах</param>
        /// <param name="userId">User ID</param>
        /// <param name="user">User</param>
        public Deposit(double depositAmount, double interestRate, int depositTermMonths, int userId, User user)
        {
            DepositAmount = depositAmount;
            InterestRate = interestRate;
            DepositTermMonths = depositTermMonths;
            UserId = userId;
            User = user;
        }

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
