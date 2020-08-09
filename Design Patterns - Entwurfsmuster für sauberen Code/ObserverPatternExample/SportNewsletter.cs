using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPatternExample
{
    public class SportNewsletter : NewsletterSubject
    {
        private Newsletter currentNewsletter;

        public SportNewsletter(Newsletter newsletter)
        {
            this.currentNewsletter = newsletter;
        }

        public Newsletter GetNewsletter()
        {
            return currentNewsletter;
        }
        public void SetNewsletter(Newsletter newNewsletter)
        {
            currentNewsletter = newNewsletter;
            Console.WriteLine("There is a new Newsletter");
            SendNewsletter(currentNewsletter);
        }
    }
}
