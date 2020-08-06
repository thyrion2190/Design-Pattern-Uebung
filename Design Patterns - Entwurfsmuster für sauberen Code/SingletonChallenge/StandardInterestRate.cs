using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonChallenge
{
    public class StandardInterestRate
    {
        private static StandardInterestRate instance;
        private static object lockObject = new object();
        public double InterestRate { get; set; }

        private StandardInterestRate()
        {
            InterestRate = 3.0;
        }

        public static StandardInterestRate GetInstance()
        {
            lock (lockObject)
            {
                if (instance == null)
                    instance = new StandardInterestRate();
            }
            return instance;
        }
    }
}
