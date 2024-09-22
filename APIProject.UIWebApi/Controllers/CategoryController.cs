using APIProject.Entities;
using APIProject.Service.Concrete;
using APIProject.Service.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIProject.UIWebApi.Controllers
{
    [Route("api/[controller]s")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        private readonly ILogger<Category> _logger;

        public CategoryController(ICategoryService categoryService, ILogger<Category> logger)
        {
            _logger = logger;
            _categoryService = categoryService;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> Get()
        {
            _logger.LogInformation("Kategori sayfasına istek atıldı");
            _logger.LogWarning("Kategori sayfasında bir hata oluşdu");

            var categories = await _categoryService.GetAllAsync();
            if(categories is not null)
                return Ok(categories);
            else
                return NotFound();
        }

        [HttpGet]
        [Route("[action]/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var category = await _categoryService.GetByIdAsync(id);
            return Ok(category);
        }

        [HttpPost]
        [Route("[action]")]
        public IActionResult Create([FromForm] CreateCategoryDTO category) 
        {
            return Ok(_categoryService.Create(category));
        }

        [HttpPut]
        [Route("[action]/{id}")]
        public IActionResult Update([FromBody] Category category, int id)
        { 
            return Ok(_categoryService.Update(category, id));  
        }
    }
}
