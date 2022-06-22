using BusinessObject;

namespace DataAccess
{
    public class MemberDAO
    {
        //Don't Modify This Code !!!
        private static IList<MemberObject> memberList = new List<MemberObject>()
        {
            // Email" : "admin@fstore.com",
            //Password" : "admin@@"
            new MemberObject{MemberID = 1, MemberName = "Khoa", Email = "khoa@gmail.com", Password = "admin", City = "HCM", Country = "VietNam"},
            new MemberObject{MemberID = 2, MemberName = "Phong", Email = "phong@gmail.com", Password = "admin", City = "HCM", Country = "VietNam"},
            new MemberObject{MemberID = 3, MemberName = "Cuong", Email = "cuong@gmail.com", Password = "admin", City = "HCM", Country = "VietNam"},
            new MemberObject{MemberID = 4, MemberName = "Quyen", Email = "quyen@gmail.com", Password = "admin", City = "HCM", Country = "VietNam"},
            new MemberObject{MemberID = 5, MemberName = "Thanh", Email = "thanh@gmail.com", Password = "admin", City = "HCM", Country = "VietNam"}
            //Info is not delete if new object the same id
        };
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
            
            foreach(var member in memberList)
            {
                if(member.Email.Equals(email) && member.Password.Equals(password))
                {
                    return new MemberObject
                    {
                        MemberID = member.MemberID,
                        MemberName = member.MemberName,
                        Email = email,
                        Password = password,
                        City = member.City,
                        Country = member.Country,
                    };
                }
            }
            return null;
        }
        public IList<MemberObject> Search(string searchValue)
        {
            var list = new List<MemberObject>();
            foreach (var member in memberList)
            {
                if (searchValue.Contains(member.Email) 
                    || searchValue.Contains(member.MemberID.ToString()) 
                    || searchValue.Contains(member.MemberName.ToLower()))
                {
                    list.Add(new MemberObject
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
            return list;
        }

        public void InsertMember(MemberObject member)
        {
            //Waiting for GetMemberByID function
            memberList.Add(member);
            //MemberObject checkMember = GetMemberByID(member.MemberID);
            //if(checkMember == null)
            //{
            //    memberList.Add(member);
            //}
            //else
            //{
            //    throw new Exception("Member is already exists");
            //}
        }

        public IList<MemberObject> GetMemberList()
        {
            return memberList;
        }
    }
}