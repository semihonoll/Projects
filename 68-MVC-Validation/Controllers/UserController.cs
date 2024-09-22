using _68_MVC_Validation.Models;
using _68_MVC_Validation.Models.VMs;
using Microsoft.AspNetCore.Mvc;

namespace _68_MVC_Validation.Controllers
{
    public class UserController : Controller
    {
        private static IList<WebUser> _users;

        public UserController()
        {
            if (_users == null)
                _users = new List<WebUser>();
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        { 
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterVM model)
        {
            if (ModelState.IsValid)
            {
                WebUser user = new WebUser();
                user.Email = model.Email;
                user.FirstName = model.FirstName;
                user.LastName = model.LastName;
                user.Password = model.Password;
                _users.Add(user);

                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Create() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ProductCreateVM model)
        {
            //if (ModelState.IsValid)
            //    return RedirectToAction("Index");
            //return View(model);

            if (string.IsNullOrEmpty(model.Name))
            {
                ModelState.AddModelError("Name", "Müşteri Adı Zorunludur.");
            }

            return View(model);
        }

        
    }
}
