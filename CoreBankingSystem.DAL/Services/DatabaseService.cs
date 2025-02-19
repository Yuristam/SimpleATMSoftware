using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;

namespace CoreBankingSystem.DAL.Services
{
    public interface IDatabaseService
    {
        Task GetUsersAsync();
        Task AddUserAsync(string name);
    }

    public class DatabaseService : IDatabaseService
    {
        private readonly string _connectionString;
        private readonly ILogger<DatabaseService> _logger;

        public DatabaseService(string connectionString, ILogger<DatabaseService> logger)
        {
            _connectionString = connectionString;
            _logger = logger;
        }

        public async Task GetUsersAsync()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    await connection.OpenAsync();
                    _logger.LogInformation("✅ Successfully connected to Database");

                    string query = "SELECT Id, FullName FROM Users";

                    using (SqlCommand command = new SqlCommand(query, connection))

                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            Console.WriteLine($"ID: {reader["Id"]}, Name: {reader["Name"]}");
                        }
                    }
                }
                catch (SqlException ex)
                {
                    _logger.LogError($"❌ Error SQL: {ex.Message}");
                }
                catch (Exception ex)
                {
                    _logger.LogError($"❌ Application error: {ex.Message}");
                }
            }
        }

        public async Task AddUserAsync(string name)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    await connection.OpenAsync();

                    string query = "INSERT INTO Users (FullName) VALUES (@name)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@name", name);
                        int rowsAffected = await command.ExecuteNonQueryAsync();
                        _logger.LogInformation($"✅ Added values: {rowsAffected}");
                    }
                }
                catch(SqlException ex) {
                    _logger.LogError($"❌ Error SQL: {ex.Message}");
                }
                catch (Exception ex)
                {
                    _logger.LogError($"❌ Application error: {ex.Message}");
                }
            }
        }
    }
}
