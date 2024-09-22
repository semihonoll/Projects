using _61_MVC_Intro2.Models;
using Microsoft.AspNetCore.Mvc;

namespace _61_MVC_Intro2.Controllers
{
    public class ProductController : Controller
    {
        private readonly IList<Product> products;

        public ProductController()
        {
            products = new List<Product>() {
                new Product { Id=1, Name="Kalem-1", Price=100 },
                new Product { Id=2, Name="Kalem-2", Price=200 },
                new Product { Id=3, Name="Kalem-3", Price=300 }
            };
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            //Model Binding

            var product = new Product() { Id = 5, Name = "Kitap", Price = 250 };
            return View(product);

            //return View(products);

            //return View("UrunListele", products);

            //return View("Views/Product/UrunListele.cshtml");
            //return View("UrunListele");
        }
    }
}
