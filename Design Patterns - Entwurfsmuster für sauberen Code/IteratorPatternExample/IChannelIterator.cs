using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPatternExample
{
    public interface IChannelIterator
    {
        bool HasNext();
        Channel Next();
    }
}
