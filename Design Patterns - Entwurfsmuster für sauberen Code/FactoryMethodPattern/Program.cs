using System;

namespace FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Logistics logistics = new SeaStreetFlightLogistics();
            Transport kundenTransport = logistics.ManageTransportForCustomer("sea");
            Console.ReadLine();
        }
    }
}
