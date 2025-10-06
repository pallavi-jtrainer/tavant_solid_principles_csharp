using SRP_CaseStudy.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_CaseStudy.Repositories
{
    internal interface IBookRepository
    {
        void AddBook(Book book);
        Book? GetById(int id);
        IEnumerable<Book> GetAll();
        void updateBook(Book book);


    }
}
