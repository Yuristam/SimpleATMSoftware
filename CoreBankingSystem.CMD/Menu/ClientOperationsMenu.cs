namespace CoreBankingSystem.CMD.Menu
{
    public partial class ClientOperationsMenu
    {
        public static void PrintClientOperationsMenu()
        {
            string userInput;

            while (true)
            {
                Console.Clear();
                Console.WriteLine(
                    "1. Create Client\n" +
                    "2. Edit Client \n" +
                    "3. Delete Client\n" +
                    "5. Get Client\n" +
                    "4. back \n");

                userInput = Console.ReadLine().ToLower().Trim();

                switch (userInput)
                {
                    case "1": CreateUser(); break;
                    case "5": GetUser(); break;
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
