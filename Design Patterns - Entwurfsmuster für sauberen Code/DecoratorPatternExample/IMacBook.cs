using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPatternExample
{
    public interface IMacBook
    {
        string GetDescription();
        double GetPrice();
        void IncreaseVolume();
    }
}
