using _86_API_GetPosts.Models;
using _86_API_GetPosts.Services;
using Microsoft.AspNetCore.Mvc;

namespace _86_API_GetPosts.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApiServices _apiServices;

        public CategoryController(ApiServices apiServices)
        {
            _apiServices = apiServices;
        }

        public async Task<IActionResult> Index()
        {
            var categories = await _apiServices.GetApiCategory();
            return View(categories);
        }

        public IActionResult Create() 
        { 
            return View();
        }

        public IActionResult Create2()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CategoryDTO categoryDTO) 
        {
            if (ModelState.IsValid)
            {
                var createdCategory = await _apiServices.PostApiCategory(categoryDTO);
                return RedirectToAction("Index");
            }
            return View(categoryDTO);
        }
    }
}
