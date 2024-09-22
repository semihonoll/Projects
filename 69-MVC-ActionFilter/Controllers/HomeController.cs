using _69_MVC_ActionFilter.ActionFilters;
using _69_MVC_ActionFilter.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _69_MVC_ActionFilter.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [TypeFilter(typeof(LogActionFilter))]
        public IActionResult Index()
        {
            _logger.LogInformation("Index action metot invoke edildi.");
            return View();
        }

        [TypeFilter(typeof(LogActionFilter))]
        public IActionResult Privacy()
        {
            _logger.LogError("Bir hata gerçekleşti");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
