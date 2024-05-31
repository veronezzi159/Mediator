using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorEX
{
    public abstract class User
    {
        protected ConcreteMediator mediator;
        protected string username;

        public User(ConcreteMediator mediator, string name) 
        {
            this.mediator = mediator;
            this.username = name;
        }
        public abstract void Send(string message);

        public abstract void Recive(string message);
    }
}
