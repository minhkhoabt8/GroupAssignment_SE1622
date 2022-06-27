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
            MemberDAO.Instance.DeleteMember(memberID);
        }

        public IList<MemberObject> GetMembers()
        {
            return MemberDAO.Instance.GetMember();
        }
        
        public void InsertMember(MemberObject member)
        {
            throw new NotImplementedException();
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
            MemberDAO.Instance.Update(member);
        }

        public IList<MemberObject> GetMembersSortByMemberName()
        {
            return MemberDAO.Instance.GetMemberSortByMemberName();
        }
        public IList<MemberObject> FilterByCountry(string countryValue)
        {
            throw new NotImplementedException();
        }

        public IList<MemberObject> FilterByCity(string countryValue)
        {
            throw new NotImplementedException();
        }
    }
}
