using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_2_OpenClose.BadImplementation
{
    public class EmployeeSalary
    {
        public Double CalculateSalary(Employee employee, int day, double bonus)
        {
            double salary = 0;
            if (employee.Type == "Kadrolu") 
            { 
                salary = (day * 300) + bonus;
            }
            if (employee.Type == "Sozlesmeli")
            {
                salary = day * 150;
            }
            return salary;
        }
    }
}
