using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42_OOP_Polymorphism
{
    public class Samsung : BasePhone
    {
        public override void CallSound()
        {
            Console.WriteLine("Samsung Müziği Çalıyor...");
        }
    }
}
