using _76_MVC_DependencyInjection.Services;
using Microsoft.AspNetCore.Mvc;

namespace _76_MVC_DependencyInjection.Controllers
{
    public class SendController : Controller
    {
        private readonly IMessageService _messageService;

        public SendController(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public IActionResult Index()
        {
            var message = _messageService.SendMessage("Merhaba Dependency Injection");
            return Content(message);
        }
    }
}
