using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_OOP_Static
{
    public class Person
    {
        private static int count;

        public Person()
        {
            count++;
        }
        public static int KatSayi { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }

        public int Count 
        {
            get { return count; }
        }

        public void MaasHesapla(double calismaSaati)
        {
            Console.WriteLine($"Maaşınız: {calismaSaati * KatSayi}");
        }

        public static void BilgiVer()
        {
            Console.WriteLine("Merhaba Dünya");
        }
    }
}
