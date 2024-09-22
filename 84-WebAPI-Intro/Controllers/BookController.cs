using _84_WebAPI_Intro.Models;
using Microsoft.AspNetCore.Mvc;

namespace _84_WebAPI_Intro.Controllers
{
    [ApiController]
    [Route("api/[controller]s")]
    public class BookController : Controller
    {
        private static List<Book> books = new List<Book>()
        {
            new Book(){ Id=1, Title="Suç ve Ceza", GenreId=1, PageCount=220 },
            new Book(){ Id=2, Title="Yer Altından Notlar", GenreId=1, PageCount=120 },
            new Book(){ Id=3, Title="Savaş ve Barış", GenreId=1, PageCount=320 },
            new Book(){ Id=4, Title="İtiraflarım", GenreId=1, PageCount=320 },
            new Book(){ Id=5, Title="Dönüşüm", GenreId=2, PageCount=300 },
            new Book(){ Id=6, Title="Efendi", GenreId=2, PageCount=150 },
            new Book(){ Id=7, Title="Beyaz Diş", GenreId=2, PageCount=20 },
            new Book(){ Id=8, Title="Istanbul", GenreId=2, PageCount=80 },
        };

        /* -IActionResult
         * -Void
         * Primitive veya Complext tip
         * HttpResponseMessage
         */

        [HttpGet]
        public List<Book> Books()
        {
            var bookList = books.OrderBy(x => x.Title).ToList();
            return bookList;
        }

        [HttpGet("{id}")]
        public Book BookById(int id)
        { 
            var book = books.FirstOrDefault(x => x.Id == id);
            return book;
        }

        [HttpGet]
        [Route("Search")]
        public List<Book> BookByName(string name, string orderBy)
        { 
            var book = books.Where(x => x.Title.Contains(name)).ToList();
            if (orderBy == "desc")
            {
                book.OrderByDescending(x => x.Title);
            }
            else
            { 
                book.OrderBy(x => x.Title);
            }
            return book;
        }

        [HttpPost]
        public IActionResult AddBook([FromBody] Book newBook)
        { 
            var book = books.SingleOrDefault(x => x.Title == newBook.Title);
            if (book is not null)
            {
                return BadRequest();
            }
            else 
            { 
                books.Add(newBook);
                return Ok();
            }
        }

        [HttpPut("ID")]
        public IActionResult UpdateBook(int id, [FromBody] Book updatedBook)
        {
            var book = books.FirstOrDefault(x => x.Id == id);
            if (book is null)
            {
                return BadRequest();
            }
            else 
            { 
                book.Id = updatedBook.Id;
                book.GenreId = updatedBook.GenreId;
                book.Title = updatedBook.Title;
                book.PageCount = updatedBook.PageCount;
                return Ok();
            }
        }

        [HttpDelete("{id}")]
        public void DeleteBook(int id) 
        { 
            var book = books.FirstOrDefault(x => x.Id == id);
            books.Remove(book);
        }
    }
}
