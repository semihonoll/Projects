using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_4_InterfaceSegregation.Good
{
    public class Aeroplane : IVehicle, IFlyable
    {
        public void Accelerate()
        {
            throw new NotImplementedException();
        }

        public void ApplyBrakes()
        {
            throw new NotImplementedException();
        }

        public void fly()
        {
            throw new NotImplementedException();
        }
    }
}
