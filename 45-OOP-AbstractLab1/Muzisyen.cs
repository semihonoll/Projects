using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _45_OOP_AbstractLab1
{
    public class Muzisyen
    {
        public string Adi { get; set; }
        public string Soyadı { get; set; }

        //Navigation Property
        public MuzikAleti MuzikAleti { get; set; }

    }
}
