using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternExample
{
    public class SilverInvestStrategy : IInvestmentStrategy
    {
        public void Invest(double investMoney)
        {
            Console.WriteLine(investMoney + " was invested in Silver");
        }
    }
}
