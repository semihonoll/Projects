using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38_OOP_Inheritance
{
    public class Car : Vehicle
    {
		//Sub Class (Child Class): miras/kalıtım alan sınıf.
		private bool childSeat;
		public Car(string brand, bool childSeat) : base(brand)
		{
			this.childSeat = childSeat;
		}

		public bool ChildSeat
		{
			get { return childSeat; }
			set { childSeat = value; }
		}

	}
}
