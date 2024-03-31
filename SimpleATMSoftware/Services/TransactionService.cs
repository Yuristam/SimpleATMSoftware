using SimpleATMSoftware.Interfaces;
using SimpleATMSoftware.Models;

namespace SimpleATMSoftware.Services
{
    public class TransactionService : ITransactionService
    {
        public void CommitTransaction(User sender, User receiver,ref decimal sum)
        {
            if (sender.Balance >= sum)
            {
                Transaction transaction = new Transaction();
                sender.Balance -= sum;
                receiver.Balance += sum;
                transaction.TransactionDate = DateTime.Now;
                transaction.Sum = sum;

                Console.WriteLine($"Transaction succeeded. You send {transaction.Sum} $ to user: {receiver.Account}.");
                Console.WriteLine($"{sender.Balance} $ left in your balance.");
                Console.ReadKey();

                sender.TransactionsPerDay--;
                sender.UserTransactions.Add(transaction);
            }
            else
            {
                Console.WriteLine("Sorry, you don't have enough money on your balance.");
                Console.ReadKey();
            }
        }
    }
}
