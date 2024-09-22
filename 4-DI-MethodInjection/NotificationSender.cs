using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_DI_MethodInjection
{
    public class NotificationSender
    {
        public void Notify(string message, IMessageService _messageService) 
        { 
            _messageService.SendMessage(message);
        }
    }
}
