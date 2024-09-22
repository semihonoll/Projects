using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39_OOP_InheritanceLab1
{
    public class SmartPhone : MobilPhone
    {
        public bool FrontCam { get; set; }

        public SmartPhone()
        {
            HasCamera = true;
            phoneType = "Akıllı Telefon";
        }

        public SmartPhone(string brand, string connectionType, bool isTouched, bool frontCam) : base(true, isTouched, brand, connectionType)
        {
            FrontCam = frontCam;
            phoneType = "Akıllı Telefon";
        }
        public string DoVideoCall() 
        {
            return "Görüntülü arama...";
        }

        public override string Call()
        {
            return "Mp3 Müzik Çalıyor...";
        }

        public override string ConnectionStatus()
        {
            return "5G Bağlantı mevcut...";
        }
    }
}
