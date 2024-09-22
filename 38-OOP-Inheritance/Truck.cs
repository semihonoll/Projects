using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38_OOP_Inheritance
{
    public class Truck : Vehicle
    {
		private int maxWeight;

        public Truck(string _brand) : base(_brand)
        {
        }

        public int MaxWeight
		{
			get { return maxWeight; }
			set { maxWeight = value; }
		}


	}
}
