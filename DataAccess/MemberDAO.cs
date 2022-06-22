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
        public MemberObject Login(MemberObject member)
        {
            IDataReader dataReader = null;
            try
            {
                string sqlQuerry = "Select MemberID, MemberName, Email, Password, City,Country " +
                "From Members " +
                "Where Email = @Email And PassWord = @Password ";
                var parameters = new List<SqlParameter>();
                parameters.Add(dataprovider.CreateParameter("@Email", 20, member.Email, DbType.String));
                parameters.Add(dataprovider.CreateParameter("@Password",20, member.Password,DbType.String));
                var datareader = dataprovider.GetDataReader(sqlQuerry, CommandType.Text,out connection, parameters.ToArray());
                if (datareader.Read())
                {
                    member = new MemberObject
                    {
                        Email = member.Email,
                        Password = member.Password,
                        City = member.City,
                        Country = member.Country,
                        MemberID = member.MemberID,
                        MemberName = member.MemberName
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
                "Where MemberName = @memberName ";
                 
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
            return null;


           
            
        }


    }
}