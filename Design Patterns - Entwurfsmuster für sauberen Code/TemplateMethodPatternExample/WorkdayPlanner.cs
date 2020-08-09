using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodPatternExample
{
    public abstract class WorkdayPlanner
    {
        public void CreateWorkday()
        {
            WakeUp();
            TakeShower();
            Breakfast();
            GoToWork();
            Work();
            Sleep();
        }

        public void WakeUp()
        {
            Console.WriteLine("Wake up"); 
        }

        public void TakeShower()
        {
            Console.WriteLine("take a shower");
        }

        public void Breakfast()
        {
            Console.WriteLine("eat somthing");
        }

        public abstract void GoToWork();

        public abstract void Work();
        public void Sleep()
        {
            Console.WriteLine("go to Bed");
        }
    }
}
