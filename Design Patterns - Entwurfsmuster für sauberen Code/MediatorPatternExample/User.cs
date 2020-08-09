using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPatternExample
{
    public abstract class User
    {
        public IChaMediator Mediator { get; set; }
        public string Name { get; set; }

        public User(string name, IChaMediator mediator)
        {
            this.Name = name;
            this.Mediator = mediator;
        }
        public abstract void SendMessage(string message);
        public abstract void ReceiveMessage(string message);
    }
}
