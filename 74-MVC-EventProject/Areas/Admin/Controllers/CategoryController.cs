using _74_MVC_EventProject.Areas.Admin.Models;
using _74_MVC_EventProject.Contexts;
using _74_MVC_EventProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace _74_MVC_EventProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly AppDbContext _context;

        public CategoryController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var categories = _context.Categories.ToList();
            return View(categories);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CategoryCreateVM model)
        {
            if (ModelState.IsValid) 
            {
                var category = new Category() { Name = model.Name };
                _context.Categories.Add(category);
                var result = _context.SaveChanges();
                if(result>0)
                    return RedirectToAction("Index");
                return Content("Ooops! Beklenmedik bir hata oluştu...");
            }
            return View(model);
        }
    }
}
