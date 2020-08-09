using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPatternExample
{
    public interface IChaMediator
    {
        void SendMessage(string message, User user);
        void AddUser(User user);
    }
}
