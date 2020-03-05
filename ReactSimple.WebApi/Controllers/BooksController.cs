using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReactSimple.WebApi.Models;

namespace ReactSimple.WebApi.Controllers
{
    
    [ApiController]
    public class BooksController : ControllerBase
    {

        List<Book> bookList;
        public BooksController()
        {
            bookList = new List<Book>
            {
               new Book()
               {
                   Id=1,
                   Name="Book1",
                   AuthorName="Author1"
               },
               new Book()
               {
                   Id=2,
                   Name="Book2",
                   AuthorName="Author2"
               },
               new Book()
               {
                   Id=3,
                   Name="Book3",
                   AuthorName="Author3"
               },
               new Book()
               {
                   Id=4,
                   Name="Book4",
                   AuthorName="Author4"
               },

            };
        }


        [HttpGet("/api/books")]
        public IActionResult GetBooks()
        {
            return Ok(bookList);
        }

        [HttpGet("api/book/{id}")]
        public IActionResult GetBook(int id)
        {
            return Ok(bookList.Find(i=>i.Id==id));
        }

    }
}