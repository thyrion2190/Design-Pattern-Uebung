using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualProxyPatternExample
{
    public class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public bool BonusCard { get; set; }

        public Customer(string name, string address, bool bonusCard)
        {
            this.Name = name;
            this.Address = address;
            this.BonusCard = bonusCard;
        }

        public override string ToString()
        {
            return "Customer: \n" + "Name: " + Name + "\nAddress: " + Address + "\nBonusCard: " + BonusCard + "\n";
        }
    }
}
