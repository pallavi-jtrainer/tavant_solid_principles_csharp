using SRP_CaseStudy.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_CaseStudy.Repositories
{
    internal class LoanRepositoryImpl : ILoanRepository
    {
        private readonly List<Loan> _loans = new List<Loan>();

        public void AddLoan(Loan loan) {
            loan.Id = _loans.Count + 1;
            _loans.Add(loan);
        }

        public Loan? GetById(int id) => _loans.FirstOrDefault(x => x.Id == id);

        public IEnumerable<Loan> GetAll() => _loans;

        public void UpdateLoan(Loan loan) { 
            var existingLoan = GetById(loan.Id);
            if (existingLoan != null) { 
                existingLoan.isReturned = loan.isReturned;
                existingLoan.DueDate = loan.DueDate;
            }
        }
    }
}
