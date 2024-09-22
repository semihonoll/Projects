using _73_MVC_Entity.Contexts;
using _73_MVC_Entity.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _73_MVC_Entity.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;
        public ProductController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            //var products = _context.Products.ToList();
            var products = await _context.Products.ToListAsync();
            return View(products);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product model)
        {
             _context.Products.Add(model);
             _context.SaveChanges();

             return RedirectToAction("Index");
        }
    }
}
