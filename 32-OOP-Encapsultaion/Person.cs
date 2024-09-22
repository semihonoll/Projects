using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_OOP_Encapsultaion
{
    public class Person
    {

        //Field
        private string sicilNo;
        public Person()
        { 
            sicilNo = Guid.NewGuid().ToString().Substring(0, 5);
        }

        //Properties
        //Sadece Okunabilir ReadOnly
        public string SicilNo 
        {
            get { return sicilNo.ToUpper(); }
            //private set { sicilNo = value; }
        }

        private double saatlikUcret;

        //Sadece Yazılabilir WriteOnly
        public double SaatlikUcret
        {
            private get { return saatlikUcret; }
            set 
            {
                if (value>0)
                {
                    saatlikUcret = value;
                }
                else
                {
                    throw new Exception("Saatlik ücret 0 dan küçük olamaz.");
                }
            }
        }

        //Hem okunabilir hem yazılabilir.
        private string adi;

        public string Adi
        {
            get { return adi; }
            set { adi = value; }
        }

        public string Soyad { get; set; }

        public string TamAd 
        {
            get {
                return adi + " " + Soyad;
            }
        }

        private void BilgiYaz() 
        {
            Console.WriteLine("Maaşınız Hesaplanıyor...");
        }

        public void MaasHesapla(double calismaSaati)
        {
            BilgiYaz();
            double maas = calismaSaati * saatlikUcret;
            Console.WriteLine("Personelin Maaşı: " + maas);
        }
    }
}
