using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _94_DP_Mediator
{
    public class UserImp : User
    {
        public UserImp(IChatMediator med, string name):base(med, name)
        {
            
        }
        public override void Receive(string message)
        {
            Console.WriteLine($"{name} Received Message: {message}");
            
        }

        public override void Send(string message)
        {
            Console.WriteLine($"{name} Sending Message: {message}");
            chatMediator.SendMessage(message, this);
        }
    }
}
