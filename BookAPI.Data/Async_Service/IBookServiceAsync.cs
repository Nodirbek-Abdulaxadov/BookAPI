using BookAPI.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookAPI.Data.Async_Service
{
    public interface IBookServiceAsync
    {
        Task<List<Book>> GetAllAsync();
        Task<Book> GetByIdAsync(Guid id);
        Task<Book> AddBookAsync(Book newBook);
        Task<Book> UpdateBookAsync(Book book);
        Task DeleteBookAsync(Guid id);
    }
}
