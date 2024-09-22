using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _46_OOP_Interfaces
{
    public class Vehicle : IVehicle
    {
        private string _brand;
        public string Brand 
        {
            get { return _brand; }
            set { _brand = value; } 
        }
        public string Model { get; set; }

        public void Run()
        {
            Console.WriteLine("Araç Çalıştı");
        }
    }
}
