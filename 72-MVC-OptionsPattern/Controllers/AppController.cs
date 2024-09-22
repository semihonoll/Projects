using _72_MVC_OptionsPattern.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace _72_MVC_OptionsPattern.Controllers
{
    public class AppController : Controller
    {
        private readonly AppSettings _settings;

        public AppController(IOptions<AppSettings> settings)
        {
            _settings = settings.Value;
        }
        public IActionResult Index()
        {
            return Content($" Options Key: {_settings.AppKey} Options Value: {_settings.AppValue}");
        }

        public IActionResult home()
        {
            return Content($" Options Key: {_settings.AppKey} Options Value: {_settings.AppValue}");
        }
    }
}
