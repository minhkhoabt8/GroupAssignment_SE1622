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
                CloseConnection();
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
                
                    var param = dataProvider.CreateParameter("@memberName",20,searchValue.ToLower(),DbType.String);
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
            return resultList;
        }

        public IList<MemberObject> GetMember()
        {
            IDataReader dataReader = null;
            var resultList = new List<MemberObject>();
            string SQLSelect = "Select MemberID, MemberName, Email, Password, City, Country " +
                "from Members ";
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
                CloseConnection();
            }
            return resultList;
        }

        public void Update(MemberObject member)
        {
            try
            {
                var members = GetMemberByID(member.MemberID);
                if (members != null)
                {
                    string SQLUpdate = "Update Members "
                        + "set MemberName = @MemberName, Email = @Email, Password = @Password, City = @City, Country = @Country "
                        + "where MemberID = @MemberID ";
                    var param = new List<SqlParameter>();
                    param.Add(dataProvider.CreateParameter("@MemberID", 20, member.MemberID, DbType.Int32));
                    param.Add(dataProvider.CreateParameter("@MemberName", 20, member.MemberName, DbType.String));
                    param.Add(dataProvider.CreateParameter("@Email", 20, member.Email, DbType.String));
                    param.Add(dataProvider.CreateParameter("@Password", 20, member.Password, DbType.String));
                    param.Add(dataProvider.CreateParameter("@City", 20, member.City, DbType.String));
                    param.Add(dataProvider.CreateParameter("@Country", 20, member.Country, DbType.String));
                    dataProvider.Update(SQLUpdate, CommandType.Text, param.ToArray());

                }
                else
                {
                    throw new Exception("The member does not exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }


        public MemberObject GetMemberByID(int memberID)
        {
            MemberObject member = null;
            IDataReader dataReader = null;
            string SQLSelect = "Select MemberID, MemberName, Email, Password, City, Country " +
                "from Members where MemberID = @MemberID";
            try
            {
                var param = dataProvider.CreateParameter("@MemberID", 20, memberID, DbType.Int32);
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, param);
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
                CloseConnection();
            }
            return member;
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
                CloseConnection();
            }
            return resultList;
        }
        public void DeleteMember(int memberID)
        {
            try
            {
                MemberObject member = GetMemberByID(memberID);
                if (member != null)
                {
                    string SQLDelete = "Delete Members where MemberID = @MemberID";
                    var param = dataProvider.CreateParameter("@MemberID", 20, memberID, DbType.Int32);
                    dataProvider.Delete(SQLDelete, CommandType.Text, param);
                }
                else
                {
                    throw new Exception("Member does not exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public void InsertMember(MemberObject member)
        {

            try
            {
                MemberObject m = GetMemberByID(member.MemberID);
                if (m == null)
                {
                    if (CheckDuplicateEmail(member.Email))
                    {
                        throw new Exception("The email already exists.");
                    }
                    else
                    {
                        string SQLUpdate = "Insert into Members values(@MemberID,@MemberName,@Email, @Password,@City,@Country)";
                        var param = new List<SqlParameter>();
                        param.Add(dataProvider.CreateParameter("@MemberID", 4, member.MemberID, DbType.Int32));
                        param.Add(dataProvider.CreateParameter("@MemberName", 50, member.Email, DbType.String));
                        param.Add(dataProvider.CreateParameter("@Email", 20, member.Email, DbType.String));
                        param.Add(dataProvider.CreateParameter("@Password", 20, member.Password, DbType.String));
                        param.Add(dataProvider.CreateParameter("@City", 10, member.City, DbType.String));
                        param.Add(dataProvider.CreateParameter("@Country", 10, member.Country, DbType.String));
                        dataProvider.Insert(SQLUpdate, CommandType.Text, param.ToArray());
                    }
                }
                else
                {
                    throw new Exception("The member already exists");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public bool CheckDuplicateEmail(string email)
        {
            var resultList = GetMember();
            bool result = false;
            try
            {
                foreach (var member in resultList)
                {
                    if (member.Email == email)
                    {
                        result = true;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public IList<MemberObject> FilterByCountry(string countryValue)
        {
            var membersInCountry = new List<MemberObject>();
            var resultList = GetMember();
            foreach (var member in resultList)
            {
                if (member.Country.Contains(countryValue))
                {
                    membersInCountry.Add(new MemberObject
                    {
                        MemberID = member.MemberID,
                        MemberName = member.MemberName,
                        Email = member.Email,
                        Password = member.Password,
                        City = member.City,
                        Country = member.Country
                    });
                }
            }
            return membersInCountry;
        }
        public IList<MemberObject> FilterByCity(string CityName)
        {
            throw new NotImplementedException();
        }

    }
}