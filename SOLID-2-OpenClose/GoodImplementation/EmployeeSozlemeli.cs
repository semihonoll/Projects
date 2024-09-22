using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_2_OpenClose.GoodImplementation
{
    public class EmployeeSozlemeli : IEmpSalary
    {
        public double calculeteSalary(Employee employee, int day)
        {
            return day * 150;
        }
    }
}
