using _67_MVC_ViewModel.Models;
using _67_MVC_ViewModel.Models.VMs;
using Microsoft.AspNetCore.Mvc;

namespace _67_MVC_ViewModel.Controllers
{
    public class StudentController : Controller
    {
        private static IList<Student> _students;
        private static IList<Course> _courses;

        public StudentController()
        {
            if (_students == null)
            {
                _students = new List<Student>()
                {
                    new Student() {FirstName="Hüseyin", LastName="Arı", Age=8, CourseId=1 },
                    new Student() {FirstName="Fatih", LastName="Alkan", Age=7, CourseId=1 },
                    new Student() {FirstName="Osman", LastName="Genç", Age=8, CourseId=1 },
                    new Student() {FirstName="Büşra", LastName="Yılmaz", Age=7, CourseId=2 },
                    new Student() {FirstName="Selin", LastName="Gül", Age=8, CourseId=2 }
                };
            }

            if (_courses == null)
            {
                _courses = new List<Course>()
                {
                    new Course() { Id=1, Name="3A" },
                    new Course() { Id=2, Name="3B" },
                    new Course() { Id=3, Name="3C" }
                };
            }
        }

        public IActionResult Index()
        {
            GetAllVM getAllVM = new GetAllVM();
            getAllVM.Students = _students;
            getAllVM.Courses = _courses;

            return View(getAllVM);
        }

        public IActionResult GetStudentByCourseId(int Id)
        {
            GetAllVM getAllVM = new GetAllVM();
            getAllVM.Students = _students.Where(x => x.CourseId == Id).ToList();
            getAllVM.Courses = _courses;

            return View(getAllVM);
        }

        [HttpGet]
        public IActionResult Create()
        {
            CreateStudentVM studentVM = new CreateStudentVM();
            studentVM.Courses = _courses;
            return View(studentVM);
        }

        [HttpPost]
        public IActionResult Create(CreateStudentVM model)
        {
            if (ModelState.IsValid)
            {
                _students.Add(new Student { FirstName = model.FirstName, LastName = model.LastName, Age = model.Age, CourseId = model.CourseId });
                return RedirectToAction("Index");
            }

            model.Courses = _courses;
            return View(model);
        }

        [HttpGet]
        public IActionResult Delete(string id) 
        { 
            var student = _students.FirstOrDefault(x => x.Id == id);

            if (student != null) 
            { 
                _students.Remove(student);
                return RedirectToAction("Index");
            }
            return NotFound();
        }
    }
}
