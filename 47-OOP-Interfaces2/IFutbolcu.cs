using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _47_OOP_Interfaces2
{
    public interface IFutbolcu
    {
        string AdiSoyadi { get; }
        string FormaNumarasi { get; }
        int SutGucu { get; set; }
        int PasGucu { get; set; }
        int Agresiflik { get; set; }
        void SutCek();
        void PasAt();
    }
}
