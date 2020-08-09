using System;
using System.Collections.Generic;
using System.Text;

namespace StatePatternExample
{
    public class AmphibiousVehicle
    {
        private CarState car;
        private BoatState boat;
        private State currentState;
        public AmphibiousVehicle()
        {
            this.car = new CarState(this);
            this.boat = new BoatState(this);
            this.currentState = car;
        }
        public void PrepareForWater()
        {
            currentState = boat;
            Console.WriteLine("the Vehicle was prepared for water");
        }
        public void PrepareForLand()
        {
            currentState = car;
            Console.WriteLine("the Vehicle was prepared for land");
        }
        public void Accelerate()
        {
            currentState.Accelerate();
        }
        public void SlowDown()
        {
            currentState.SlowDown();
        }
    }
}
