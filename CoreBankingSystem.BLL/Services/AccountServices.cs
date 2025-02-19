using CoreBankingSystem.DAL.Models;
using CoreBankingSystem.DAL.Repositories;

namespace CoreBankingSystem.BLL.Services
{
    public class AccountServices
    {
        private readonly AccountRepository _repository;

        public AccountServices()
        {
            _repository = new AccountRepository();
        }

        public async Task<ICollection<Account>> GetAllAccountsAsync() => await _repository.GetAllAccountsAsync();
        public async Task<Account?> GetAccountByIdAsync(int id) => await _repository.GetAccountByIdAsync(id);
        public async Task AddAccountAsync(Account account) => await _repository.CreateAccountAsync(account);
        public async Task UpdateAccountAsync(Account account) => await _repository.UpdateAccountAsync(account);
        public async Task DeleteAccountAsync(int id) => await _repository.DeleteAccountAsync(id);
    }
}
