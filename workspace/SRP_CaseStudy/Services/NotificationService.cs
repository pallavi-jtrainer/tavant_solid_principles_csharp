using SRP_CaseStudy.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_CaseStudy.Services
{
    internal class NotificationService
    {
        public void SendLoanNotification(Member member, Book book, Loan loan) {
            Console.WriteLine($"Notification to: {member.Email}");
            Console.WriteLine($" You Borrowed {book.Title} on {loan.LoanDate}. Due date is {loan.DueDate}");
        }

        public void SendReturnNotification(Member member, Book book, Loan loan)
        {
            Console.WriteLine($"Notification to: {member.Email}");
            Console.WriteLine($" You Returned {book.Title}. Thank you");
        }
    }
}
