using System;
using System.Collections.Generic;
using System.Text;

namespace MementoPatternExample
{
    public class FitnessPlan
    {
        private string typeOfTraining;
        public FitnessPlan(string typeOfTraining)
        {
            this.typeOfTraining = typeOfTraining;
        }

        public void ChangeTypeOfTraining(string typeOfTraining)
        {
            this.typeOfTraining = typeOfTraining;
        }
        public override string ToString()
        {
            return "Type of Training: " + this.typeOfTraining;
        }
        public Memento Save()
        {
            Console.WriteLine("Trainingsplan has been saved");
            return new Memento(typeOfTraining);
        }
        public void Restore(Memento saveState)
        {
            Console.WriteLine("Trainingsplan was restored");
            this.typeOfTraining = saveState.GetState();
        }
    }
}
