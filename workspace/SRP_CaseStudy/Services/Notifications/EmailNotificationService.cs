using SRP_CaseStudy.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_CaseStudy.Services.Notifications
{
    internal class EmailNotificationService : INotificationService
    {
        public void SendLoanNotification(Member member, Book book, Loan loan)
        {
            Console.WriteLine($"[Notification] To: {member.Email}");
            Console.WriteLine($"   You borrowed '{book.Title}'. Due: {loan.DueDate:dd-MMM-yyyy}\n");
        }

        public void SendReturnNotification(Member member, Book book)
        {
            Console.WriteLine($"[Notification] To: {member.Email}");
            Console.WriteLine($"   Thanks for returning '{book.Title}'!\n");
        }
    }
}
