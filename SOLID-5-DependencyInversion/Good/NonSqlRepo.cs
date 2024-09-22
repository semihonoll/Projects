using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_5_DependencyInversion.Good
{
    public class NonSqlRepo : IRepository
    {
        public void Add()
        {
            Console.WriteLine("NonSql bir veritabanı ile ekledim.");
        }

        public void Delete()
        {
            Console.WriteLine("NonSql bir veritabanı ile sildim.");
        }

        public void Update()
        {
            Console.WriteLine("NonSql bir veritabanı ile güncelledim.");
        }
    }
}
