using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_2_OpenClose.GoodImplementation
{
    public class EmployeeKadrolu : IEmpSalary
    {
        public double Bonus { get; set; }
        public double calculeteSalary(Employee employee, int day)
        {
            return (day * 300) * Bonus;
        }
    }
}
