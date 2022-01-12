using BookAPI.Data.DataLayer;
using BookAPI.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookAPI.Data.Async_Service
{
    public class BookServiceAsync : IBookServiceAsync
    {
        private AppDbContext _dbContext;

        public BookServiceAsync(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Task<Book> AddBookAsync(Book newBook)
        {
            throw new NotImplementedException();
        }

        public Task DeleteBookAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Book>> GetAllAsync()
        {
            return _dbContext.Books.ToListAsync();
        }

        public Task<Book> GetByIdAsync(Guid id)
        {
            return _dbContext.Books.FirstOrDefaultAsync(x => x.Id == id);   
        }

        public Task<Book> UpdateBookAsync(Book book)
        {
            throw new NotImplementedException();
        }
    }
}
