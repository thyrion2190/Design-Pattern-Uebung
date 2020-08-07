using System;
using System.Collections.Generic;
using System.Text;

namespace ProtectionProxyPatternExample
{
    public class DownlaodProduct : IDownloadable
    {
        public string ProductName { get; set; }
        public DownlaodProduct(string productName)
        {
            this.ProductName = productName;
        }
        public void Downlaod(Customer customer)
        {
            Console.WriteLine(customer.Name + " has download the Product: " + ProductName);
        }
    }
}
