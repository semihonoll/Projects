using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_4_InterfaceSegregation.Good
{
    public class Bus : IVehicle
    {
        public void Accelerate()
        {
            throw new NotImplementedException();
        }

        public void ApplyBrakes()
        {
            throw new NotImplementedException();
        }
    }
}
