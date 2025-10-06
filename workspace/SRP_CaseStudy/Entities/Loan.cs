using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_CaseStudy.Entities
{
    internal class Loan
    {
        public int Id { get; set; }
        public Book Book { get; set; } = new Book();
        public Member Member { get; set; } = new Member();
        public DateTime LoanDate { get; set; } = new DateTime();
        public DateTime DueDate { get; set; }
        public bool isReturned { get; set; }
    }
}
