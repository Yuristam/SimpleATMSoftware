using CoreBankingSystem.BLL.Models;

namespace CoreBankingSystem.DAL.Interfaces
{
    public interface ITransactionRepository
    {
        Task<ICollection<Transaction>> GetTransactionsHistoryByAccountAsync();
        Task<Transaction> GetTransactionDetails(int transaction);
        void CommitTransferBetweenAccounts(long receiverAccount, long senderAccount);
    }
}
