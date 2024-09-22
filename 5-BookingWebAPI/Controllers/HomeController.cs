using _3_BookingMVCApp.Application.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _5_BookingWebAPI.Controllers
{
    [Route("api/[controller]s")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IVillaService _villaService;

        public HomeController(IVillaService villaService)
        {
            _villaService = villaService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var villas = _villaService.GetAllVillas();
            return Ok(villas);
        }
    }
}
