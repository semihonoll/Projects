using _87_API_JWTToken.Contexts;
using _87_API_JWTToken.Models;
using _87_API_JWTToken.Models.DTOs;
using _87_API_JWTToken.Services;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace _87_API_JWTToken.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly IMapper _mapping;
        private readonly MyTokenService _myTokenService;

        public AccountController(AppDbContext context, UserManager<AppUser> userManager, IMapper mapping, MyTokenService myTokenService)
        {
            _context = context;
            _userManager = userManager;
            _mapping = mapping;
            _myTokenService = myTokenService;
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IdentityResult> RegisterUser(UserRegisterDTO model)
        { 
            var user = _mapping.Map<AppUser>(model);
            var result = await _userManager.CreateAsync(user, model.Password);
            return result;
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> Login([FromBody] UserLoginDTO model) 
        {
            if (!await _myTokenService.ValidateUser(model))
                return Unauthorized();

            return Ok(new { Token = await _myTokenService.CreateToken() });
        }
    }
}
