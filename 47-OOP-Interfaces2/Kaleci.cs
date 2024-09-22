using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _47_OOP_Interfaces2
{
    public class Kaleci : IFutbolcu, IKaleci
    {
        private int _sutGucu;
        public string AdiSoyadi { get; }
        public string FormaNumarasi { get; }
        public int SutGucu 
        {
            get { return _sutGucu; }
            set {
                if (value < 50)
                    _sutGucu = value;
                else
                    throw new Exception("Kalecinin şut gücü 50 den fazla olamaz...");
            }
        }
        public int PasGucu { get; set; }
        public int Agresiflik { get; set; }

        public void DegajDik()
        {
            Console.WriteLine("Degaj dikildi...");
        }

        public void PasAt()
        {
            Console.WriteLine("Pas atıldı...");
        }
        public void SutCek()
        {
            Console.WriteLine("Şut çekildi...");
        }

        public void TopKurtar()
        {
            Console.WriteLine("Pas dikildi...");
        }
    }
}
