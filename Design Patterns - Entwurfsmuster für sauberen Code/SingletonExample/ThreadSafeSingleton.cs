using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonExample
{
    //LazySingleton with Threadsecurity
    public class ThreadSafeSingleton
    {
        private static ThreadSafeSingleton instance;
        private static object lockObject = new object();

        private ThreadSafeSingleton()
        {
            Console.WriteLine("der ThreadSafeSingleton wurder erstellt");
        }

        public static ThreadSafeSingleton GetInstance()
        {
            lock (lockObject)
            {
                if (instance == null)
                    instance = new ThreadSafeSingleton();
            }
            return instance;
        }

    }
}
