using _80_MVC_IdentityCustomize.Models;
using _80_MVC_IdentityCustomize.Models.VMs;
using _80_MVC_IdentityCustomize.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace _80_MVC_IdentityCustomize.Controllers
{
    [Authorize]
    public class BookController : Controller
    {
        private readonly IBookService _bookService;
        private readonly UserManager<AppUser> _userManager;

        public BookController(IBookService bookService, UserManager<AppUser> userManager)
        {
            _bookService = bookService;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var userId  = _userManager.GetUserId(User);
            var books = await _bookService.GetUserBookAsync(userId);
            return View(books);
        }

        [HttpGet]
        public IActionResult Create() 
        { 
            return View();
        }

        [HttpPost]
        public IActionResult Create(BookCreateVM book) 
        {
            var userId = _userManager.GetUserId(User);
            var success = _bookService.AddBook(book, userId);
            if (success)
            {
                return RedirectToAction("Index");
            }
            return View(book);
        }
    }
}
