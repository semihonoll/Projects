using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39_OOP_InheritanceLab1
{
    public class MobilPhone : Phone
    {
        public bool HasCamera { get; set; }
        public bool IsTouched { get; set; }

        public MobilPhone()
        {
            phoneType = "Mobil Telefon";
        }

        public MobilPhone(bool hasCamera, bool isTouched, string brand, string connectionType) : base(brand, connectionType)
        { 
            HasCamera = hasCamera;
            IsTouched = isTouched;
            phoneType = "Mobil Telefon";
        }

        public string TakePhoto() 
        {
            if (this.HasCamera)
                return "Fotoğraf çekebilir...";
            else
                return "Kamera özelliği yok";
        }

        public override string Call()
        {
            return "Poliformik müzik çalıyor...";
        }

        public override string ConnectionStatus()
        {
            return "3G Bağlantısı mevcut...";
        }
    }
}
