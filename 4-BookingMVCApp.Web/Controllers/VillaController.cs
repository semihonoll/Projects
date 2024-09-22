using _1_BookingMVCApp.Domain.Entities;
using _2_BookingMVCApp.Infrastructure.Data;
using _3_BookingMVCApp.Application.Common.DTO;
using _3_BookingMVCApp.Application.Common.Interfaces;
using _3_BookingMVCApp.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace _4_BookingMVCApp.Web.Controllers
{
    public class VillaController : Controller
    {
        private readonly IVillaService _villaService;

        public VillaController(IVillaService villaService)
        {
            _villaService = villaService;
        }

        public IActionResult Index()
        {
            var villas = _villaService.GetAllVillas();
            return View(villas);
        }

        [HttpGet]
        public IActionResult Create()
        { 
            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateVillaDTO model)
        {
            if (model.Name == model.Description) 
            {
                ModelState.AddModelError("", "The Description cannot exactly match the Name");
            }
            if (ModelState.IsValid) 
            {
                _villaService.CreateVilla(model);
                TempData["success"] = "The villa has been created succesfuly";
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Update(int villaId)
        { 
            Villa? villa = _villaService.GetVillaById(villaId);

            if (villa == null)
            {
                return RedirectToAction("Error", "Home");
            }
            else
            {
                CreateVillaDTO createVillaDTO = new CreateVillaDTO()
                {
                    Name = villa.Name,
                    Description = villa.Description,
                    ImageUrl = villa.ImageUrl,
                    Occupancy = villa.Occupancy,
                    Price = villa.Price,
                    Sqft = villa.Sqft
                };
                return View(createVillaDTO);
            }
        }

        [HttpPost]
        public IActionResult Update(CreateVillaDTO model, int villaId) 
        {
            if (ModelState.IsValid && villaId>0) 
            {
                _villaService.UpdateVilla(model, villaId);
                TempData["success"] = "The villa has been updated succesfuly";
                return RedirectToAction("Index");
            }
            TempData["error"] = "The villa could not be updated";
            return View(model);
        }

        [HttpGet]
        public IActionResult Delete(int villaId) 
        {
            Villa? model = _villaService.GetVillaById(villaId);
            if (model is not null) 
            {
                _villaService.DeleteVilla(villaId);
                TempData["success"] = "The villa has been deleted succesfuly";
                return RedirectToAction("Index");
            }
            TempData["error"] = "The villa could not be deleted";
            return View(model);
        }
    }
}
