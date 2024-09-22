using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43_OOP_PartialClass
{
    public class Isci
    {
        public int IsciId { get; set; }
        public string IsciAdi { get; set; }

        public Isci(int id, string adi)
        {
            IsciId = id;
            IsciAdi = adi;
        }

        public void BilgiGoster()
        {
            Console.WriteLine($"Isci Id: {IsciId} Isci Adı: {IsciAdi}");
        }
    }
}
