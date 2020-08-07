using System;
using System.Collections.Generic;

namespace VirtualProxyPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ICustomerList customerList = new CustomerListProxy();
            Company company = new Company("TestCompany", "Musterhausen", customerList);
            Console.WriteLine(company.Name);
            List<Customer> customers = customerList.GetCustomers();
            foreach(Customer customer in customers)
            {
                Console.WriteLine(customer);
            }
            Console.ReadKey();
        }
    }
}
