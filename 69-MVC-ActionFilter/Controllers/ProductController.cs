using _69_MVC_ActionFilter.ActionFilters;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace _69_MVC_ActionFilter.Controllers
{
    public class ProductController : Controller
    {
        //Action Metotlar
        //1-Action Result
        //2-Action Verb
        //3-Action Name
        //4-NonAction
        //5-Action Filter

        [HttpGet()]
        //[ActionName("anasayfa")]
        [TypeFilter(typeof(LogActionFilter))]
        public IActionResult Index()
        {
            return View();
        }

        [NonAction]
        public string Home()
        {
            return "Merhaba Dünya";
        }

        //[ResponseCache(Duration = 3600)] //1 Saat boyunca
        //[Authorize(Roles = "Admin")]
        public IActionResult AdminPage() 
        {
            return Content("Admin Sayfası");
        }

        [TypeFilter(typeof(LogActionFilter))]
        public IActionResult Create()
        {
            return View();
        }
    }
}
