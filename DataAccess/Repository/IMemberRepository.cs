using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
        public IList<MemberObject> GetMembers();
        public MemberObject GetMemberByID(int memberID);
        public void InsertMember(MemberObject member);
        public bool CheckDuplicateEmail(string email);
        public void DeleteMember(int memberID);
        public void UpdateMember(MemberObject member);
        public IList<MemberObject> Search(string searchValue);
        public MemberObject Login(string email, string password);
        public IList<MemberObject> FilterByCountry(string countryValue);
    }
}
