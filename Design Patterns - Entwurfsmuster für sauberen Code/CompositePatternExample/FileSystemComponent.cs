using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePatternExample
{
    public abstract class FileSystemComponent
    {
        public string Name { get; set; }
        public abstract void Print();
    }
}
