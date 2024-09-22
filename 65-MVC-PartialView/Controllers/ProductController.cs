using _65_MVC_PartialView.Models;
using Microsoft.AspNetCore.Mvc;

namespace _65_MVC_PartialView.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            List<Product> products = new List<Product>()
            {
                new Product { Id = 1, Name="Kalem-1", Price=10.9m },
                new Product { Id = 2, Name="Kalem-2", Price=14.9m },
                new Product { Id = 3, Name="Kalem-3", Price=13.9m },
                new Product { Id = 4, Name="Kalem-4", Price=12.9m },
                new Product { Id = 5, Name="Kalem-5", Price=18.9m },
                new Product { Id = 6, Name="Kalem-6", Price=15.9m },
                new Product { Id = 7, Name="Kalem-7", Price=16.9m },
                new Product { Id = 8, Name="Kalem-8", Price=12.9m }
            };

            return View(products);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
