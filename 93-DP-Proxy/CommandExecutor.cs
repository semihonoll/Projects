using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _93_DP_Proxy
{
    public class CommandExecutor : ICommandExecutor
    {
        public void RunCommand(string cmd)
        {
            Console.WriteLine(cmd + " command executed.");
        }
    }
}
