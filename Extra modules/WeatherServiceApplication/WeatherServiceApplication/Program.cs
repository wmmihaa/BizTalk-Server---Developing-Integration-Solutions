using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace WeatherServiceApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(WeatherService));
            host.Open();

            Console.WriteLine("WeatherServiceApplication started!");
            Console.WriteLine("Ready to receive WeatherRequests!");
            Console.WriteLine("Press ENTER to terminate.");
            Console.ReadLine();
        }
    }
}
