using CoreBankingSystem.BLL.Services;
using CoreBankingSystem.CMD.Menu;
using CoreBankingSystem.DAL.Interfaces;
using CoreBankingSystem.DAL.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

internal class Program
{
    private static void Main(string[] args)
    {
        var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build();

        // Настраиваем DI
        var serviceProvider = new ServiceCollection()
        .AddSingleton<IConfiguration>(configuration)
            .AddSingleton<IAccountRepository, AccountRepository>()
            .AddSingleton<AccountServices>()
            .BuildServiceProvider();

        var accountService = serviceProvider.GetRequiredService<AccountServices>();


        MainMenu.PrintMainMenu();
    }
}