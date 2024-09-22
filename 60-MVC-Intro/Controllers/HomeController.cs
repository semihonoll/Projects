using _60_MVC_Intro.Models;
using Microsoft.AspNetCore.Mvc;

namespace _60_MVC_Intro.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //return Content("Merhaba Ilk MVC Projesi");
            return View();
        }

        public IActionResult Product()
        {
            //return Content("Tüm ürünlerimin listesi...");

            Product product1 = new Product() { Id = 1, Name = "Tuvalet Kağıdı", Price = 150 };

            return View(product1);
        }
    }
}
