using SimpleATMSoftware.Models;

namespace SimpleATMSoftware.Interfaces;

public interface ITransactionService
{
    void CommitTransaction(User sender, User receiver,ref decimal sum);
}