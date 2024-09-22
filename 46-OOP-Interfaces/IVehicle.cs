using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _46_OOP_Interfaces
{
    //C#'da soyutlama elde etmenin en önemli yoludur (arayüzler)
    //Interface'de yalnızca soyut metotlar ve özellikler (boş gövdeli) içerebilen tamamen soyut bir yapıdır.
    //inheritince edildiğinde metotlarını uygulama zorunluluğu vardır.
    public interface IVehicle
    {
        string Brand { get; set; }
        string Model { get; set; }
        void Run();
    }
}
