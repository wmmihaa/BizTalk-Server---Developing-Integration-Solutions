using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace ExchangeRateServiceApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(ExchangeRateService));
            host.Open();

            Console.WriteLine("ExchangeRateServiceApplication started!");
            Console.WriteLine("Ready to receive ExchangeRateRequests!");
            Console.WriteLine("Press ENTER to terminate.");
            Console.ReadLine();
        }
    }
}
