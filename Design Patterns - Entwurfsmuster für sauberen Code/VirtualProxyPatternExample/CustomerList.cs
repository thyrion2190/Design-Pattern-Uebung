using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualProxyPatternExample
{
    class CustomerList : ICustomerList
    {
        public List<Customer> GetCustomers()
        {
            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer("Mustermann", "Musterhausen", true));
            customers.Add(new Customer("Heidemann", "Bremen", false));
            customers.Add(new Customer("Freimann", "Hannover", true));
            customers.Add(new Customer("Seemann", "Verden", false));
            customers.Add(new Customer("Gurkenmann", "Münster", true));
            customers.Add(new Customer("Brotmann", "Nebelhausen", false));
            customers.Add(new Customer("Fischermann", "München", true));
            customers.Add(new Customer("Schneider", "Kleinborstel", false));
            customers.Add(new Customer("Kröger", "Nienburg", true));
            customers.Add(new Customer("Graumann", "Oberhausen", false));
            customers.Add(new Customer("Lambrecht", "Freistadt", true));
            customers.Add(new Customer("Wagner", "Punfsdorf", false));
            customers.Add(new Customer("Petersen", "Ober Neustadt", true));
            customers.Add(new Customer("Kleinig", "Nebeldorf", false));
            customers.Add(new Customer("Freiherr", "Freihausen", true));
            customers.Add(new Customer("König", "Königsstadt", false));
            customers.Add(new Customer("Herzog", "Herzogdorf", true));
            customers.Add(new Customer("Hundertmann", "Wunderhausen", false));
            customers.Add(new Customer("Malermeister", "Mahlstadt", true));
            customers.Add(new Customer("Greifenhorst", "Greifdorf", false));
            customers.Add(new Customer("Browning", "Browninghausen", true));
            customers.Add(new Customer("Winchester", "Winchesterhausen", false));
            customers.Add(new Customer("Ulmbrecht", "Ulm", true));
            customers.Add(new Customer("Lüdermann", "Lüderstadt", false));
            customers.Add(new Customer("Kneipmann", "Kneiphausen", true));
            customers.Add(new Customer("Trinker", "Saufhausen", false));
            customers.Add(new Customer("Reinbeker", "Quellhausen", true));
            Console.WriteLine("Customers was loaded");
            return customers;
        }
    }
}
