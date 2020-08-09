using System;
using System.Runtime.CompilerServices;

namespace ObserverPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            SportNewsletter sportNewsletter = new SportNewsletter(new Newsletter("Test", "Content..."));
            Person person1 = new Person("Tim");
            Person person2 = new Person("Struppi");
            Person person3 = new Person("Steffan");

            sportNewsletter.Subscribe(person1);
            sportNewsletter.Subscribe(person2);
            sportNewsletter.SetNewsletter(new Newsletter("New Test", "Content..."));

            sportNewsletter.Unsubscribe(person1);
            sportNewsletter.Subscribe(person3);

            sportNewsletter.SetNewsletter(new Newsletter("bla", "IsByRefLikeAttribute"));
            Console.ReadLine();
        }
    }
}
