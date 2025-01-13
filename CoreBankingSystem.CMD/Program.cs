using CoreBankingSystem.BLL.Models;
using CoreBankingSystem.BLL.Validations;
using CoreBankingSystem.CMD.Menu;

internal class Program
{
    private static void Main(string[] args)
    {
        User user = new User();
        
        UserValidations.InputUserLogin(user.Login.ToString());
        UserValidations.InputUserPassword(user.Password);

        MainMenu.PrintMainMenu(user);
    }
}