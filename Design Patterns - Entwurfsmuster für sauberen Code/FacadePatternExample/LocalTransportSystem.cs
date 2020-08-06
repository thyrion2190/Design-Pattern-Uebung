using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePatternExample
{
    public class LocalTransportSystem
    {
        public void LoadingLuggageInTruck()
        {
            Console.WriteLine("The luggage was loaded into the truck.");
        }

        public void TransportLuggageToHotel()
        {
            Console.WriteLine("The luggage was transported to the hotel");
        }
    }
}
