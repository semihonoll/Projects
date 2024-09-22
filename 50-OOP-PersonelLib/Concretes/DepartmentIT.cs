using _50_OOP_PersonelLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _50_OOP_PersonelLib.Concretes
{
    public class DepartmentIT : Department
    {
        public DepartmentIT(int id, string name) : base(id, name)
        {
            Employees = new List<Employee>();
        }

        public List<Employee> Employees { get; set; }
        public override void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
            employee.Department = this;
        }

        public override void RemoveEmployee(Employee employee)
        {
            if (Employees.Contains(employee))
            {
                Employees.Remove(employee);
                employee.Department = null;
            }
            throw new Exception("Böyle işçi benim listemde yok.");
        }

        public override string ToString()
        {
            string info = $"Department: {Id} Name: {Name} \n\t Employees";
            string employees="";
            foreach (var item in Employees)
            {
                employees += $"\tId: {item.Id} Name: {item.FirstName} {item.LastName}\n";
            }

            return info + employees;
        }
    }
}
