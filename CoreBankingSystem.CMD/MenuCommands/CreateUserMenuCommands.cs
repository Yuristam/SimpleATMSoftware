using CoreBankingSystem.CMD.Exceptions;
using Microsoft.Data.SqlClient;
using System.Data;

namespace CoreBankingSystem.CMD.Menu
{
    public partial class CreateUserMenu
    {
        private static string _userInput;

        public static void CreateUser()
        {
            var connectionString = "my connection string";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string fullName = EnterUserFullName();

                connection.Open();

                string insertQuery = "INSERT INTO Users (FullName, Login, Password, ConfirmPassword) VALUES (@name, @name, @name, @name)";
                using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@name", fullName);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    Console.WriteLine($"Added values: {rowsAffected}");
                }
                Console.ReadKey();
            }

            /*int id = 0;
            string login = EnterUserLogin();
            string password = EnterUserPassword();
            string confirmPassword = EnterUserPassword();

            User user = new User(id++, fullName, login, password, confirmPassword); */           
        }

        public static void GetUser()
        {
            var connection = "my connection string";

            DataTable table = new DataTable();
            using(SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Users", connection))
            {
                adapter.Fill(table);
            }
            foreach (DataRow row in table.Rows)
            {
                Console.WriteLine($"ID: {row["Id"]}, Name: {row["FullName"]}");
            }
            Console.ReadKey();
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
