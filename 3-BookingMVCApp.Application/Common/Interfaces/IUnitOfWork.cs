using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_BookingMVCApp.Application.Common.Interfaces
{
    public interface IUnitOfWork
    {
        IVillaRepository VillaRepository { get; }
        void Save();
    }
}
