using SimpleATMSoftware.Models;
using SimpleATMSoftware.Services;

namespace SimpleATMSoftware.Menu;

public class UserActionsMenu
{
    public static void PrintUserActionsMenu(User user, List<User> users)
    {
        UserService _service = new();
        DateTime currentDay = DateTime.Now;

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Enter what you want to do\n" +
                new string('=', Console.BufferWidth) +
                "1. Show My Balance\n" +
                "2. Withdraw Cash\n" +
                "3. Send Money\n" +
                "4. Show 5 previous transactions\n" +
                "5. Exit");

            // Let's pretend that we waited one day here, instead of 2 minutes :)
            if ((currentDay.Minute + 2) < DateTime.Now.Minute)
            {
                user.TransactionsPerDay = 10;
                currentDay = DateTime.Now;
            }

            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1": _service.ShowBalance(user); break;
                
                case "2":
                    
                    if (user.TransactionsPerDay == 0)
                    {
                        MenuHelper.CheckUserTransactionsLimit();
                        break;
                    }
                    else
                    {
                        _service.WithdrawCash(user);
                        break;
                    }

                case "3":
 
                    if (user.TransactionsPerDay == 0)
                    {
                        MenuHelper.CheckUserTransactionsLimit();
                        break;
                    }
                    else
                    {    
                        _service.SendMoney(user, users);
                        break;
                    }

                case "4": _service.ShowTransactions(user); break;

                case "5":
                    MenuHelper.Exit();
                    break;

                default: 
                    Console.WriteLine("There is no such command");
                    break;
            }
        }
    }
}