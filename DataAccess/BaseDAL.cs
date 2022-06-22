
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

namespace DataAccess
{
    public class BaseDAL
    {
        public MemberDataProvider dataprovider { get; set; } = null;
        public SqlConnection connection = null;
        public BaseDAL()
        {
            var connectionString = GetConnectionString();
            dataprovider = new MemberDataProvider(connectionString);
        }

        public static IConfiguration Configuration;

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
        public void CloseConenction() => dataprovider.CloseConnection(connection);


    }
}
