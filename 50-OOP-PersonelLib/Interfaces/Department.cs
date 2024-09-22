using _50_OOP_PersonelLib.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _50_OOP_PersonelLib.Interfaces
{
    public abstract class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public abstract void AddEmployee(Employee employee);
        public abstract void RemoveEmployee(Employee employee);
    }
}
