using _83_MVC_AutoMapper.Models;
using _83_MVC_AutoMapper.Models.VMs;
using AutoMapper;

namespace _83_MVC_AutoMapper.Maps
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<CreateVM, Employee>();

            CreateMap<Employee, ListVM>().ReverseMap();

            CreateMap<Employee, EmpDTO>().ForMember(dest => dest.FullName, opt => opt.MapFrom(src => src.FirstName + " " + src.LastName));
        }
    }
}
