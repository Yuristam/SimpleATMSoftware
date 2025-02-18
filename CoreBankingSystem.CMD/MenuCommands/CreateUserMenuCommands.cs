using CoreBankingSystem.BLL.Exceptions;
using CoreBankingSystem.BLL.Models;

namespace CoreBankingSystem.CMD.Menu
{
    public partial class CreateUserMenu
    {
        private static string _userInput;

        public static void CreateUser()
        {
            int id = 0;
            string fullName = EnterUserFullName();
            string login = EnterUserLogin();
            string password = EnterUserPassword();
            string confirmPassword = EnterUserPassword();

            User user = new User(id++, fullName, login, password, confirmPassword);            
        }

        public static string EnterUserFullName()
        {
            while (true)
            {
                Console.Clear();
                Console.Write("Please enter User's name: \n\n> ");

                _userInput = Console.ReadLine().Trim();

                if (string.IsNullOrWhiteSpace(_userInput))
                    InputExceptions.PrintNullOrWhiteSpaceExceptionMessage("name");

                else if (_userInput.Length < 1 || _userInput.Length > 30)
                    InputExceptions.PrintLengthExceptionMessage("name", 1, 30);

                else if (_userInput.All(char.IsLetter))
                    return _userInput;
                else
                    InputExceptions.PrintNotValidInputExceptionMessage("name", isLowercase: true, isUppercase: true);
            }
        }

        public static string EnterUserLogin()
        {
            while (true)
            {
                Console.Clear();
                Console.Write("Please enter User's login: \n\n> ");

                _userInput = Console.ReadLine().Trim();

                if (string.IsNullOrWhiteSpace(_userInput))
                    InputExceptions.PrintNullOrWhiteSpaceExceptionMessage("login");

                else if (_userInput.Length < 8 || _userInput.Length > 8)
                    InputExceptions.PrintLengthExceptionMessage("login", 8, 8);

                else if (_userInput.All(char.IsDigit))
                    return _userInput;
                
                else
                    InputExceptions.PrintNotValidInputExceptionMessage("login", true);
            }
        }

        public static string EnterUserPassword()
        {
            while (true)
            {
                Console.Clear();
                Console.Write("Please enter User's password: \n\n> ");

                _userInput = Console.ReadLine().Trim();

                if (string.IsNullOrWhiteSpace(_userInput))
                    InputExceptions.PrintNullOrWhiteSpaceExceptionMessage("password");

                else if (_userInput.Length < 8 || _userInput.Length > 30)
                    InputExceptions.PrintLengthExceptionMessage("password", 8, 30);

                else if (_userInput.Any(char.IsLetter)
                       && _userInput.Any(char.IsDigit)
                       && _userInput.Any(char.IsLower)
                       && _userInput.Any(char.IsUpper)
                       && _userInput.Any(char.IsSymbol)
                        | _userInput.Any(char.IsPunctuation))
                    return _userInput;

                else
                    InputExceptions.PrintNotValidInputExceptionMessage("password", true, true, true, true);
            }
        }
    }
}
