using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodPatternExample
{
    public class ManagerWorkday : WorkdayPlanner
    {
        public override void GoToWork()
        {
            Console.WriteLine("drive to Office");
        }

        public override void Work()
        {
            Console.WriteLine("Mange something");
        }
    }
}
