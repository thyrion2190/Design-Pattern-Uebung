using System;
using System.Collections.Generic;
using System.Text;

namespace MementoPatternExample
{
    public class Memento
    {
        private string typeOfTraining;
        public Memento(string typeOfTraining)
        {
            this.typeOfTraining = typeOfTraining;
        }
        public string GetState()
        {
            return typeOfTraining;
        }
    }
}
