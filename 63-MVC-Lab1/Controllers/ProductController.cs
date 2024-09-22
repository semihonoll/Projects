using _63_MVC_Lab1.Models;
using Microsoft.AspNetCore.Mvc;

namespace _63_MVC_Lab1.Controllers
{
    public class ProductController : Controller
    {
        private static IList<Product> products;

        public ProductController()
        {
            if(products is null)
                products = new List<Product>() 
                { 
                    new Product{ Id=1, Name="Kalem-1", Price=100, Stock=500 },
                    new Product{ Id=2, Name="Kalem-2", Price=110, Stock=400 },
                    new Product{ Id=3, Name="Kalem-3", Price=130, Stock=500 },
                    new Product{ Id=4, Name="Kalem-4", Price=110, Stock=500 },
                    new Product{ Id=5, Name="Kalem-5", Price=120, Stock=540 },
                    new Product{ Id=6, Name="Kalem-6", Price=140, Stock=440 },
                    new Product{ Id=7, Name="Kalem-7", Price=120, Stock=560 },
                    new Product{ Id=8, Name="Kalem-8", Price=120, Stock=400 }
                };
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View(products);
        }

        [HttpGet]
        public IActionResult Details(int id) 
        { 
            var product = products.FirstOrDefault(x => x.Id == id);
            return View(product); 
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();  
        }

        [HttpPost]
        public IActionResult Create(Product model)
        {
            products.Add(model);
            return RedirectToAction("Index");
        }
    }
}
