using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_OOP_Class
{
    public class Araba
    {
        public string Marka;
        public string Model;
        public string Renk;

        public int Hız;

        public void GazVer()
        {
            Console.WriteLine(Marka + " Gaza Basıldı.");
            Hız += 10;
            Console.WriteLine(Marka + " Şuanki Hızı: " + Hız);
        }

        public void FrenYap()
        {
            Console.WriteLine("Fren Yapıldı");
        }
    }
}
