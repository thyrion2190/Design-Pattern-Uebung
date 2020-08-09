using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternExample
{
    public class Investment
    {
        private IInvestmentStrategy investmentStrategy;
        private double investmentMoney;
        private bool talkedToBankEmployee = false;

        public Investment(double investmentMoney)
        {
            this.investmentMoney = investmentMoney;
        }

        public void SetInvestmentStrategy(IInvestmentStrategy investmentStrategy)
        {
            this.investmentStrategy = investmentStrategy;
            Console.WriteLine("The Strategy was changed");
        }

        public void TalkToBankEmployee()
        {
            talkedToBankEmployee = true;
            Console.WriteLine("the conversation took place");
        }
        public void MakeInvestment()
        {
            if(investmentStrategy != null && talkedToBankEmployee == true)
            {
                investmentStrategy.Invest(investmentMoney);
            }
            else
            {
                Console.WriteLine("Error 404");
            }
        }
    }
}
