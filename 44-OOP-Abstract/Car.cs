using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _44_OOP_Abstract
{
    public class Car : Vehicle
    {
        public Car(string _brand) : base(_brand)
        {
        }

        public override void Calistir()
        {
            Console.WriteLine("Araba Çalıştı...");
        }
    }
}
