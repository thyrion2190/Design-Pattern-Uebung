using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DecoratorPatternExample
{
    public class MacBookPro : IMacBook
    {
        public string GetDescription()
        {
            return "MacBook Pro with Standardsystem";
        }

        public double GetPrice()
        {
            return 1199.99;
        }

        public void IncreaseVolume()
        {
            Console.WriteLine("The Volume was increased");
        }
    }
}
