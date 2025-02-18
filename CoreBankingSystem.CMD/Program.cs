using CoreBankingSystem.CMD.Menu;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

internal class Program
{
    private static void Main(string[] args)
    {
        /*var config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build();
        var connectionString = config.GetConnectionString("DefaultConnection");
        //Console.WriteLine($"🔗 Строка подключения: {connectionString}");

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                connection.Open();
                Console.WriteLine("✅ Successfully connected to Database!");

                string query = "SELECT Id, FullName FROM Users";

                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"ID: {reader["ID"]}, Name: {reader["FullName"]}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Error: {ex.Message}");
            }
        }*/
        MainMenu.PrintMainMenu();
    }
}