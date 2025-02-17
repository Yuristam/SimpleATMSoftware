namespace CoreBankingSystem.CMD.Menu
{
    public static class MainMenu
    {
        /*public static void EnterSystem()
        {
            // TODO: dependency injection
            User user = new User(1, "My Name", "12345678", "P@ssword1", "P@ssword1");

            while (true)
            {
                string currentUserLogin = UserValidations.InputUserLogin();
                string currentUserPassword = UserValidations.InputUserPassword();

                if (user.Login != currentUserLogin && user.Password != currentUserPassword)
                {
                    Console.WriteLine("You entered wrong login or wrong password.");
                    Task.Delay(1500).Wait();
                }
                else
                {
                    PrintMainMenu(user);
                }
            }
        }*/

        public static void PrintMainMenu()
        {
            string userInput;

            while (true)
            {
                Console.Clear();
                MenuHelper.GreetingUser();
                Console.WriteLine(
                    "1. Find User \n" +
                    "2. Create User \n" +
                    "3. Open bank operations \n" +
                    "4. Open Accounts menu \n" +
                    "5. Open Loans Menu \n" +
                    "6. Open Deposits Menu \n" +
                    "7. Exit \n");

                userInput = Console.ReadLine().ToLower().Trim();

                switch (userInput)
                {
                    case "1": FindUserMenu.PrintFindUserMenu(); break;
                    case "2": CreateUserMenu.PrintCreateUserMenu(); break;
                    case "3": OpenBankOperationsMenu.PrintOpenBankOperationsMenu(); break;
                    case "4": OpenAccountsMenu.PrintOpenAccountsMenu(); break;
                    case "5": OpenLoansMenu.PrintOpenLoansMenu(); break;
                    case "6": OpenDepositsMenu.PrintOpenDepositsMenu(); break;
                    case "7": Environment.Exit(0); break;
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
