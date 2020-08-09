using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPatternExample
{
    public class ChannelIteratorShuffle : IChannelIterator
    {
        private List<Channel> channels;
        private int currentPosition = 0;

        public ChannelIteratorShuffle(List<Channel> channels)
        {
            this.channels = channels;
            this.Shuffle();
        }

        private void Shuffle()
        {
            Random random = new Random();
            int n = channels.Count;
            while(n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                Channel value = channels[k];
                channels[k] = channels[n];
                channels[n] = value;
            }
        }

        public bool HasNext()
        {
            if (currentPosition < channels.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Channel Next()
        {
            return channels[currentPosition++];
        }
    }
}
