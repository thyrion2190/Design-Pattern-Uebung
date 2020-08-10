using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern
{
    public class SeaTransport : Transport
    {
        public override void TransportProducts()
        {
            Console.WriteLine("Die Produkte werden über den Seeweg transportiert");
        }
    }
}
