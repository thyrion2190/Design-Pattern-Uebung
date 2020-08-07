using System;
using System.Collections.Generic;
using System.Text;

namespace ProtectionProxyPatternExample
{
    public class Customer
    {
        public string Name { get; set; }
        public Customer(string name)
        {
            this.Name = name;
        }
    }
}
