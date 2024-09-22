using Microsoft.AspNetCore.Mvc;

namespace _60_MVC_Intro.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
