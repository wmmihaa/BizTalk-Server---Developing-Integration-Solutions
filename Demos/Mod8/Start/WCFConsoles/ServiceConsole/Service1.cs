using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceConsole
{
    // NOTE: If you change the class name "Service1" here, you must also update the reference to "Service1" in App.config.
    public class Service1 : IService1
    {
        public void SendCustomer(mod8.customers.Customers customers)
        {
            foreach (var customer in customers)
            {
                Console.WriteLine("Received Customer {0} {1} {2}",
                    customer.FirstName,
                    customer.MiddleName,
                    customer.LastName);
            }
        }
    }
}
