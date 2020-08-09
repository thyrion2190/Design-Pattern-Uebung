using System;
using System.Collections.Generic;
using System.Text;

namespace MementoPatternExample
{
    public class Caretaker
    {
        private List<Memento> mementos;
        public Caretaker()
        {
            mementos = new List<Memento>();
        }
        public void SaveState(FitnessPlan fitnessPlan)
        {
            mementos.Add(fitnessPlan.Save());
        }
        public void RestoreState(FitnessPlan fitnessPlan, int index)
        {
            fitnessPlan.Restore(mementos[index]);
        }
    }
}
