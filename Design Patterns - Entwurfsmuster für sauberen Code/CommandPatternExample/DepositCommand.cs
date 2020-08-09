using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPatternExample
{
    public class DepositCommand : ITransactionCommand
    {
        BankAccount bankAccount;
        double amount;

        public DepositCommand(BankAccount bankAccount, double amount)
        {
            this.bankAccount = bankAccount;
            this.amount = amount;
        }
        public void Execute()
        {
            bankAccount.Deposit(amount);
        }

        public void Undo()
        {
            bankAccount.Balance -= amount;
            Console.WriteLine("The Transaction has been canceled");
        }
    }
}
