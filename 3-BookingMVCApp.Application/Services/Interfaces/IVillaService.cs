using _1_BookingMVCApp.Domain.Entities;
using _3_BookingMVCApp.Application.Common.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_BookingMVCApp.Application.Services.Interfaces
{
    public interface IVillaService
    {
        IEnumerable<GetVillaDTO> GetAllVillas();
        Villa GetVillaById(int id);
        void CreateVilla(CreateVillaDTO villa);
        void UpdateVilla(CreateVillaDTO villa, int id);
        bool DeleteVilla(int id);

        IEnumerable<GetVillaDTO> GetVillasAvailabilityByDate(int nights, DateOnly checkInDate);
        bool IsVillaAvailableByDate(int villaId, int nights, DateOnly checkInDate);
    }
}
