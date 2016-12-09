using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using ClientConsole.CloudServiceReference;

namespace ClientConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange kundnamn:");
            string name = Console.ReadLine();
            int customerNo = 0;

            // <LOGIC>
            
            // </LOGIC>
            
            Console.WriteLine("Kundens kundnummer är " + customerNo);
            Console.ReadKey();
        }
        static int GetCustomerNumber(string name)
        {
            int customerNo = 0;

            switch (name)
            {
                case "Monica":
                    customerNo = 1;
                    break;
                case "Wenke":
                    customerNo = 2;
                    break;
                case "Agneta":
                    customerNo = 3;
                    break;
                case "Tomi":
                    customerNo = 4;
                    break;
                case "Stefan":
                    customerNo = 5;
                    break;
                default:
                    customerNo = 6;
                    break;
            }
            return customerNo;
        }
    }
}

#region Snippets

// API
// customerNo = GetCustomerNumber(name);
//CustomerAPI api = new CustomerAPI();
//customerNo = api.GetCustomerNumber(name);

// DCOM

// HTTP 
//WebClient client = new WebClient();
//string c = client.DownloadString("http://localhost:7708/WebSite/GetCustomerNumber.aspx?name=" + name);
//customerNo = int.Parse(c);

// ASMX WebService
//CustomerWebService.CustomerWebServiceSoapClient api = new CustomerWebService.CustomerWebServiceSoapClient();
//customerNo = api.GetCustomerNumber(name);

// Remoting

// WCF
//CustomerWcfService.CustomerWcfServiceClient api = new CustomerWcfService.CustomerWcfServiceClient();
//customerNo = api.GetCustomerNumber(name);





//CustomerBizTalkService.CustomerBizTalkService_Orchestration_1_GetCustomerNumberClient api = new CustomerBizTalkService.CustomerBizTalkService_Orchestration_1_GetCustomerNumberClient("BasicHttpBinding_ITwoWayAsync");

//GetCustomerNumerRequest req = new GetCustomerNumerRequest { name = name };
//var c = api.Operation_1(req);
//customerNo = c.CustomerNumber;

#endregion