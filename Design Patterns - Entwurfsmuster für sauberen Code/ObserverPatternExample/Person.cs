using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPatternExample
{
    public class Person : INewsletterObserver
    {
        private string name;
        private Newsletter currentNewsletter;

        public Person(string name)
        {
            this.name = name;
        }

        public void Update(Newsletter newsletter)
        {
            currentNewsletter = newsletter;
            Console.WriteLine("The Person " + name + "has got the " + currentNewsletter.Topic);
        }
    }
}
