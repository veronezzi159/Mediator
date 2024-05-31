using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorEX
{
    public class ConcreteUser : User
    {
        public ConcreteUser(ConcreteMediator mediator, string name)
            : base(mediator, name) { }

        public override void Recive(string message)
        {
            Console.WriteLine($"{username} : recebida <= {message}");
        }

        public override void Send(string message)
        {
            Console.WriteLine($"{username} : enviada => {message}");
            Console.WriteLine();
            mediator.SendMessage(message,this);
        }
    }
}
