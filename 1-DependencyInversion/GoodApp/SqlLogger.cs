using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DependencyInversion.GoodApp
{
    public class SqlLogger : ILogger
    {
        public void Log(string message)
        {
            //Log message to Sql
        }
    }
}
