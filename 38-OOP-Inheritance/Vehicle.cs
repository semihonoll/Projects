using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38_OOP_Inheritance
{
    public class Vehicle
    {
		//Base Class (Parent Class): miras/kalıtım alınan sınıf.
		public string deneme;
		private string brand;
		private string model;
		private string color;
        public Vehicle(string _brand)
        {
            Brand = _brand;
        }
        public string Color
		{
			get { return color; }
			set { color = value; }
		}

		public string Model
		{
			get { return model; }
			set { model = value; }
		}

		public string Brand
		{
			get { return brand; }
			set { brand = value; }
		}

		public void Start()
		{
            Console.WriteLine("Araç çalışmaya başladı...");
        }

		public void Stop()
		{
            Console.WriteLine("Araç durdu...");
        }

	}
}
