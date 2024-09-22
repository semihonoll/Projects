using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _46_OOP_Interfaces
{
    public class Ship : IVehicle
    {
        public string Brand { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Model { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Run()
        {
            throw new NotImplementedException();
        }
    }
}
