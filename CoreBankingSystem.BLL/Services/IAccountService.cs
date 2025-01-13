using CoreBankingSystem.BLL.Models;

namespace CoreBankingSystem.BLL.Services
{
    public interface IAccountService
    {
        Task<Account> CreateAccountForClientAsync(Account account);
        decimal DepositToAccount(decimal money);
        decimal WithdrawFromAccount(decimal money);
        void CloseClientAccount(long accountNumber);
        void GetBalanceWithTransactions(long accountNumber);
    }
}
