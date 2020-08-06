using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPatternExample
{
    public class MacBookAir : IMacBook
    {
        public string GetDescription()
        {
            return "MacBook Air with Standardsystem";
        }

        public double GetPrice()
        {
            return 799.99;
        }

        public void IncreaseVolume()
        {
            Console.WriteLine("The Volume was increased");
        }
    }
}
