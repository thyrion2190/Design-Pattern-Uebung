using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonExample
{
    public class LazySingleton
    {
        private static LazySingleton instance;

        private LazySingleton()
        {
            Console.WriteLine("der LazySingleton wurder erstellt");
        }

        public static LazySingleton GetInstance()
        {
            if (instance == null)
                instance = new LazySingleton();

            return instance;
        }
    }
}
