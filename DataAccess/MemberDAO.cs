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
            try
            {
                string sqlQuerry = "Select MemberID, MemberName, Email, Password, City,Country " +
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
                        Email = dataReader.GetString(2),
                        Password = dataReader.GetString(3),
                        City = dataReader.GetString(4),
                        Country = dataReader.GetString(5),
                        MemberID = dataReader.GetInt32(0),
                        MemberName = dataReader.GetString(1)
                    };
                }
            
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return null;
        }
        public IList<MemberObject> Search(string searchValue)
        {
            var  resultList = new List<MemberObject>(); 
            try
            {
                DataSet ds = new DataSet();
                ds = GetData();
                var searchResults = ds.Tables["Members"].AsEnumerable()
                    .Where
                    (sr => sr.Field<string>("Email").Contains(searchValue.ToLower())
                    || sr.Field<string>("MemberName").Contains(searchValue.ToLower()));
                
                if (searchValue.Length > 0)
                {
                   foreach(var mem in searchResults)
                    {
                         resultList.Add(new MemberObject
                         {
                            MemberID = mem.Field<int>("MemberID"),
                            MemberName = mem.Field<string>("MemberName"),
                            Email = mem.Field<string>("Email"),
                            Password = mem.Field<string>("Password"),
                            City = mem.Field<string>("City"),
                            Country = mem.Field<string>("Country")
                         });
                        
                    }
                }

                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
            return resultList;
        }


    }
}