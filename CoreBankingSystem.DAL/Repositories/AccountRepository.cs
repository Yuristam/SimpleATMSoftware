using CoreBankingSystem.DAL.Data;
using CoreBankingSystem.DAL.Interfaces;
using CoreBankingSystem.DAL.Models;
using Microsoft.Data.SqlClient;

namespace CoreBankingSystem.DAL.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly BankDbContext _dbContext;

        public AccountRepository()
        {
            _dbContext = new BankDbContext();
        }

        public async Task CreateAccountAsync(Account account)
        {
            using var connection = _dbContext.CreateConnection();
            await connection.OpenAsync();

            using var command = new SqlCommand("INSERT INTO Accounts (AccountNumber, Balance) VALUES (@AccountNumber, @Balance)", connection);
            command.Parameters.AddWithValue("@AccountNumber", account.AccountNumber);
            command.Parameters.AddWithValue("@Balance", account.Balance);

            await command.ExecuteNonQueryAsync();
        }

        public async Task DeleteAccountAsync(int id)
        {
            using var connection = _dbContext.CreateConnection();
            await connection.OpenAsync();

            using var command = new SqlCommand("DELETE FROM Accounts WHERE Id = @Id", connection);
            command.Parameters.AddWithValue("@Id", id);

            await command.ExecuteNonQueryAsync();
        }

        public async Task<Account?> GetAccountByIdAsync(int id)
        {
            using var connection = _dbContext.CreateConnection();
            await connection.OpenAsync();

            using var command = new SqlCommand("SELECT Id, AccountNumber, Balance FROM Accounts WHERE Id = @Id", connection);
            command.Parameters.AddWithValue("@Id", id);

            using var reader = await command.ExecuteReaderAsync();
            if (await reader.ReadAsync())
            {
                return new Account
                {
                    Id = reader.GetInt32(0),
                    AccountNumber = reader.GetString(1),
                    Balance = reader.GetDecimal(2)
                };
            }

            return null;
        }

        public async Task<ICollection<Account>> GetAllAccountsAsync()
        {
            var accounts = new List<Account>();
            using var connection = _dbContext.CreateConnection();
            await connection.OpenAsync();

            using var command = new SqlCommand("SELECT Id, AccountNumber, Balance FROM Accounts", connection);
            using var reader = await command.ExecuteReaderAsync();

            while (await reader.ReadAsync())
            {
                accounts.Add(new Account
                {
                    Id = reader.GetInt32(0),
                    AccountNumber = reader.GetString(1),
                    Balance = reader.GetDecimal(2)
                });
            }

            return accounts;
        }

        public async Task UpdateAccountAsync(Account account)
        {
            using var connection = _dbContext.CreateConnection();
            await connection.OpenAsync();

            using var command = new SqlCommand("UPDATE Accounts SET Balance = @Balance WHERE Id = @Id", connection);
            command.Parameters.AddWithValue("@Id", account.Id);
            command.Parameters.AddWithValue("@Balance", account.Balance);

            await command.ExecuteNonQueryAsync();
        }
    }
}
