using SRP_CaseStudy.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_CaseStudy.Services.Notifications
{
    internal interface INotificationService
    {
        void SendLoanNotification(Member member, Book book, Loan loan);
        void SendReturnNotification(Member member, Book book);

    }
}
