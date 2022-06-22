using BusinessObject;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class MemberDAO : BaseDAL
    {
        
        private static MemberDAO instance = null;
        private static readonly object instanceLock = new object();
        private MemberDAO() { }
        public static MemberDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null) instance = new MemberDAO();
                    return instance;
                }
            }
        }

       

        //Code Below Here !!!
        public MemberObject Login(string email, string password)
        {
            IDataReader dataReader=null;
            MemberObject member = null;
            try
            {
                string sqlQuerry = "Select MemberID, MemberName, Email, Password, City, Country " +
                "From Members " +
                "Where Email = @Email And PassWord = @Password ";
                var parameters = new List<SqlParameter>();
                parameters.Add(dataProvider.CreateParameter("@Email", 20, email, DbType.String));
                parameters.Add(dataProvider.CreateParameter("@Password",20, password,DbType.String));
                dataReader = dataProvider.GetDataReader(sqlQuerry, CommandType.Text,out connection, parameters.ToArray());
                if (dataReader.Read())
                {
                    member = new MemberObject
                    {
                        MemberID = dataReader.GetInt32(0),
                        MemberName = dataReader.GetString(1),
                        Email = dataReader.GetString(2),
                        Password = dataReader.GetString(3),
                        City = dataReader.GetString(4),
                        Country = dataReader.GetString(5)
                        
                    };
                }
            
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConenction();
            }
            return member;
        }
        public IList<MemberObject> Search(string searchValue)
        {
            IDataReader dataReader = null;
            var  resultList = new List<MemberObject>(); 
            try
            {
                string sqlQuerry = "Select MemberID, MemberName, Email, Password, City,Country " +
                "From Members " +
                "Where MemberName LIKE @memberName ";
                
                    var param = dataProvider.CreateParameter("@memberName",20,searchValue,DbType.String);
                    dataReader = dataProvider.GetDataReader(sqlQuerry, CommandType.Text, out connection, param);
                    while (dataReader.Read())
                    {
                        resultList.Add(new MemberObject
                        {
                            MemberID = dataReader.GetInt32(0),
                            MemberName = dataReader.GetString(1),
                            Email = dataReader.GetString(2),
                            Password = dataReader.GetString(3),
                            City = dataReader.GetString(4),
                            Country = dataReader.GetString(5)
                        });
                    } 
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConenction();
            }
            return resultList;
        }


    }
}