using System;

namespace SingletonChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            StandardInterestRate interestRateOne = StandardInterestRate.GetInstance();
            interestRateOne.InterestRate = 5.0;
            Console.WriteLine(interestRateOne.InterestRate);

            StandardInterestRate interestRateTwo = StandardInterestRate.GetInstance();
            Console.WriteLine(interestRateTwo.InterestRate);

            Console.ReadLine();
        }
    }
}
