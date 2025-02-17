namespace CoreBankingSystem.CMD.Menu
{
    public partial class CreateUserMenu
    {
        public static void PrintCreateUserMenu()
        {
            string userInput;

            while (true)
            {
                Console.Clear();
                Console.WriteLine(
                    "1. Create Client\n" +
                    "2. Edit Client \n" +
                    "3. Delete Client\n" +
                    "4. back \n");

                userInput = Console.ReadLine().ToLower().Trim();

                switch (userInput)
                {
                    case "1": CreateUser(); break;
                   // case "2": GetUsersByID(); break;
                    //case "3": GetUsersByPhoneNumber(); break;
                    case "4": MainMenu.PrintMainMenu(); break;
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
