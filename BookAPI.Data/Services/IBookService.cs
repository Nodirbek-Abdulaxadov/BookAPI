using BookAPI.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookAPI.Data.Services
{
    public interface IBookService
    {
        List<Book> GetBooks();
        Book GetById(Guid id);
        Book AddBook(Book newbook);
        Book UpdateBook(Book book);
        void DeleteBook(Guid id);
    }
}
