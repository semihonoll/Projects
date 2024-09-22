using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _89_DP_Factor
{
    public class ConcreateCreatorGamePC : CreatorComputer
    {
        private string ram;
        private string hdd;
        private string cpu;

        public ConcreateCreatorGamePC(string ram, string hdd, string cpu)
        {
            this.ram = ram;
            this.hdd = hdd;
            this.cpu = cpu;
        }

        public override string GetCPU()
        {
            return cpu;
        }

        public override string GetHDD()
        {
            return hdd;
        }

        public override string GetRAM()
        {
            return ram;
        }
    }
}
