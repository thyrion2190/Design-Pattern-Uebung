﻿using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace CompositePatternExample
{
    public class File : FileSystemComponent
    {
        public string Owner { get; set; }
        public File(string name, string owner)
        {
            this.Owner = owner;
            this.Name = name;
        }
        public override void Print()
        {
            Console.WriteLine("FileName: {0} Owner: {1}", Name, Owner);
        }
    }
}
