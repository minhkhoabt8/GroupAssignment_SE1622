
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

namespace DataAccess
{
    public class BaseDAL
    {
        public MemberDataProvider dataProvider { get; set; } = null;
        public SqlConnection connection = null; 
        public BaseDAL()
        {
            var connectionString = GetConnectionString();
            dataProvider = new MemberDataProvider(connectionString);
        }

        private string GetConnectionString()
        {
            string connectionString;
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();
            connectionString = config["ConnectionStrings:MemberDB"];
            return connectionString;
        }
        public void CloseConnection() => dataProvider.CloseConnection(connection);
       
    }
}
