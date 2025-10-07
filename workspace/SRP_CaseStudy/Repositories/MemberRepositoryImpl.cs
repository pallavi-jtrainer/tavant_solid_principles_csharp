using SRP_CaseStudy.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_CaseStudy.Repositories
{
    internal class MemberRepositoryImpl : IMemberRepository
    {
        private readonly List<Member> _members = new List<Member>();


        public void AddMember(Member member)
        {
            member.Id = _members.Count + 1;
            _members.Add(member);
        }

        public IEnumerable<Member> GetAll() => _members;
       

        public Member? GetById(int id) => _members.FirstOrDefault(m => m.Id == id);
      
    }
}
