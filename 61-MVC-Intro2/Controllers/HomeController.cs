using _61_MVC_Intro2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _61_MVC_Intro2.Controllers
{
    //Controller Action Execution 
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //Action Filter...
        //Action Verb...
        public IActionResult Index()
        {
            //Action Invoking
            //Model Binding
            
            //Result Execution
            return View(); //View Rendering

            //Response...
            //Completion (Bitiş)

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
