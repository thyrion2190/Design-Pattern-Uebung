using System;

namespace StrategyPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Investment investment = new Investment(300.00);
            investment.SetInvestmentStrategy(new GoldInvestment());
            investment.TalkToBankEmployee();
            investment.MakeInvestment();
            Console.ReadLine();

        }
    }
}
