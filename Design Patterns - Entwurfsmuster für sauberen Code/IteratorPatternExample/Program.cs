using System;

namespace IteratorPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            IChannelCollection radio = new CarRadio();
            radio.AddChannel(new Channel("DJHorstFM", 107.4));
            radio.AddChannel(new Channel("Bremen4", 106.4));
            radio.AddChannel(new Channel("FFN", 156.4));
            IChannelIterator iterator = radio.CreateIterator();
            while (iterator.HasNext())
            {
                Channel channel = iterator.Next();
                Console.WriteLine(channel);
            }
            Console.ReadLine();
        }
    }
}
