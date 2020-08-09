using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPatternExample
{
    public class Cashmaschin
    {
        public void ExecuteBankTransaction(ITransactionCommand command)
        {
            command.Execute();
        }
        public void UndoBankTransaction(ITransactionCommand command)
        {
            command.Undo();
        }
    }

}
