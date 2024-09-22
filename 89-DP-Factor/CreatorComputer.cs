using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _89_DP_Factor
{
    public abstract class CreatorComputer
    {
        public abstract string GetRAM();
        public abstract string GetHDD();
        public abstract string GetCPU();

        public override string ToString()
        {
            return "RAM: " + GetRAM() + ", HDD: " + GetHDD() + ", CPU: " + GetCPU();
        }
    }
}
