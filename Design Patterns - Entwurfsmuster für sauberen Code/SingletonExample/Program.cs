using System;

namespace SingletonExample
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicSingleton basicSingletonOne = BasicSingleton.GetInstance();
            // There is only one Referenc to one Object
            BasicSingleton basicSingletonTwo = BasicSingleton.GetInstance();

            LazySingleton lazySingletonOne = LazySingleton.GetInstance();
            Console.ReadKey();
        }
    }
}
