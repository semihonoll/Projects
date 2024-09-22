using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _44_OOP_Abstract
{
    public abstract class Vehicle
    {
		private string brand;

		public string Brand
		{
			get { return brand; }
			set { brand = value; }
		}

        public Vehicle(string _brand)
        {
            Brand = _brand;
        }

        public abstract void Calistir();

        //Abstract Metodun kuralları
        /*
         1) Private olamaz.
         2) Abstract metot sadece Abstract class içinde tanımlanır.
         3) Abstract metota virtual kelimesi yazılamaz.
         4) Abstract metot static olarak tanımlanamaz.
         5) Abstract metotların gövdesi olamaz.
         */
    }
}
