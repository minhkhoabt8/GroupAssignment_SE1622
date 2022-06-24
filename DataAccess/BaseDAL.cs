
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class BaseDAL
    {
        public MemberDataProvider dataProvider { get; set; } = null;
        public SqlConnection connection = null;
        DataSet dataset { get; set; } = null;
        public BaseDAL()
        {
            var connectionString = GetConnectionString();
            dataProvider = new MemberDataProvider(connectionString);
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
        public void CloseConenction() => dataProvider.CloseConnection(connection);
        public DataSet GetData()
        {

            try
            {
                connection.ConnectionString = GetConnectionString();
                SqlDataAdapter sda = new SqlDataAdapter("Select MemberID, MemberName, Email, Password, City, Country "
                                                        + "From Members ", connection);
                if (sda != null)
                {
                    sda.Fill(dataset, "Members");

                    return dataset;
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("SQL exception occurred: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return null;
        }

    }
}
