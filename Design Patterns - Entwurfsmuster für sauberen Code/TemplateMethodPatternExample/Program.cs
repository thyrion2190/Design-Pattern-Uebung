using System;

namespace TemplateMethodPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ManagerWorkday workday = new ManagerWorkday();
            workday.CreateWorkday();
            Console.ReadLine();
        }
    }
}
