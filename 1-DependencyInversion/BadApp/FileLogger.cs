using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DependencyInversion.BadApp
{
    public class FileLogger
    {
        public void LogInfo(string message)
        {
            //Log messsage to a file.
        }

        public void LogWarning(string message) 
        {
        
        }
    }
}
