using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _47_OOP_Interfaces2
{
    public class Forvet : IFutbolcu
    {
        public string AdiSoyadi { get; }
        public string FormaNumarasi { get; }
        public int SutGucu { get; set; }
        public int PasGucu { get; set; }
        public int Agresiflik { get; set; }

        public void PasAt()
        {
            Console.WriteLine("Pas Atıldı...");
        }

        public void SutCek()
        {
            Console.WriteLine("Şut Çekildi...");
        }
    }
}
