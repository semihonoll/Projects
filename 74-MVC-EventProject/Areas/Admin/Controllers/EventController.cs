using _74_MVC_EventProject.Areas.Admin.Models;
using _74_MVC_EventProject.Contexts;
using _74_MVC_EventProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace _74_MVC_EventProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class EventController : Controller
    {
        private readonly AppDbContext _context;

        public EventController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var events = _context.AppEvents.Select(x => new EventListVM { Id = x.Id, Name = x.Name, Summary = x.Summary, CategoryName = x.Category.Name, IsActive = x.IsActive, CreateDate = x.CreatedDate }).ToList();
            return View(events);
        }

        [HttpGet]
        public IActionResult Create()
        {
            EventCreateVM createVM = new EventCreateVM();
            createVM.Categories = _context.Categories.ToList();
            return View(createVM);
        }

        [HttpPost]
        public IActionResult Create(EventCreateVM createVM)
        {
            if (ModelState.IsValid) 
            {
                AppEvent appEvent = new AppEvent() { Name = createVM.Name, Summary = createVM.Summary, CategoryId = createVM.CategoryId };
                _context.AppEvents.Add(appEvent);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            createVM.Categories = _context.Categories.ToList();
            return View(createVM);
        }

        [HttpGet]
        public IActionResult Details(int id) 
        {
            var status = _context.AppEventDetails.Any(x => x.EventId == id);
            if (status)
            {
                var detail = _context.AppEventDetails.Find(id);
                var event1 = _context.AppEvents.Find(id);

                var createVM1 = new DetailCreateVM() { EventId = event1.Id, Name = event1.Name, Summary = event1.Summary, Description = detail.Description, FinishDate = detail.FinishDate, Location = detail.Location, Photo = detail.Photo, Price = detail.Price, RegisterDate = detail.RegisterDate, StartDate = detail.StartDate };
                return View(createVM1);
            }
            else
            {
                var result = _context.AppEvents.Find(id);
                var createVM = new DetailCreateVM() { EventId = result.Id, Name = result.Name, Summary = result.Summary };
                return View(createVM);
            }

        }

        [HttpPost]
        public IActionResult Details(DetailCreateVM model, IFormFile file)
        {
            string imgName = "default.png";
            if (file != null) 
            { 
                string imgExtension = Path.GetExtension(file.FileName);
                imgName = Guid.NewGuid() + imgExtension;

                string path = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/img/{imgName}");

                using var stream = new FileStream(path, FileMode.Create);
                file.CopyTo(stream);
            }

            AppEventDetail detail = new AppEventDetail();
            detail.EventId = model.EventId;
            detail.RegisterDate = model.RegisterDate;
            detail.FinishDate = model.FinishDate;
            detail.StartDate = model.StartDate;
            detail.Location = model.Location;
            detail.Photo = imgName;
            detail.Description = model.Description;
            detail.Price = model.Price;

            _context.Add(detail);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
