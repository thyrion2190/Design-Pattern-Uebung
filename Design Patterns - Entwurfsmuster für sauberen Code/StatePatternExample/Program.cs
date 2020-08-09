using System;

namespace StatePatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            AmphibiousVehicle vehicle = new AmphibiousVehicle();
            vehicle.Accelerate();
            vehicle.SlowDown();
            Console.WriteLine();
            vehicle.PrepareForWater();
            vehicle.Accelerate();
            vehicle.SlowDown();
            Console.ReadLine();
        }
    }
}
