using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_3_LiscovSubstitution.GoodImplementation
{
    public class Truck : StandartCar
    {
        public override void Run()
        {
            base.Run();
        }

        public override void Wheels()
        {
            base.Wheels();
        }

        public override void Fuel()
        {
            base.Fuel();
        }
    }
}
