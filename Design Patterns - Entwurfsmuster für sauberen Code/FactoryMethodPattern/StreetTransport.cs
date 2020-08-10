using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern
{
    public class StreetTransport : Transport
    {
        public override void TransportProducts()
        {
            Console.WriteLine("Die Produkte werden über den Landweg transportiert");
        }
    }
}
