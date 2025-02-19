using CoreBankingSystem.DAL.Models;

namespace CoreBankingSystem.BLL.Services
{
    public class ClientService : IClientService
    {
        public Task<Client> CreateClientAsync(Client client)
        {

        }

        public Task DeleteClientAsync(Client client)
        {
            throw new NotImplementedException();
        }

        public Task<Client> GetClientById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Client> GetClientByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Client>> GetClientsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Client> UpdateClientAsync(Client client)
        {
            throw new NotImplementedException();
        }
    }
}
