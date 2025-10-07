using SRP_CaseStudy.Entities;
using SRP_CaseStudy.Repositories;
using SRP_CaseStudy.Services.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_CaseStudy.Services
{
    internal class LoanService
    {
        private readonly ILoanRepository _loanRepo;
        private readonly BookService _bookService;
        //private readonly NotificationService _notificationService;
        private readonly INotificationService _notificationService;

        public LoanService(
            ILoanRepository loanRepo,
            BookService bookService,
            INotificationService notificationService)
        {
            _loanRepo = loanRepo;
            _bookService = bookService;
            _notificationService = notificationService;
        }

        public void BorrowBook(Book book, Member member)
        {
            if (!book.isAvailable)
            {
                Console.WriteLine($"[LoanService] '{book.Title}' is not available.");
                return;
            }

            var loan = new Loan
            {
                Book = book,
                Member = member,
                LoanDate = DateTime.Now,
                DueDate = DateTime.Now.AddDays(14),
                isReturned = false
            };

            _loanRepo.AddLoan(loan);
            _bookService.MarkAsBorrowed(book);
            _notificationService.SendLoanNotification(member, book, loan);

            Console.WriteLine($"[LoanService] '{member.Name}' borrowed '{book.Title}'");
        }

        public void ReturnBook(int loanId)
        {
            var loan = _loanRepo.GetById(loanId);
            if (loan == null)
            {
                Console.WriteLine("[LoanService] Loan not found.");
                return;
            }

            if (loan.isReturned)
            {
                Console.WriteLine("[LoanService] Already returned.");
                return;
            }

            loan.isReturned = true;
            _loanRepo.UpdateLoan(loan);
            _bookService.MarkAsReturned(loan.Book);
            _notificationService.SendReturnNotification(loan.Member, loan.Book);
        }

        public IEnumerable<Loan> GetAllLoans() => _loanRepo.GetAll();
    }

}
