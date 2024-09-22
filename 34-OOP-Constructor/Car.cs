using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34_OOP_Constructor
{
    public class Car
    {
		//Fields
		private string brand;
		private string model;
		private int fuel;


        //Constructors (Yapıcı Metot)
		/*
		 -Varsayılan Constructor Otomatik olarak oluşur.
		 -Birden Fazla Constructor oluşturabilirsiniz. (Metot Overloading)
		 */
		/// <summary>
		/// 
		/// </summary>
        public Car()
        {
            
        }
		/// <summary>
		/// 
		/// </summary>
		/// <param name="_brand"></param>
        public Car(string _brand)
		{
			if (!string.IsNullOrEmpty(_brand))
			{
                brand = _brand;
            }
		}

		public Car(string _brand, int _fuel)
		{
			Brand = _brand;
			Fuel = _fuel;
		}

		//Properties
		public int Fuel
		{
			get { return fuel; }
			set { fuel = value; }
		}
		public string Model
		{
			get { return model; }
			set 
			{
				if (!string.IsNullOrEmpty(value))
				{
                    model = value;
                }
				else
				{
                    Console.WriteLine("Geçersiz marka değeri...");
                }
			}
		}
		public string Brand
		{
			get { return brand; }
			set 
			{
                if (!string.IsNullOrEmpty(value))
                {
                    brand = value;
                }
                else
                {
                    Console.WriteLine("Geçersiz marka değeri...");
                }
            }
		}

	}
}
