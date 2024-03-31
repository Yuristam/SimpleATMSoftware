using SimpleATMSoftware.Interfaces;
using SimpleATMSoftware.Menu;
using SimpleATMSoftware.Models;

namespace SimpleATMSoftware.Services;
public class UserService : IUserService
{
    private static long _userInput = 0;
    private static decimal _inputSum = 0;

    public void SendMoney(User sender, List<User> users)
    {
        TransactionService _transactionService = new();

        Console.Write("Enter Account: ");

        MenuHelper.CheckUserInputForDigits(ref _userInput, 16);

        var receiver = users.FirstOrDefault(u => u.Account == _userInput);

        if (receiver == sender)
        {
            Console.WriteLine("You can't send money to yourself.");
            Console.ReadKey();
        }
        else if (receiver != null)
        {
            Console.Write("Enter Sum to send: ");

            MenuHelper.CheckUserInputForDigits(ref _inputSum);

            if (_inputSum > 0 && sender.Balance >= _inputSum)
            {
                if (_inputSum > 1000)
                {
                    Console.WriteLine("Sorry, you can't send more than 1000 $ in one transaction.");
                    Console.ReadKey();
                }
                else
                {
                    _transactionService.CommitTransaction(sender, receiver, ref _inputSum);
                }
            }
            else if (_inputSum < 0)
            {
                Console.WriteLine("Sorry, you can't send lower than 1 $.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Sorry, you don't have enough money on your balance.");
                Console.ReadKey();
            }
        }
        else
        {
            Console.WriteLine("There is no such user!");
            Console.ReadKey();
        }
    }

    public void ShowBalance(User user)
    {
        Console.WriteLine($"You have {user.Balance} $ on your balance.");
        Console.ReadKey();
    }

    public void ShowTransactions(User user)
    {
        if (user.UserTransactions.Count == 0)
        {
            Console.WriteLine("There is no transactions yet.");
        }
        else
        {
            if (user.UserTransactions.Count >= 5)
            {
                for (int i = user.UserTransactions.Count - 5; i < user.UserTransactions.Count; i++)
                {
                    Console.WriteLine($"Transaction {i + 1}: Sum: {user.UserTransactions[i].Sum} Date: {user.UserTransactions[i].TransactionDate}");
                }
            }
            else
            {
                for (int i = 0; i < user.UserTransactions.Count; i++)
                {
                    Console.WriteLine($"Transaction {i + 1}: Sum: {user.UserTransactions[i].Sum} Date: {user.UserTransactions[i].TransactionDate}");
                }
            }
        }

        Console.ReadKey();
    }

    public void WithdrawCash(User user)
    {
        Console.WriteLine("Enter how much money you want to withdraw:");
        MenuHelper.CheckUserInputForDigits(ref _inputSum);

        if (_inputSum > 1000)
        {
            Console.WriteLine("Sorry, you can't withdraw more than 1000$");
            Console.ReadKey();
        }
        else if (_inputSum > 0 && user.Balance >= _inputSum)
        {
            Transaction transaction = new Transaction();

            user.Balance -= _inputSum;
            transaction.TransactionDate = DateTime.Now;
            transaction.Sum = _inputSum;

            user.TransactionsPerDay--;
            user.UserTransactions.Add(transaction);

            Console.WriteLine($"You withdrew {_inputSum}$ from your balance");
            Console.WriteLine($"{user.Balance}$ left in your balance");
            Console.ReadKey();
        }
        else if (_inputSum > 0 && user.Balance < _inputSum)
        {
            Console.WriteLine("Sorry, you don't have enough money on your balance");
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine("You can't withdraw less than 1$");
            Console.ReadKey();
        }
    }
}