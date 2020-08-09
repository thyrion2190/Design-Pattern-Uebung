using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPatternExample
{
    public class ChatMediatorImplementation : IChaMediator
    {
        private List<User> users;
        public ChatMediatorImplementation()
        {
            this.users = new List<User>();
        }
        public void AddUser(User user)
        {
            users.Add(user);
        }

        public void SendMessage(string message, User user)
        {
            foreach(User u in users)
            {
                if(u != user)
                {
                    u.ReceiveMessage(message);
                }
            }
        }
    }
}
