using SimpleATMSoftware.Models;

namespace SimpleATMSoftware.Menu;

public class MainMenu
{
    private static int _userLogin = 0;
    private static int _userPinCode = 0;

    public static void PrintMainMenu()
    {

        #region Users
        var user1 = new User()
        {
            Id = 1,
            FirstName = "Eren",
            LastName = "Jeager",
            Account = 1234567887654321,
            Login = 888888,
            PIN = 1234,
            Password = "P@ssw0rd",
            Balance = 120000M
        };

        var user2 = new User()
        {
            Id = 2,
            FirstName = "Armin",
            LastName = "Arlert",
            Account = 1111_1111_1111_1111,
            Login = 666666,
            PIN = 1111,
            Password = "P@ssw0rd",
            Balance = 10000M
        };
        var user3 = new User()
        {
            Id = 3,
            FirstName = "Mikasa",
            LastName = "Ackerman",
            Account = 2222567887654321,
            Login = 111111,
            PIN = 2222,
            Password = "P@ssw0rd",
            Balance = 0
        };
        var user4 = new User()
        {
            Id = 4,
            FirstName = "Levi",
            LastName = "Ackerman",
            Account = 2221_5678_8765_4321,
            Login = 222222,
            PIN = 2223,
            Password = "P@ssw0rd",
            Balance = 200
        };
        var users = new List<User>
            {
                user1,
                user2,
                user3,
                user4
            };

        #endregion

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Hello user, enter your credentials to log in.");
            Console.WriteLine(new string('=', Console.BufferWidth));
            Console.Write("Enter your login (6-digit number): ");

            MenuHelper.CheckUserInputForDigits(ref _userLogin, 6);
            
            var user = users.FirstOrDefault(u => u.Login == _userLogin);

            if (user != null)
            {
                Console.WriteLine("Enter your PIN: ");

                MenuHelper.CheckUserInputForDigits(ref _userPinCode, 4);

                if (user.PIN == Convert.ToInt32(_userPinCode))
                {
                    UserActionsMenu.PrintUserActionsMenu(user, users);
                }
                else
                {
                    Console.WriteLine("You entered wrong PIN.");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine($"User with login {_userLogin} not found.");
                Console.ReadKey();
            }
        }
    }
}