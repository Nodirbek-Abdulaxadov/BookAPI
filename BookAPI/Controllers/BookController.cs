using BookAPI.Data.Models;
using BookAPI.Data.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BookAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookController : ControllerBase
    {
        private readonly IBookService _service;

        public BookController(IBookService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("getall")]
        public IActionResult GetBooks()
        {
            return Ok(_service.GetBooks());
        }

        [HttpGet]
        [Route("get/{id}")]
        public IActionResult GetBook(Guid id)
        {
            return Ok(_service.GetById(id));
        }

        [HttpPost]
        [Route("add")]
        public IActionResult AddBook(Book newbook)
        {
            return Ok(_service.AddBook(newbook));
        }

        [HttpPut]
        [Route("update")]
        public IActionResult UpdateBook(Book book)
        {
            return Ok(_service.UpdateBook(book));
        }

        [HttpDelete]
        [Route("delete/{id}")]
        public IActionResult DeleteBook(Guid id)
        {
            _service.DeleteBook(id);
            return Ok();
        }
    }
}
