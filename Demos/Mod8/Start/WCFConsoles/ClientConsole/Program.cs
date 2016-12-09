using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClientConsole.ServiceReference1;

namespace ClientConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press ENTER to send a message!");
            Console.ReadLine();

            Customers customers = new Customers();
            customers.Add(new Customer()
            {
                FirstName = "Peter",
                MiddleName = "Gustav",
                LastName = "Eriksson",
                ContactNo = "123-456-678"
            });
            customers.Add(new Customer()
            {
                FirstName = "Fredrik",
                MiddleName = "Anders",
                LastName = "Svensson",
                ContactNo = "987-654-321"
            });

            ServiceReference1.Service1Client c = new ClientConsole.ServiceReference1.Service1Client();
            c.SendCustomer(customers);

            Console.WriteLine("Message sent! Press ENTER to exit.");
            Console.ReadLine();
        }
    }
}
