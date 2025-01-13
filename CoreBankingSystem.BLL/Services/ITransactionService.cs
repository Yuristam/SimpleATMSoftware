using CoreBankingSystem.BLL.Models;

namespace CoreBankingSystem.BLL.Services
{
    public interface ITransactionService
    {
        Task<ICollection<Transaction>> GetTransactionsHistoryByAccountAsync();
        Task<Transaction> GetTransactionDetails(int transaction);
        void CommitTransferBetweenAccounts(long receiverAccount, long senderAccount);
    }
}
