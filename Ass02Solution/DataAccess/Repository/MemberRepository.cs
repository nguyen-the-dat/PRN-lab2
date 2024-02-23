using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {

        public void Create(Member member)
        {
            AssSalesContext.Instance.Add(member);
            AssSalesContext.Instance.SaveChanges();
        }

        public void Delete(string email)
        {
            Member member = GetMember(email);
            AssSalesContext.Instance.Remove(member);
            AssSalesContext.Instance.SaveChanges();
        }

        public Member GetMember(string email)
        {
            return AssSalesContext.Instance.Members.ToList().FirstOrDefault(c => c.Email.Equals(email));
        }

        public List<Member> GetMembers() => AssSalesContext.Instance.Members.ToList();

        public void Update()
        {
            AssSalesContext.Instance.SaveChanges();
        }
    }
}
