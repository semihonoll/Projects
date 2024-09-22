using _84_WebAPI_Intro.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _84_WebAPI_Intro.Controllers
{
    [Route("api/[controller]s")]
    [ApiController]
    public class HomeController : ControllerBase
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

        [HttpGet]
        public List<Book> Books()
        { 
            var bookList = books.OrderBy(x => x.Title).ToList();
            return bookList;
        }
    }
}
