using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _94_DP_Mediator
{
    public abstract class User
    {
        protected string name;
        protected IChatMediator chatMediator;

        protected User(IChatMediator med, string name)
        {
            this.chatMediator = med;
            this.name = name;
        }

        public abstract void Send(string message);
        public abstract void Receive(string message);
    }
}
