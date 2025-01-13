using CoreBankingSystem.BLL.Exceptions;

namespace CoreBankingSystem.BLL.Validations
{
    public class UserValidations
    {
        public static string InputUserLogin(string login)
        {
            while (true)
            {
                Console.Clear();
                Console.Write("Please enter your Login: \n> ");

                login = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(login))
                    InputExceptions.PrintNullOrWhiteSpaceExceptionMessage(login);

                else if (login.Length != 8)
                    InputExceptions.PrintLengthExceptionMessage(login, 8, 8);

                else if (login.All(char.IsDigit))
                      return login;

                else
                    InputExceptions.PrintNotValidInputExceptionMessage(login, true);
            }
        }

        public static string InputUserPassword(string password)
        {
            while (true)
            {
                Console.Clear();
                Console.Write("Please enter your Password: \n> ");

                password = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(password))
                    InputExceptions.PrintNullOrWhiteSpaceExceptionMessage(password);

                else if (password.Length < 8 || password.Length > 30)
                    InputExceptions.PrintLengthExceptionMessage(password, 8, 30);

                else if (password.Any(char.IsLetter)
                      && password.Any(char.IsDigit)
                      && password.Any(char.IsLower)
                      && password.Any(char.IsUpper)
                      && password.Any(char.IsSymbol)
                       | password.Any(char.IsPunctuation))
                    return password;

                else
                    InputExceptions.PrintNotValidInputExceptionMessage(password, true, true, true, true);
            }
        }
    }
}
