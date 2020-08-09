using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPatternExample
{
    public class WithDrawCommand : ITransactionCommand
    {
        BankAccount bankAccount;
        double amount;
        bool transactionSucceeded;

        public WithDrawCommand(BankAccount bankAccount, double amount)
        {
            this.bankAccount = bankAccount;
            this.amount = amount;
        }
        public void Execute()
        {
            transactionSucceeded = bankAccount.Withdraw(amount);
        }

        public void Undo()
        {
            if(transactionSucceeded)
            {
                bankAccount.Balance += amount;
                Console.WriteLine("The Transaction has been canceled");
            }
            else
            {
                Console.WriteLine("Error 404 Undo not started");
            }
        }
    }
}
