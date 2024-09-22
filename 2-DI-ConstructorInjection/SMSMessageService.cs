using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_DI_ConstructorInjection
{
    public class SMSMessageService : IMessageService
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"SMS gönderildi: {message}");
        }
    }
}
