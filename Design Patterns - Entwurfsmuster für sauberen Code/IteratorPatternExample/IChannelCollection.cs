using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPatternExample
{
    public interface IChannelCollection
    {
        IChannelIterator CreateIterator();
        void AddChannel(Channel channel);
        void RemoveChannel(Channel channel);
    }
}
