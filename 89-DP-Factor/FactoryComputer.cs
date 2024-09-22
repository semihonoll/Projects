using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _89_DP_Factor
{
    public class FactoryComputer
    {
        public static CreatorComputer FactoryMethod(string ram, string hdd, string cpu, Model model)
        {
            if (model == Model.GamePC)
            {
                return new ConcreateCreatorGamePC(ram, hdd, cpu);
            }
            else if (model == Model.DeveloperPC)
            {
                return new ConcreateCreatorDeveloperPC(ram, hdd, cpu);
            }
            else if (model == Model.OfficePC)
            { 
                return new ConcreateCreatorOfficePC(ram, hdd, cpu);
            }
            else
            {
                return null;
            }
        }
    }
}
