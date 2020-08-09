using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace IteratorPatternExample
{
    public class Channel
    {
        public string Name { get; set; }
        public double Frequency { get; set; }

        public Channel(string name, double frequency)
        {
            this.Name = name;
            this.Frequency = frequency;
        }

        public override string ToString()
        {
            return "You are listing to " + Name + "(the frequency is: " + Frequency + ")";
        }
    }
}
