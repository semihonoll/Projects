using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _47_OOP_Interfaces2
{
    public class Defans : IFutbolcu
    {
        private string _adiSoyad;
        private string _formaNumarasi;
        private int _sutGucu;
        public Defans(string adiSoyad, string formaNumarasi)
        {
            _adiSoyad = adiSoyad;
            _formaNumarasi = formaNumarasi;
        }
        public string AdiSoyadi 
        { 
            get => _adiSoyad; 
        }
        public string FormaNumarasi
        {
            get { return _formaNumarasi; }
        }
        public int SutGucu 
        {
            get { return _sutGucu; }
            set {
                if (value < 70)
                    _sutGucu = value;
                else
                    throw new Exception("Defansın şut gücü 70 den yüksek olamaz");
            }
        }
        public int PasGucu { get; set; }
        public int Agresiflik { get; set; }
        public void PasAt()
        {
            Console.WriteLine("Pas atıldı...");
        }
        public void SutCek()
        {
            Console.WriteLine("Şut çekildi...");
        }
    }
}
