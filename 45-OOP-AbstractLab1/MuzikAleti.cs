using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _45_OOP_AbstractLab1
{
    public abstract class MuzikAleti
    {
        public string Markasi { get; set; }
        public string Modeli { get; set; }

        public abstract string Cal();
    }
}
