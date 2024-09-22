using _50_OOP_PersonelLib.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _50_OOP_PersonelLib.Interfaces
{
    public interface ICompany
    {
        List<Department> GetDepartments();
        List<Employee> GetEmployees();
        void AddDepartment(Department department);
        void AddEmployee(Employee employee);

    }
}
