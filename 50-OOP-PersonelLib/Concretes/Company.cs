using _50_OOP_PersonelLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _50_OOP_PersonelLib.Concretes
{
    public class Company : ICompany
    {
        public List<Department> departments = new List<Department>();
        public List<Employee> employees = new List<Employee>();
        public void AddDepartment(Department department)
        {
            departments.Add(department);
        }

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        public List<Department> GetDepartments()
        {
            return departments;
        }

        public List<Employee> GetEmployees()
        {
            return employees;
        }
    }
}
