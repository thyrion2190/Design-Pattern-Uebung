using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualProxyPatternExample
{
    public interface ICustomerList
    {
        List<Customer> GetCustomers();
    }
}
