using School.Manager.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Manager.Entities
{
    public class Student : BaseEntity
    {
        public string Class { get; set; }
        public override string GetInformation()
        {
            return $"ID: {Id}, Name: {FirstName} {LastName}, Age: {Age} Class: {Class}";
        }
    }
}
