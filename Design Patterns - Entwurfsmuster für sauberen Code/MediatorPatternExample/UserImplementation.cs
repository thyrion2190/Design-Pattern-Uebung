using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPatternExample
{
    public class UserImplementation : User
    {
        public UserImplementation(string name, IChaMediator mediator) : base(name, mediator)
        {
        }

        public override void ReceiveMessage(string message)
        {
            Console.WriteLine(Name + " has got a message: " + message);
        }

        public override void SendMessage(string message)
        {
            Console.WriteLine(Name + ": " + message);
            Mediator.SendMessage(message, this);
        }
    }
}
