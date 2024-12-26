using CoreBankingSystem.BLL.Models;

namespace CoreBankingSystem.DAL.Interfaces
{
    public interface IAccountRepository
    {
        Task<Account> GetAccountByAccountNumberAsync(long accountNumber);
        Task<ICollection<Account>> GetAccountsAsync();

        Task<Account> CreateAccountForClientAsync(Account account);
        decimal DepositToAccount(decimal money);
        decimal WithdrawFromAccount(decimal money);
        void CloseClientAccount(long accountNumber);
        void GetBalanceWithTransactions(long accountNumber);
    }
}
