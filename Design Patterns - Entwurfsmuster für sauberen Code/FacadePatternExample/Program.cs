using System;

namespace FacadePatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            FacadeLuggageManagement bookingSystem = new FacadeLuggageManagement();
            bookingSystem.SendLuggage();
            Console.ReadLine();
        }
    }
}
