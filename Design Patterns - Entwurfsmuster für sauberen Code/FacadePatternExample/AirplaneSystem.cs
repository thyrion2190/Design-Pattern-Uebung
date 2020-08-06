using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePatternExample
{
    public class AirplaneSystem
    {
        public void LoadingTheLuggage()
        {
            Console.WriteLine("The luggage was loaded into the airplane.");
        }

        public void UnloadingTheLuggage()
        {
            Console.WriteLine("The luggage was unloaded of the airplane.");
        }
    }
}
