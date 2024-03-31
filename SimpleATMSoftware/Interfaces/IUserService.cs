using SimpleATMSoftware.Models;

namespace SimpleATMSoftware.Interfaces;

public interface IUserService
{
    void SendMoney(User sender, List<User> users);
    void ShowBalance(User user);
    void ShowTransactions(User user);
    void WithdrawCash(User user);
}
