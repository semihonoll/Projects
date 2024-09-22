using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _49_OOP_Generic
{
    public interface Interface1<T>
    {
        void Create(T obj);
        void Delete(T obj);
        void Update(T obj);
    }
}
