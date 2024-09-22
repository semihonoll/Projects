using _83_MVC_AutoMapper.Models;
using _83_MVC_AutoMapper.Models.VMs;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace _83_MVC_AutoMapper.Controllers
{
    public class EmpController : Controller
    {
        private readonly IMapper _mapper;
        private static List<Employee> employees;
        public EmpController(IMapper mapper)
        {
            if (employees == null)
                employees = new List<Employee>();
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            //var listVm = employees.Select(x => new ListVM { FirstName = x.FirstName, LastName = x.LastName, Department = x.Department });

            var listVm = _mapper.Map<List<ListVM>>(employees);

            return View(listVm);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateVM model)
        {

            //var emp = new Employee() {
            //    FirstName = model.FirstName,
            //    LastName = model.LastName,
            //    Department = model.Department
            //};

            var emp = _mapper.Map<Employee>(model);

            employees.Add(emp);

            return RedirectToAction("Index");
        }

        public IActionResult Home()
        {
            var emp = new Employee()
            { 
                EmployeeId = 1,
                FirstName = "Fatih",
                LastName = "Alkan",
                Department ="IT"
            };

            var empDTO = _mapper.Map<EmpDTO>(emp);

            return Content($"İşçi Adı: {empDTO.FullName}");
        }
    }
}
