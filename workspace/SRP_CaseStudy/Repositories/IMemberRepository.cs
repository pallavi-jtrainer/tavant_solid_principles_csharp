using SRP_CaseStudy.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_CaseStudy.Repositories
{
    internal interface IMemberRepository
    {
        void AddMember(Member member);
        Member? GetById(int id);
        IEnumerable<Member> GetAll();
    }
}
