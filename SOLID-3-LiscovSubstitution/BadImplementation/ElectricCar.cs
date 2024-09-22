using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_3_LiscovSubstitution.BadImplementation
{
    public class ElectricCar : BaseCar
    {
        public override void Wheels()
        {
            base.Wheels();
        }

        public override void Run()
        {
            base.Run();
        }

        public override void Fuel()
        {
            throw new Exception("Not supported");
        }
    }
}
