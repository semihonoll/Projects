using _87_API_JWTToken.Contexts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _87_API_JWTToken.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PersonController(AppDbContext context)
        {
            _context = context;
        }

        [Authorize]
        [HttpGet]
        [Route("[action]")]
        public IActionResult Get() 
        { 
            var persons = _context.Person.ToList();
            return Ok(persons);
        }
    }
}
