using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePatternExample
{
    public class AirportSystem
    {
        public void CheckLuggage()
        {
            Console.WriteLine("The luggage was picked up at the airport.");
        }
        public void TransportLuggageToAirplane()
        {
            Console.WriteLine("The luggage was transported to the airplane.");
        }
    }
}
