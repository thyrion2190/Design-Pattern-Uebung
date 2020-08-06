using System;
using System.Collections.Generic;
using System.Text;

namespace CompositPatternExample
{
    public abstract class FileSystemComponent
    {
        public string Name { get; set; }
        public abstract void Print(string spacing);
    }
}
