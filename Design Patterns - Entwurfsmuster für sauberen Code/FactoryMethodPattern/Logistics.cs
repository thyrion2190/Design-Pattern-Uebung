using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern
{
    public abstract class Logistics
    {
        protected abstract Transport TransportFactory(string transportType);
        public Transport ManageTransportForCustomer(string transportType)
        {
            Transport transport = TransportFactory(transportType);
            transport.CollectProductFromCustomer();
            transport.TransportProducts();
            return transport;
        }
    }
}
