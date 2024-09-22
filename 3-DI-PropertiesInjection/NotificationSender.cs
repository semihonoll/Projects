using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_DI_PropertiesInjection
{
    public class NotificationSender
    {
        public IMessageService _messageService { get; set; }
        public void Notify(string message)
        { 
            _messageService.SendMessage(message);
        }
    }
}
