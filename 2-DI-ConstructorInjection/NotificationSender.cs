using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_DI_ConstructorInjection
{
    public class NotificationSender
    {
        private readonly IMessageService _messageService;

        public NotificationSender(IMessageService messageService)
        {
            _messageService = messageService;
        }
        public void Notify(string message)
        { 
            _messageService.SendMessage(message);
        }
    }
}
