using System;

namespace ProtectionProxyPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer testCustomer = new Customer("Herr Mustermann");
            DownlaodProductProxy product = new DownlaodProductProxy("TestProduct");
            product.Downlaod(testCustomer);
            product.Downlaod(testCustomer);
            product.Downlaod(testCustomer);
            product.Downlaod(testCustomer);
            Console.ReadLine();
        }
    }
}
