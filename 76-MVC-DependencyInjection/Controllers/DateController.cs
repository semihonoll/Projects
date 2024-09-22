using _76_MVC_DependencyInjection.Services;
using Microsoft.AspNetCore.Mvc;

namespace _76_MVC_DependencyInjection.Controllers
{
    public class DateController : Controller
    {
        private readonly IShowDateTime _date;

        public DateController(IShowDateTime date)
        {
            _date = date;
        }

        public IActionResult Index([FromServices] IShowDateTime date2)
        {
            var time = _date.GetDateTime.TimeOfDay;

            var time2 = date2.GetDateTime.TimeOfDay;

            return Content($"Time 1: {time} \nTime 2: {time2}");
        }
    }
}
