using _56_Entity_LINQ.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _56_Entity_LINQ
{
    public class StudenEqualityComparer : IEqualityComparer<Student>
    {
        public bool Equals(Student? x, Student? y)
        {
            return x.Id == y.Id;
        }

        public int GetHashCode([DisallowNull] Student obj)
        {
            return obj.Id.GetHashCode();
        }
    }
}
