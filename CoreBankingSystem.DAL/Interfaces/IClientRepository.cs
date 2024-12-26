using CoreBankingSystem.BLL.Models;

namespace CoreBankingSystem.DAL.Interfaces
{
    public interface IClientRepository
    {
        Task<ICollection<Client>> GetClientsAsync();
        Task<Client> GetClientById(Guid id);
        Task<Client> GetClientByName(string name);

        Task<Client> CreateClientAsync(Client client);
        Task<Client> UpdateClientAsync(Client client);
        Task DeleteClientAsync(Client client);
    }
}
