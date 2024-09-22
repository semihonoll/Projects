using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_1_SingleOfResponsibility.GoodImplementation
{
    public class Employee
    {
        public Employee(string fullName, string dateOfJoing, double salary)
        {
            this.fullName = fullName;
            this.dateOfJoing = dateOfJoing;
            this.salary = salary;
        }

        private string fullName;

		public string FullName
		{
			get { return fullName; }
			set { fullName = value; }
		}

		private string dateOfJoing;

		public string DateOfJoing
		{
			get { return dateOfJoing; }
			set { dateOfJoing = value; }
		}

		private double salary;
        public double Salary
		{
			get { return salary; }
			set { salary = value; }
		}

	}
}
