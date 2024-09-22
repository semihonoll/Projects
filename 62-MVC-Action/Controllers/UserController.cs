using Microsoft.AspNetCore.Mvc;

namespace _62_MVC_Action.Controllers
{
    public class UserController : Controller
    {
        //Controller'ın içerisinde: fields, properties ve metotları özgürce kullanabılirsiniz.
        
        
        //Action Metot: uygulamamızdaki bir eyleme karşılık gelen operasyonları yöneten ve ardından işlemini sonucuna göre kullanıcıya bir sonuç üreten metotlardır.
        //Kısacası web üzerinde ki isteklerin nasıl yanıt verileceğini belirler.
        public IActionResult Index()
        {
            string userName = "alkanfatih";
            //##Action Result
            //#View Result : HTML Çıktısı oluşturmak için
            return View();
            //return View(userName);
            //return View("Create");
            //return View("Create", userName);

            //#Content Result: Metin çıktısı oluşturmak için
            //return Content("Merhaba Dünya");

            //#Redirect Result: Bir URL'ye yönlendirmek için.
            //return Redirect("../Boost Entity Framework Uygulama Maraton.pdf");

            //RedirectToAction: Belirli bir contorller ve actiona yönlendirmek için.
            //return RedirectToAction("Index","Home");

            //#JSon Result
            //var userData = new { Name = "Yasin", Surname = "Tanriverdi", Age = 25 };
            //return Json(userData);

            //#File Result
            //return File()

            //#Status Code Result
            //var data = new { Message = "İşlem Başarılı!!" };
            //return Ok(data);
        }

        //##Action Verb: Gelen isteğin türüne göre bir işlem gerçekleştirmek istediğimiz zaman kullanırız.

        [HttpGet]
        public IActionResult Create(string userName, string email, string pass)
        {
            if (userName is null)
            {
                return View();
            }
            else
            {
                string deneme = $"{userName} - {email} - {pass}";
                return Content(deneme);
            }
        }

        //[HttpPost]
        //public IActionResult Create(string userName, string email, string pass)
        //{
        //    string message = $"Sitemize Hoş Geldiniz. Üyelik Bilgileriniz: {userName} - {email} - {pass}";
        //    return Content(message);
        //}


    }
}
