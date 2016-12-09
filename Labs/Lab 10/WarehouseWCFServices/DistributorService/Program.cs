using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.ServiceModel.Description;

namespace DistributorService
{
    class Program
    {
        static void Main(string[] args)
        {
            string uri = "http://localhost:8091";
            Uri baseuri = new Uri(uri);
            ServiceHost sh = new ServiceHost(typeof(DistributorService), new Uri[] { baseuri });
            WSHttpBinding binding = new WSHttpBinding();
            ServiceEndpoint se = sh.AddServiceEndpoint(typeof(IDistributorService), binding, "DistributorService");
            ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
            smb.HttpGetEnabled = true;
            sh.Description.Behaviors.Add(smb);
            ServiceDebugBehavior sdb = sh.Description.Behaviors.Find<ServiceDebugBehavior>();
            if (sdb == null)
            {
                sdb = new ServiceDebugBehavior();
                sh.Description.Behaviors.Add(sdb);
            }
            sdb.IncludeExceptionDetailInFaults = true; 
            sh.Open();
            Console.WriteLine("DistributorService started (press ENTER to exit)...");
            Console.ReadLine();
        }
    }

    public class DistributorService : IDistributorService
    {
        public DistributorResponseData ReserveDistributor(DistributorRequestData msg)
        {
            Console.WriteLine("Service received message: {0} to {1} {2}.", 
                msg.OrderId, msg.Street, msg.City);
            DistributorResponseData rd = new DistributorResponseData();
            rd.Accepted = true;
            rd.ShippingDate = DateTime.Now.AddDays(((new Random()).NextDouble()*10));
            return rd;
        }

    }

    [ServiceContract(Namespace = "http://northwind.com/services/DistributorService")]
    public interface IDistributorService
    {
        [OperationContract()]
        DistributorResponseData ReserveDistributor(DistributorRequestData msg);

    }

    [DataContract(Namespace = "http://northwind.com/services/DistributorService")]
    public class DistributorRequestData
    {
        [DataMember]
        public string OrderId;
        [DataMember]
        public string FreightAmount;
        [DataMember]
        public string Street;
        [DataMember]
        public string City;
        [DataMember]
        public string State;
        [DataMember]
        public string Country;
    }

    [DataContract(Namespace = "http://northwind.com/services/DistributorService")]
    public class DistributorResponseData
    {
        [DataMember]
        public bool Accepted;
        [DataMember]
        public DateTime ShippingDate;
    }
}
