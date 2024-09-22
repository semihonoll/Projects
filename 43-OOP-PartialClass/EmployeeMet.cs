using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43_OOP_PartialClass
{
    public partial class Employee
    {
        public Employee(int id, string name)
        {
            EmpId = id;
            EmpName = name;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Isci Id: {EmpId} Isci Adı: {EmpName}");
        }
    }
}
