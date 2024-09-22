using Microsoft.AspNetCore.Mvc;

namespace _82_MVC_StateManagement.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            string name = HttpContext.Request.Query["name"];
            string age="";

            bool hasAge = HttpContext.Request.Query.ContainsKey("age");

            if (hasAge)
                age = HttpContext.Request.Query["age"];

            foreach (var item in HttpContext.Request.Query)
            {
                string key = item.Key;
                string value = item.Value;
            }


            return Content($"Adı: {name}, Yaşı: {age}");
        }

        public IActionResult GitUrl()
        {
            var url = Url.Action("Index", "Product", new { name = "Fatih", age = 37 });
            return Redirect(url);
        }
    }
}
