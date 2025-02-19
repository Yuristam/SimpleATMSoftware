using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace CoreBankingSystem.DAL.Data
{
    public class BankDbContext : IDisposable
    {
        private readonly string _connectionString;

        public BankDbContext()
        {
            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            _connectionString = config.GetConnectionString("DefaultConnection");
        }

        public SqlConnection CreateConnection()
        {
            return new SqlConnection( _connectionString );
        }

        public void Dispose() { }
    }
}
