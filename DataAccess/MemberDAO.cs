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

       
        public IList<MemberObject> GetMember()
        {
            IDataReader dataReader = null;
           
            var memberList = new List<MemberObject>();
            string SQLSelect = "Select MemberID, MemberName, Email, Password, City, Country " +
                "from Members";
            try
            {
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection);
                while (dataReader.Read())
                {
                    memberList.Add(new MemberObject
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
                CloseConnection();
            }
            return memberList;
        }
        //Code Below Here !!!
        public MemberObject Login(string email, string password)
        {
            IDataReader dataReader = null;
            MemberObject member = null;
            try
            {
                string sqlQuerry = "Select MemberID, MemberName, Email, Password, City,Country " +
                "From Members " +
                "Where Email = @Email And PassWord = @Password ";
                var parameters = new List<SqlParameter>();
                parameters.Add(dataProvider.CreateParameter("@Email", 20, email, DbType.String));
                parameters.Add(dataProvider.CreateParameter("@Password", 20, password, DbType.String));
                dataReader = dataProvider.GetDataReader(sqlQuerry, CommandType.Text, out connection, parameters.ToArray());
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
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return member;
        }
        public IList<MemberObject> Search(string searchValue)
        {
            try
            {
                IDataReader dataReader = null;
                var resultList = new List<MemberObject>();
                try
                {
                    string sqlQuerry = "Select MemberID, MemberName, Email, Password, City,Country " +
                    "From Members " +
                    "Where MemberName LIKE @memberName ";

                    var param = dataProvider.CreateParameter("@memberName", 20, searchValue, DbType.String);
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
                    CloseConnection();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
            return null;
        }
        public void Update(MemberObject member)
        {
            try
            {
                MemberObject m = GetMemberByID(member.MemberID);
                if (m != null)
                {
                    string SQLUpdate = "Update Members set MemberName =@MemberName, Email =@Email,Password=@Password,City=@City,Country=@Country";
                    var param = new List<SqlParameter>();
                    param.Add(dataProvider.CreateParameter("@MemberID", 4, member.MemberID, DbType.Int32));
                    param.Add(dataProvider.CreateParameter("@Email", 4, member.Email, DbType.String));
                    param.Add(dataProvider.CreateParameter("@Password", 4, member.Password, DbType.String));
                    param.Add(dataProvider.CreateParameter("@City", 4, member.City, DbType.String));
                    param.Add(dataProvider.CreateParameter("@Country", 4, member.Country, DbType.String));
                    dataProvider.Update(SQLUpdate, CommandType.Text, param.ToArray());


                }
                else
                {
                    throw new Exception("The member does not already exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConenction();
            }
        }
        public IList<MemberObject> GetMemberSortByMemberName()
        {
            IDataReader dataReader = null;
            var resultList = new List<MemberObject>();
            string SQLSelect = "Select MemberID, MemberName, Email, Password, City, Country " +
                "from Members order by MemberName";
            try
            {
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection);
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