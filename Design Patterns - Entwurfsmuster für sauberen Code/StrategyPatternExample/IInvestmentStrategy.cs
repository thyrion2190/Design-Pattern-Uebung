using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternExample
{
    public interface IInvestmentStrategy
    {
        void Invest(double investMoney);
    }
}
