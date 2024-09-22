using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _93_DP_Proxy
{
    public class CommandExecutorProxy : ICommandExecutor
    {
        private bool isAdmin;
        private ICommandExecutor executor;

        public CommandExecutorProxy(string user, string pwd)
        {
            if (user == "admin" && pwd == "123")
            {
                isAdmin = true;
                executor = new CommandExecutor();
            }
        }

        public void RunCommand(string cmd)
        {
            if (isAdmin)
            {
                executor.RunCommand(cmd);
            }
            else 
            {
                Console.WriteLine("This comman is not allowed for non-admin users");
            }
        }
    }
}
