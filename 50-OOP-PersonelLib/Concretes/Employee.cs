using _50_OOP_PersonelLib.Enums;
using _50_OOP_PersonelLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _50_OOP_PersonelLib.Concretes
{
    public class Employee : IEmployee
    {
        private string _firstName;
        private string _lastName;
        public Employee(string firstName, string lastName)
        {
            Random random = new Random();
            Id = random.Next(0,100);

            _firstName = firstName;
            _lastName  = lastName;
        }
        public int Id { get; set; }
        public string FirstName 
        {
            get { return _firstName; }
            set { _firstName = value; } 
        }
        public string LastName 
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public string Title { get; set; }
        public double Salary { get; set; }
        public Department Department { get; set; }

        public double CalculateSalary(double day, double pay, DepartmentType type)
        {
            double salary = day * pay;
            if (type == DepartmentType.HumanRes)
                salary += 5000;
            else if (type == DepartmentType.IT)
                salary += 3000;
            else if (type == DepartmentType.Software)
                salary += 7000;
            else
                throw new Exception("Böyle bir departmanımız yok...");
            Salary = salary;
            return salary;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {FirstName} {LastName} Titler: {Title} Salary: {Salary} Department: {Department.Name}";
        }
    }
}
