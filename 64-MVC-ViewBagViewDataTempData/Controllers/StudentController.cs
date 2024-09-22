using _64_MVC_ViewBagViewDataTempData.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections;

namespace _64_MVC_ViewBagViewDataTempData.Controllers
{
    public class StudentController : Controller
    {
        private static List<Student> _students;
        public StudentController()
        {
            if( _students is null )
                _students = new List<Student>();

            //Dynamic: 4.0 da tanıtılan özel bir veri tipi. Ama tip güvenliği olmayan bir yapıdır. C#'ın tip güvenliğini prensibinden sapmamıza neden olur. 

            //Dynamic: bir değişken veya nesne dynamic olarak tanımlandığında bu nesnenin tipi derleme zamanında belirlenmez. Tip bilgisi çalışma zamanında belirlenir.

            //ArrayList arrayList = new ArrayList();
            //arrayList.Add(2);
            //arrayList.Add(3);
            //arrayList.Add(4);
            //arrayList.Add("a");
            //arrayList.Add("b");

            //var result = (int)arrayList[3] * 2;

            //var ornek = "12"; //Derleme Zamanı
            //Console.WriteLine(ornek * 2);

            //dynamic name = "12"; //Çalışma Zamanı
            //Console.WriteLine($"Type: {name.GetType()}");
            //Console.WriteLine($"Value: {name}");
            //Console.WriteLine(name * 2);

            //dynamic stud = new Student();
            //stud.Id = 1;
            //stud.Name = "Test";

            //Console.WriteLine($"{stud.Id} - {stud.Name}");

        }
        public IActionResult Index()
        {
            //Model
            List<Student> students = new();
            students.Add(new() { Id=1, Name="Fatih" });
            students.Add(new() { Id=2, Name="Yasin" });
            students.Add(new() { Id=3, Name="Yunus" });
            students.Add(new() { Id=4, Name="Güneş" });

            //ViewBag
            //Controllerdan View veri iletmek için tasarlanan dinamik bir nesnedir. Verileri okumak için typecast'e ve null kontrolüne ihtiyacı yoktur.

            ViewBag.Baslik = "4A Sınıfı";
            ViewBag.Ogrenciler = students;

            //ViewData
            //Controllerdan View veri iletmek için tasarlanan dictionary nesnesidir. Key/Value çifti biçiminde iletilir. Verileri okumak için typecast'e ve null kontrolüne ihtiyacı vardır.

            ViewData["Baslik1"] = "5A Sınıfı";
            ViewData["Ogrenciler1"] = students;

            //TempData: Controllerdan farklı Controllerlara veya Metotlara data taşımak.
            TempData["Baslik2"] = "6A Sınıfı";
            TempData["Ogrenciler2"] = students;

            return View(students);
        }

        [HttpGet]
        public IActionResult Create()
        { 
            return View();
        }

        //1-Input Name ile Data Almak
        //[HttpPost]
        //public IActionResult Create(int id, string name)
        //{
        //    _students.Add(new() { Id=id, Name=name });
        //    return RedirectToAction("List");
        //}

        //2-IFormCollection ile Data Almak
        //[HttpPost]
        //public IActionResult Create(IFormCollection form)
        //{
        //    string id = form["id"];
        //    string name = form["name"];
        //    _students.Add(new Student() { Id = int.Parse(id), Name = name });

        //    return RedirectToAction("List");
        //}

        //3-Model ile Data Almak
        [HttpPost]
        public IActionResult Create(Student model)
        {
            _students.Add(model);
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult List()
        {
            return View(_students);
        }

        public IActionResult Info()
        {
            TempData["ErrorMessage"] = "Bir hata gerçekleşti...";
            return RedirectToAction("Error");
        }

        public IActionResult Error()
        {
            //Aşağıdaki kodda ilk okuma (istek) gerçekleştikten sonra veriler silinecektir.
            //var errorMessage = TempData["ErrorMessage"] as string;

            //Peek ve Keep

            //#Peek: peek metodu kulllanıldığında veri okunmadan önce bir sonraki istek için saklanmaya devam eder.
            //var errorMessage = TempData.Peek("ErrorMessage") as string;

            //Keep: keep metodunu kullanırsak veriyi okuduktan sonra bir sonraki istek için saklanmaya devam eder.
            var errorMessage = TempData["ErrorMessage"] as string;
            TempData.Keep("ErrorMessage");

            return Content(errorMessage);
        }
    }
}
