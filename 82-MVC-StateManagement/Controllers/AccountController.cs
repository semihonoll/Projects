using _82_MVC_StateManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace _82_MVC_StateManagement.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {

            // Oluşturma
            var cookieOptions = new CookieOptions
            {
                Expires = DateTime.Now.AddMinutes(5),
                HttpOnly = true,
                Secure = true, //HTTP - HTTPS
                SameSite = SameSiteMode.Strict //XSS Saldırılarına karşı koruma sağlar.
            };

            Response.Cookies.Append("MyCookie", "CookieValue", cookieOptions);


            //Okuma
            string deneme = Request.Cookies["MyCookie"];


            if (Request.Cookies.TryGetValue("MyCookie", out string CookieValue))
                return Content($"Cookie değeri: {CookieValue}");


            //Delete
            Response.Cookies.Delete("MyCookie");


            return Content(deneme);

        }

        [HttpGet]
        public IActionResult Login()
        {

            if (Request.Cookies.TryGetValue("AuthToken", out string _userName))
            {
                var login = new Login { UserName = _userName };
                return View(login);
            }

            return View();
        }

        [HttpPost]
        public IActionResult Login(Login model)
        {
            if (ModelState.IsValid)
            {
                if (IsValidUser(model)) 
                {
                    if (model.RememberMe == true) 
                    {
                        var cookieOptions = new CookieOptions
                        {
                            Expires = DateTime.Now.AddMinutes(30),
                            HttpOnly = true,
                            Secure = true,
                        };

                        Response.Cookies.Append("AuthToken", model.UserName, cookieOptions);
                        Response.Cookies.Append("ppas", model.Password, cookieOptions);

                    }

                    return RedirectToAction("Index","Home");
                }
            }
            return View();
        }

        private bool IsValidUser(Login model)
        {
            if (model.UserName == "alkan@mail.com" && model.Password == "123")
            {
                return true;
            }
            return false;
        }
        
    }
}
