using System;

namespace MediatorPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ChatMediatorImplementation chat = new ChatMediatorImplementation();
            UserImplementation user1 = new UserImplementation("Test", chat);
            UserImplementation user2 = new UserImplementation("Test2", chat);
            UserImplementation user3 = new UserImplementation("Test3", chat);
            chat.AddUser(user1);
            chat.AddUser(user2);
            chat.AddUser(user3);
            user3.SendMessage("Hello all.");
            Console.ReadLine();
        }
    }
}
