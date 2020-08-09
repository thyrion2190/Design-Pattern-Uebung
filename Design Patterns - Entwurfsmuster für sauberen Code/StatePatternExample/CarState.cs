using System;
using System.Collections.Generic;
using System.Text;

namespace StatePatternExample
{
    public class CarState : State
    {
        private AmphibiousVehicle amphibiousVehivle;

        public CarState(AmphibiousVehicle amphibiousVehivle)
        {
            this.amphibiousVehivle = amphibiousVehivle;
        }

        public override void Accelerate()
        {
            Console.WriteLine("acceleration with the engine and the four wheels");
        }

        public override void SlowDown()
        {
            Console.WriteLine("use the brakes to slow down");
        }
    }
}
