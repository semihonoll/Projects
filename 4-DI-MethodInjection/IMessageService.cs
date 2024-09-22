using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_DI_MethodInjection
{
    public interface IMessageService
    {
        void SendMessage(string message);
    }
}
