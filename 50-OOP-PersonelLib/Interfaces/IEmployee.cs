using _50_OOP_PersonelLib.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _50_OOP_PersonelLib.Interfaces
{
    public interface IEmployee
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string Title { get; set; }
        double Salary { get; set; }
        double CalculateSalary(double day, double pay, DepartmentType type);
    }
}
