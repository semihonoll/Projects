using _1_BookingMVCApp.Domain.Entities;
using _2_BookingMVCApp.Infrastructure.Data;
using _3_BookingMVCApp.Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BookingMVCApp.Infrastructure.Repository
{
    public class VillaRepository : Repository<Villa>, IVillaRepository
    {
        private readonly AppDbContext _context;
        public VillaRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public void Update(Villa villa)
        {
            _context.Villas.Update(villa);
        }
    }
}
