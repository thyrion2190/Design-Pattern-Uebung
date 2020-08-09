using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPatternExample
{
    public interface ITransactionCommand
    {
        void Execute();
        void Undo();
    }
}
