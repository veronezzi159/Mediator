using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorEX
{
    public class ConcreteMediator : Mediator
    {
        private List<User> usersList = new List<User> ();
        public void RegisterUser(User user )
        {
            usersList.Add (user);
        }

        public void SendMessage(string Message, User user)
        {
            foreach (var u in usersList)
            {
                if (u != user)
                    u.Recive(Message);
            }
        }
    }
}
