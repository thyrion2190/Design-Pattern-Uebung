using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternExample
{
    public class GoldInvestment : IInvestmentStrategy
    {
        public void Invest(double investMoney)
        {
            Console.WriteLine(investMoney + " was invested in Gold");
        }
    }
}
