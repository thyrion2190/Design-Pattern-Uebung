using System;
using System.Collections.Generic;
using System.Text;

namespace ProtectionProxyPatternExample
{
    public class DownlaodProductProxy : IDownloadable
    {
        private const int numDownlaodsAllowed = 3;
        private int numberOfAllDownloads = 0;
        private DownlaodProduct downlaodProduct;

        public DownlaodProductProxy(string productName)
        {
            downlaodProduct = new DownlaodProduct(productName);
        }

        public void Downlaod(Customer customer)
        {
            if(numberOfAllDownloads < numDownlaodsAllowed)
            {
                numberOfAllDownloads++;
                downlaodProduct.Downlaod(customer);
            }
            else
            {
                Console.WriteLine("The Product: " + downlaodProduct.ProductName + " are not longer exist for your account");
            }
        }
    }
}
