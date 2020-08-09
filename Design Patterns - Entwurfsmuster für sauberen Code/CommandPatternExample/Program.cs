using System;

namespace CommandPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            Console.WriteLine("new Bankaccount was created: " + account.ToString());
            Cashmaschin cashmaschin = new Cashmaschin();
            ITransactionCommand command1 = new DepositCommand(account, 2000);
            ITransactionCommand command2 = new WithDrawCommand(account, 500);
            ITransactionCommand command3 = new DepositCommand(account, 1000);
            cashmaschin.ExecuteBankTransaction(command1);
            cashmaschin.ExecuteBankTransaction(command2);
            cashmaschin.ExecuteBankTransaction(command3);            
            Console.ReadLine();        }
    }
}
