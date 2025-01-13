using CoreBankingSystem.BLL.Models;

namespace CoreBankingSystem.CMD.Menu
{
    public static class MainMenu
    {
        public static void PrintMainMenu(User user)
        {
            MenuHelper.GreetingUser(user.FullName);
            Console.WriteLine("");
        }
    }
}
