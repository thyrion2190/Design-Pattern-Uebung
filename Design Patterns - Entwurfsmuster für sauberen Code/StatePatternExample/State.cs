using System;
using System.Collections.Generic;
using System.Text;

namespace StatePatternExample
{
    public abstract class State
    {
        public abstract void Accelerate();
        public abstract void SlowDown();
    }
}
