using _87_API_JWTToken.Models;
using _87_API_JWTToken.Models.DTOs;
using AutoMapper;

namespace _87_API_JWTToken.AutoMappers
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<UserRegisterDTO, AppUser>();
        }
    }
}
