using BookAPI.Data.DataLayer;
using BookAPI.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookAPI.Data.Services
{
    public class BookService : IBookService
    {
        private readonly AppDbContext _dbContext;

        public BookService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Book AddBook(Book newbook)
        {
            _dbContext.Books.Add(newbook);
            _dbContext.SaveChanges();
            return newbook;
        }

        public void DeleteBook(Guid id)
        {
            _dbContext.Books.Remove(GetById(id));
            _dbContext.SaveChanges();
        }

        public List<Book> GetBooks()
        {
            return _dbContext.Books.ToList();
        }

        public Book GetById(Guid id)
        {
            return _dbContext.Books.FirstOrDefault(x => x.Id == id);    
        }

        public Book UpdateBook(Book book)
        {
            _dbContext.Update(book);
            _dbContext.SaveChanges();
            return book;
        }
    }
}
