using SRP_CaseStudy.Entities;
using SRP_CaseStudy.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_CaseStudy.Services
{
    
    internal class BookService
    {
        private readonly IBookRepository _repository;

        public BookService(IBookRepository repository) { 
            _repository = repository;

        }

        public void AddBook(Book book) { 
            _repository.AddBook(book);
            Console.WriteLine($"[Book Service] added '{book.Title}' by Author: '{book.Author}'");
        }

        public Book? GetBook(int id) => _repository.GetById(id);

        public IEnumerable<Book> GetAllBooks() => _repository.GetAll();

        public void MarkAsBorrowed(Book book) {
            book.isAvailable = false;

            _repository.updateBook(book);
        }

        public void MarkAsReturned(Book book)
        {
            book.isAvailable = true;

            _repository.updateBook(book);
        }
    }
}
