using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_2_OpenClose.GoodImplementation
{
    public interface IEmpSalary
    {
        double calculeteSalary(Employee employee, int day);
    }
}
