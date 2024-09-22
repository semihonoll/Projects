using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_5_DependencyInversion.Good
{
    public class SqlRepo : IRepository
    {
        public void Add()
        {
            Console.WriteLine("Sql ile kayıt işlemi yapıldı...");
        }

        public void Delete()
        {
            Console.WriteLine("Sql ile silme işlemi yapıldı...");
        }

        public void Update()
        {
            Console.WriteLine("Sql ile güncelleme işlemi yapıldı...");
        }
    }
}
