
using SRP_CaseStudy.Entities;
using SRP_CaseStudy.Repositories;
using SRP_CaseStudy.Services;

class Program
{
    static void Main()
    {
        // Setup Repositories
        var bookRepo = new BookRepositoryImpl();
        var memberRepo = new MemberRepositoryImpl();
        var loanRepo = new LoanRepositoryImpl();

        // Setup Services
        var bookService = new BookService(bookRepo);
        var memberService = new MemberService(memberRepo);
        var notificationService = new NotificationService();
        var loanService = new LoanService(loanRepo, bookService, notificationService);

        // --- Operations ---
        bookService.AddBook(new Book { Title = "Clean Code", Author = "Robert C. Martin" });
        bookService.AddBook(new Book { Title = "Domain-Driven Design", Author = "Eric Evans" });

        memberService.Register(new Member { Name = "Alice", Email = "alice@example.com" });

        var book = bookService.GetBook(1)!;
        var member = memberService.GetMember(1)!;

        loanService.BorrowBook(book, member);

        Console.WriteLine("\n--- Loans ---");
        foreach (var loan in loanService.GetAllLoans())
            Console.WriteLine($"Loan #{loan.Id}: {loan.Member.Name} borrowed '{loan.Book.Title}' (Due {loan.DueDate:dd-MMM-yyyy})");

        // Return the book
        loanService.ReturnBook(1);
    }
}