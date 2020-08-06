using System;

namespace AdaptaPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnemyObject goblin = new Goblin();
            goblin.SayHello();
            goblin.Attack();
            goblin.Sleep();

            Wizard wizard = new Wizard();
            IEnemyObject adapter = new Adapter(wizard);
            adapter.Attack();
            adapter.SayHello();
            adapter.Sleep();

            Console.ReadLine();
        }
    }
}
