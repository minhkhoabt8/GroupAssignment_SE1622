using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {
        public void DeleteMember(int memberID)
        {
            throw new NotImplementedException();
        }

        public MemberObject GetMemberByID(int memberID)
        {
            throw new NotImplementedException();
        }

        public IList<MemberObject> GetMembers()
        {
            throw new NotImplementedException();
        }

        public void InsertMember(MemberObject member)
        {
            throw new NotImplementedException();
        }

        public MemberObject Login(string email, string password)
        {
            throw new NotImplementedException();
        }

        public IList<MemberObject> Search(string searchValue)
        {
            throw new NotImplementedException();
        }

        public void UpdateMember(MemberObject member)
        {
            throw new NotImplementedException();
        }
    }
}
