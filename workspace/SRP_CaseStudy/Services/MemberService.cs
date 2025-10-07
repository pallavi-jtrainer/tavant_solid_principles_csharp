using SRP_CaseStudy.Entities;
using SRP_CaseStudy.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_CaseStudy.Services
{
    internal class MemberService
    {
        private readonly IMemberRepository _repository;

        public MemberService(IMemberRepository repository) { 
            _repository = repository;
        }

        public void Register(Member member) { 
            _repository.AddMember(member);
            Console.WriteLine($"Member registered. {member.Name}");
        }

        public Member? GetMember(int id) => _repository.GetById(id);

        public IEnumerable<Member> GetAllMembers() => _repository.GetAll();


    }
}
