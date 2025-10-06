using SRP_CaseStudy.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_CaseStudy.Repositories
{
    internal class BookRepositoryImpl : IBookRepository
    {
        private readonly List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            book.Id = books.Count + 1;
            books.Add(book);
        }

        public IEnumerable<Book> GetAll() => books;

        public Book? GetById(int id) => books.FirstOrDefault(x => x.Id == id);

        public void updateBook(Book book)
        {
            var existing = GetById(book.Id);

            if (existing != null) { 
                existing.isAvailable = book.isAvailable;
            }
        }
    }
}
