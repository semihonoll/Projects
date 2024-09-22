using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _90_DP_Prototype
{
    //Build in Interface
    public class Employee : ICloneable
    {
        private List<string> empList;
        public Employee()
        {
            empList = new List<string>();
        }
        public Employee(List<string> empList)
        {
            this.empList = empList;
        }

        public void LoadData()
        {
            empList.Add("Fatih");
            empList.Add("Okan");
            empList.Add("Onur");
            empList.Add("Yasin");
            empList.Add("Gülderen");
        }

        public List<string> GetEmpList()
        { 
            return empList; 
        }

        public object Clone()
        {
            List<string> temp = new List<string>();
            foreach (var item in GetEmpList())
            {
                temp.Add(item);
            }

            return new Employee(temp);
        }
    }
}
