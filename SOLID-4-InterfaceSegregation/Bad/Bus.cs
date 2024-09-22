using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_4_InterfaceSegregation.Bad
{
    public class Bus : IVehicle
    {
        public void Accelerate()
        {
            //...
        }

        public void ApplyBrakes()
        {
            //...
        }

        public void Fly()
        {
            throw new NotImplementedException();
        }
    }
}
