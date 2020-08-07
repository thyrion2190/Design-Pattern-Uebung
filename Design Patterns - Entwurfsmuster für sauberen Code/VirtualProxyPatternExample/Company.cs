using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualProxyPatternExample
{
    public class Company
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public ICustomerList CustomerList { get; set; }

        public Company(string name, string address, ICustomerList customerList)
        {
            this.Name = name;
            this.Address = address;
            this.CustomerList = customerList;
        }
    }
}
