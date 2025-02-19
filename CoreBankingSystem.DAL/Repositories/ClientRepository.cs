using CoreBankingSystem.DAL.Interfaces;
using CoreBankingSystem.DAL.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace CoreBankingSystem.DAL.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private readonly string _connectionString;

        public ClientRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection")!;
        }

        public async Task CreateClientAsync(Client client)
        {
            using var connection = new SqlConnection(_connectionString);
            await connection.OpenAsync();

            using var command = new SqlCommand("INSERT INTO Clients", connection);
        }

        public Task DeleteClientAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Client>> GetAllClientsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Client> GetClientByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateClientAsync(Client client)
        {
            throw new NotImplementedException();
        }
    }
}
