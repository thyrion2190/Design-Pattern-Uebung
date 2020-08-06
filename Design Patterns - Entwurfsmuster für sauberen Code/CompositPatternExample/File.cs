using System;
using System.Collections.Generic;
using System.Text;

namespace CompositPatternExample
{
    public class File : FileSystemComponent
    {
        public string Owner { get; set; }
        public File(string name, string owner)
        {
            this.Owner = owner;
            this.Name = name;
        }

        public override void Print(string spacing)
        {
            Console.WriteLine(spacing + "FileName: {0} Owner: {1}", Name, Owner);
        }
    }
}
