using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPatternExample
{
    public class MacBookTouchbar : MacBookAddon
    {
        public MacBookTouchbar(IMacBook macBook) : base(macBook)
        {
        }

        public override string GetDescription()
        {
            return macBook.GetDescription() + " + Touchbar ";
        }

        public override double GetPrice()
        {
            return macBook.GetPrice() + 400.00;
        }

        public override void IncreaseVolume()
        {
            Console.WriteLine("the Volume was changed by using the Touchbar");
        }
    }
}
