using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _94_DP_Mediator
{
    public class ChatMediator : IChatMediator
    {
        private List<User> users;

        public ChatMediator()
        {
            this.users = new List<User>();
        }

        public void AddUser(User user)
        {
            this.users.Add(user);
        }

        public void SendMessage(string message, User user)
        {
            foreach (var u in this.users) 
            {
                if (u != user)
                {
                    u.Receive(message);
                }
            }
        }
    }
}
