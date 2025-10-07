using SRP_CaseStudy.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_CaseStudy.Services
{
    internal class LateFeeService
    {
        public double CalculateLateFee(Loan loan) {
            if (loan != null) 
            {
                if (!loan.isReturned && DateTime.Now > loan.DueDate)
                {
                    int daysLate = (DateTime.Now - loan.DueDate).Days;
                    return daysLate * 20;
                }
            }
            return 0;
        }
    }
}
