using CoreBankingSystem.BLL.Exceptions;

namespace CoreBankingSystem.BLL.Validations
{
    public class UserValidations
    {
        private static string _userInput;

        public static string InputUserLogin()
        {
            while (true)
            {
                Console.Clear();
                Console.Write("Please enter your Login: \n> ");

                _userInput = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(_userInput))
                    InputExceptions.PrintNullOrWhiteSpaceExceptionMessage("login");

                else if (_userInput.Length != 8)
                    InputExceptions.PrintLengthExceptionMessage("login", 8, 8);

                else if (_userInput.All(char.IsDigit))
                      return _userInput;

                else
                    InputExceptions.PrintNotValidInputExceptionMessage("login", true);
            }
        }

        public static string InputUserPassword()
        {
            while (true)
            {
                Console.Clear();
                Console.Write("Please enter your Password: \n> ");

                _userInput = Console.ReadLine();

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
