namespace CoreBankingSystem.CMD.Menu
{
    public partial class FindUserMenu
    {
        public static void PrintFindUserMenu()
        {
            string userInput;

            while (true)
            {
                Console.Clear();
                Console.WriteLine(
                    "1. Search by Name \n" +
                    "2. Search by ID \n" +
                    "3. Search by Phone number \n" +
                    "4. Search by Address \n" +
                    "5. Search by Loan \n" +
                    "6. Search by Deposit \n" +
                    "7. back \n");

                userInput = Console.ReadLine().ToLower().Trim();

                switch (userInput)
                {
                    case "1": GetUsersByName(); break;
                    case "2": GetUsersByID(); break;
                    case "3": GetUsersByPhoneNumber(); break;
                    case "4": GetUsersByAddress(); break;
                    case "5": GetUsersByLoan(); break;
                    case "6": GetUsersByDeposit(); break;
                    case "7": MainMenu.PrintMainMenu(); break;
                    default:
                        Console.Clear();
                        Console.WriteLine("There is no such command, please enter right command.");
                        Task.Delay(1000);
                        break;
                }
            }
        }
    }
}
