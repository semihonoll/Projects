using _66_MVC_ViewComponent.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _66_MVC_ViewComponent.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<CartItem> cartItems = new List<CartItem>()
            {
                new CartItem { ProductName="Kalem-1", Price=12m },
                new CartItem { ProductName="Kalem-2", Price=12m },
                new CartItem { ProductName="Kalem-3", Price=12m },
                new CartItem { ProductName="Kalem-4", Price=12m },
                new CartItem { ProductName="Kalem-5", Price=12m },
                new CartItem { ProductName="Kalem-6", Price=12m },
                new CartItem { ProductName="Kalem-7", Price=12m },
                new CartItem { ProductName="Kalem-8", Price=12m },
                new CartItem { ProductName="Kalem-8", Price=12m },
                new CartItem { ProductName="Kalem-10", Price=12m },
                new CartItem { ProductName="Kalem-11", Price=12m }
            };
            return View(cartItems);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
