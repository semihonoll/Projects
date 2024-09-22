using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _49_OOP_Generic
{
    public class PrintData<T> where T : Person
    {
        public T[] Values = new T[10];

        private T data;
        public T Data 
        {
            get { return data; } 
            set { data = value; }
        }

        public PrintData(T _data)
        {
            data = _data;
        }

        public void Print(T data) 
        {
            Console.WriteLine(data.ToString());
        }

        public T Print2()
        { 
            return Data;
        }
    }
}
