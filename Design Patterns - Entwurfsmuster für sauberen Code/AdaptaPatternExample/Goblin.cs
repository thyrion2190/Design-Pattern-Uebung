using System;
using System.Collections.Generic;
using System.Text;

namespace AdaptaPatternExample
{
    public class Goblin : IEnemyObject
    {
        public void Attack()
        {
            Console.WriteLine("Goblin attacked");
        }

        public void SayHello()
        {
            Console.WriteLine("Goblin say: Hello Player");
        }

        public void Sleep()
        {
            Console.WriteLine("Goblin sleep for 5 Minutes");
        }
    }
}
