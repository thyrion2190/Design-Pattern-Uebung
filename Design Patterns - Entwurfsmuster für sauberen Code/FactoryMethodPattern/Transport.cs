using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern
{
    public abstract class Transport
    {
        public string Customer { get; set; }
        public string Destination { get; set; }

        public void CollectProductFromCustomer()
        {
            Console.WriteLine("Die Produkte werden abgeholt!");
        }

        public abstract void TransportProducts();
    }
}
