using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_OOP_Static
{
    public static class FizikKutuphanesi
    {
        private static double piSayisi = 3.14;
        public static void CemberinAlani(double r)
        {
            Console.WriteLine($"Cemberin Alanı: {piSayisi*r*r}");
        }
    }
}
