using System;
using System.Collections.Generic;
using System.Text;

namespace StatePatternExample
{
    public class BoatState : State
    {
        private AmphibiousVehicle amphibiousVehicle;
        public BoatState(AmphibiousVehicle amphibiousVehivle)
        {
            this.amphibiousVehicle = amphibiousVehivle;
        }
        public override void Accelerate()
        {
            Console.WriteLine("Accelerate with the propeller and engine");
        }
        public override void SlowDown()
        {
            Console.WriteLine("Reduce the speed with the propeller");
        }
    }
}
