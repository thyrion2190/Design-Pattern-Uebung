using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPatternExample
{
    public class CarRadio : IChannelCollection
    {
        private List<Channel> channels;
        public CarRadio()
        {
            this.channels = new List<Channel>();
        }  
        public void AddChannel(Channel channel)
        {
            channels.Add(channel);
        }

        public IChannelIterator CreateIterator()
        {
            ChannelIteratorShuffle iterator = new ChannelIteratorShuffle(channels);
            return iterator;
        }

        public void RemoveChannel(Channel channel)
        {
            channels.Remove(channel);
        }
    }
}
