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
            return MemberDAO.Instance.GetMemberList();
        }

        public void InsertMember(MemberObject member)
        {
            MemberDAO.Instance.InsertMember(member);
        }

        public MemberObject Login(string email, string password)
        {
           return MemberDAO.Instance.Login(email, password);
        }

        public IList<MemberObject> Search(string searchValue)
        {
            return MemberDAO.Instance.Search(searchValue);
        }

        public void UpdateMember(MemberObject member)
        {
            throw new NotImplementedException();
        }
         public IList<MemberObject> FilterByCountry(string countryValue)
        {
            return MemberDAO.Instance.FilterByCountry(countryValue);
        }

        public bool CheckDuplicateEmail(string email)
        {
            return MemberDAO.Instance.CheckDuplicateEmail(email);
        }
    }
}
