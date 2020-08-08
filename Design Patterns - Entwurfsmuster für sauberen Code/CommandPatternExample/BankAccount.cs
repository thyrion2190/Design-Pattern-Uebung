using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPatternExample
{
    public class BankAccount
    {
        public double Balance { get; set; } = 0;
        public double OverdraftLimit { get; set; } = 1000;
        public void Deposit(double amount)
        {
            Balance += amount;
            Console.WriteLine("You have deposit: " + amount + "\nNew Bankaccount Balance is: " + Balance);
        }
        public void Withdraw(double amount)
        {
            Balance -= amount;
            Console.WriteLine("You have withdraw: " + amount + "\nNew Bankaccount Balance is: " + Balance);
        }

        public override string ToString()
        {
            return "The Bankaccount Balance is: " + Balance + "\nThe Overdraftlimit is: " + OverdraftLimit;

        }
    }
}
