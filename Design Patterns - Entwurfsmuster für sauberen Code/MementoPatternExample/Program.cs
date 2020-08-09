using System;

namespace MementoPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Caretaker caretaker = new Caretaker();
            FitnessPlan plan = new FitnessPlan("Power Workout");
            Console.WriteLine(plan);
            caretaker.SaveState(plan);
            plan.ChangeTypeOfTraining("Walking");
            Console.WriteLine(plan);
            caretaker.SaveState(plan);
            plan.ChangeTypeOfTraining("Basic Workout");
            Console.WriteLine(plan);
            caretaker.SaveState(plan);
            caretaker.RestoreState(plan, 0);
            Console.WriteLine(plan);
            Console.ReadLine();
        }
    }
}
