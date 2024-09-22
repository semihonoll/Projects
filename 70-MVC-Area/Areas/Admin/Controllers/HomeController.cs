using _70_MVC_Area.Areas.Admin.Models;
using _70_MVC_Area.Services;
using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace _70_MVC_Area.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var result = TempData.Peek("Login") as string;
            if (result != "true")
                return RedirectToAction("Login");

            var products = AppDbContext.ToList();
            return View(products);
        }

        public IActionResult IsActive(int id)
        { 
            AppDbContext.UpdateActive(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Create()
        { 
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product model, IFormFile ImageFile)
        {

                if (ImageFile != null && ImageFile.Length > 0)
                { 
                    var fileName = Path.GetFileName(ImageFile.FileName);
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/", fileName);
                    using (var fileStream = new FileStream(path, FileMode.Create))
                    {
                        ImageFile.CopyTo(fileStream);
                    }

                    model.Image = fileName;
                }

                AppDbContext.Add(model);
                return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpGet]
        public IActionResult LogOut()
        {
            TempData.Remove("Login");
            return RedirectToAction("Login");
        }

        [HttpPost]
        public IActionResult Login(AdminUser model)
        {
            if (ModelState.IsValid)
            {
                if (model.Password == "123" && model.UserName == "admin")
                {
                    TempData["Login"] = "true";
                    return RedirectToAction("Index");
                }
                else 
                {
                    TempData["Login"] = "false";
                    ModelState.AddModelError("admin", "Hatalı Kullanıcı Adı veya Şifre");
                }
            }
            return View(model);
        }
    }
}
