using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonExample
{
    public class BasicSingleton
    {
        private static readonly BasicSingleton instance = new BasicSingleton();

        private BasicSingleton()
        {
            Console.WriteLine("der BasicSingleton wurder erstellt");
        }

        public static BasicSingleton GetInstance()
        {
            return instance;
        }
    }
}
