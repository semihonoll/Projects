using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SOLID_1_SingleOfResponsibility.BadImplementation
{
    public class Employee
    {
        //Core-Entity-Model
        private string fullName;
        private string dateOfJoing;
        private double salary;

        //Business-Services
        public double CalculateEmployeeSalary { get; set; }
        public double CalculateEmployeeSalaryTax { get; set; }

        //DAL-Repo
        public void SaveEmployee() 
        { 
        
        }

        public void UpdateEmployee() 
        { 
            
        }
    }
}
