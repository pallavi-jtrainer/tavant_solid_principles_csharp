using SRP_CaseStudy.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_CaseStudy.Repositories
{
    internal interface ILoanRepository
    {
        void AddLoan(Loan loan);
        Loan? GetById(int id);
        void UpdateLoan(Loan loan);
        IEnumerable<Loan> GetAll();
    }
}
