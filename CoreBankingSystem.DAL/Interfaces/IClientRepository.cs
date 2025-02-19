using CoreBankingSystem.DAL.Models;

namespace CoreBankingSystem.DAL.Interfaces
{
    public interface IClientRepository
    {
        Task<Client> GetClientByIdAsync(int id);
        Task<ICollection<Client>> GetAllClientsAsync();

        Task CreateClientAsync(Client client);
        Task UpdateClientAsync(Client client);
        Task DeleteClientAsync(int id);
    }
}
