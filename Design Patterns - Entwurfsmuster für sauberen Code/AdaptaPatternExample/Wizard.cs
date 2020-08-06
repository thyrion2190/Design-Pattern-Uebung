using System;
using System.Collections.Generic;
using System.Text;

namespace AdaptaPatternExample
{
    public class Wizard 
    {
        public void AttackPlayer()
        {
            Console.WriteLine("Wizard attckes you");
        }

        public void Communicate()
        {
            Console.WriteLine("Wizard say: Hello");
        }

        public void Rest()
        {
            Console.WriteLine("Wizard sleep for 1 Minute");
        }
    }
}
