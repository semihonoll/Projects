using _1_BookingMVCApp.Domain.Entities;
using _3_BookingMVCApp.Application.Common.DTO;
using _3_BookingMVCApp.Application.Common.Interfaces;
using _3_BookingMVCApp.Application.Services.Interfaces;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_BookingMVCApp.Application.Services.Implementation
{
    public class VillaService : IVillaService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public VillaService(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;
        }

        public void CreateVilla(CreateVillaDTO villa)
        {
            if (villa.Image != null)
            {
                string fileName = Guid.NewGuid().ToString() + Path.GetExtension(villa.Image.FileName);

                string imagePAth = Path.Combine(_webHostEnvironment.WebRootPath, @"images\VillaImage");

                using var fileStream = new FileStream(Path.Combine(imagePAth, fileName), FileMode.Create);

                villa.Image.CopyTo(fileStream);

                villa.ImageUrl = @"\images\VillaImage\" + fileName;
            }
            else {
                villa.ImageUrl = "https://via.placeholder.com/600x400";
            }

            var villaEntity = new Villa()
            {
                Name = villa.Name,
                Description = villa.Description,
                ImageUrl = villa.ImageUrl,
                Occupancy = villa.Occupancy,
                Price = villa.Price,
                Sqft = villa.Sqft
            };

            try
            {
                _unitOfWork.VillaRepository.Add(villaEntity);
                _unitOfWork.Save();
            }
            catch 
            {
                throw new Exception("Bir hata gerçekleşti");
            }

        }

        public bool DeleteVilla(int id)
        {
            try
            {
                Villa? data = _unitOfWork.VillaRepository.Get(u => u.Id == id);
                if (data is not null) 
                { 
                    _unitOfWork.VillaRepository.Remove(data);
                    _unitOfWork.Save();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IEnumerable<GetVillaDTO> GetAllVillas()
        {
            return _unitOfWork.VillaRepository.GetAll(tracked: true).Select(x => new GetVillaDTO { Id = x.Id, Name = x.Name, Description=x.Description, ImageUrl=x.ImageUrl, Occupancy = x.Occupancy, Sqft=x.Sqft, Price=x.Price });
        }

        public Villa GetVillaById(int id)
        {
            return _unitOfWork.VillaRepository.Get(x => x.Id == id);
        }

        public IEnumerable<GetVillaDTO> GetVillasAvailabilityByDate(int nights, DateOnly checkInDate)
        {
            throw new NotImplementedException();
        }

        public bool IsVillaAvailableByDate(int villaId, int nights, DateOnly checkInDate)
        {
            throw new NotImplementedException();
        }

        public void UpdateVilla(CreateVillaDTO villa, int id)
        {
            if (villa.ImageUrl != null)
            {
                string fileName = Guid.NewGuid().ToString() + Path.GetExtension(villa.Image.FileName);

                string imagePAth = Path.Combine(_webHostEnvironment.WebRootPath, @"images\VillaImage");

                using var fileStream = new FileStream(Path.Combine(imagePAth, fileName), FileMode.Create);

                villa.Image.CopyTo(fileStream);

                villa.ImageUrl = @"\images\VillaImage\" + fileName;
            }
            else
            {
                villa.ImageUrl = "https://via.placeholder.com/600x400";
            }

            var villaEntity = new Villa()
            {
                Id = id,
                Name = villa.Name,
                Description = villa.Description,
                ImageUrl = villa.ImageUrl,
                Occupancy = villa.Occupancy,
                Price = villa.Price,
                Sqft = villa.Sqft
            };

            try
            {
                _unitOfWork.VillaRepository.Update(villaEntity);
                _unitOfWork.Save();
            }
            catch
            {
                throw new Exception("Bir hata gerçekleşti");
            }
        }
    }
}
