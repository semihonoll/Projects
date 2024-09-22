using Microsoft.AspNetCore.Mvc;

namespace _71_MVC_Routing.Controllers
{
    //[Route("{controller}s/{action=Index}")]
    [Route("{controller}")]
    public class ProductController : Controller
    {
        [Route("anasayfa")]
        public IActionResult Index()
        {
            return Content("Product Index Sayfası");
        }

        [Route("urun/{entryId:range(1,200)}/{slug:minlength(3):maxlength(50)}")]
        public IActionResult Main(int entryId, string slug) 
        {
            return Content($"Id: {entryId} Slug: {slug}");
        }

        [Route(@"ekle/{slug:regex([A-Z]{2}[0-9]{3})}")]
        public IActionResult Create(string code)
        {
            return Content($"Code: {code}");
        }
    }
}
