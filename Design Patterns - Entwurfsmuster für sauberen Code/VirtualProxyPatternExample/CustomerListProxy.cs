using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualProxyPatternExample
{
    public class CustomerListProxy : ICustomerList
    {
        private ICustomerList customerList;
        public List<Customer> GetCustomers()
        {
            if(customerList == null)
            {
                Console.WriteLine("Customer List is loading please wait...");
                customerList = new CustomerList();
            }
            return customerList.GetCustomers();
        }
    }
}
