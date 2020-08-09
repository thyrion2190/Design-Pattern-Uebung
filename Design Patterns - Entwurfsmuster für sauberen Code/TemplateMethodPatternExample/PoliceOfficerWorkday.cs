using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodPatternExample
{
    public class PoliceOfficerWorkday : WorkdayPlanner
    {
        public override void GoToWork()
        {
            Console.WriteLine("Police Officer drive to work");
        }

        public override void Work()
        {
            Console.WriteLine("Police Officer work for a better live");
        }
    }
}
