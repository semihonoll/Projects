using School.Manager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Manager.Services
{
    public interface IStudentService : IService<Student>
    {
        void GetByClassName(string className);
    }
}
