using CoreBankingSystem.DAL.Models;

namespace CoreBankingSystem.DAL.Interfaces
{
    public interface IAccountRepository
    {
        Task<Account?> GetAccountByIdAsync(int id);
        Task<ICollection<Account>> GetAllAccountsAsync();

        Task CreateAccountAsync(Account account);
        Task UpdateAccountAsync(Account account);
        Task DeleteAccountAsync(int id);
    }
}
