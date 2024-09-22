using Microsoft.AspNetCore.Mvc;

namespace _82_MVC_StateManagement.Controllers
{
    public class SessionController : Controller
    {
        public IActionResult Index()
        {
            HttpContext.Session.SetString("UserName", "BilgeAdam");
            return Content("Sesion veri eklendi");
        }

        public IActionResult Home()
        {
            string userName = HttpContext.Session.GetString("UserName");
            return Content($"User Name:{userName}");
        }
    }
}
