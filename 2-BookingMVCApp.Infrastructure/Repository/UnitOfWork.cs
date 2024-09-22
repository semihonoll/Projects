using _2_BookingMVCApp.Infrastructure.Data;
using _3_BookingMVCApp.Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BookingMVCApp.Infrastructure.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        public IVillaRepository VillaRepository { get; private set; }

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
            VillaRepository = new VillaRepository(_context);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
