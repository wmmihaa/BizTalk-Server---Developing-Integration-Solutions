using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Service1Client proxy = new Service1Client())
            {
                Console.WriteLine(proxy.GetData(1));
                Console.ReadLine();
            }
        }
    }
}
