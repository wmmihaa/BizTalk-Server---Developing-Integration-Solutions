using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.ServiceModel.Description;

namespace StaffService
{
    class Program
    {
        static void Main(string[] args)
        {
            string uri = "http://localhost:8092";
            Uri baseuri = new Uri(uri);
            ServiceHost sh = new ServiceHost(typeof(StaffService), new Uri[] { baseuri });
            WSHttpBinding binding = new WSHttpBinding();
            ServiceEndpoint se = sh.AddServiceEndpoint(typeof(IStaffService), binding, "StaffService");
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
            Console.WriteLine("StaffService started (press ENTER to exit)...");
            Console.ReadLine();
        }
    }

    public class StaffService : IStaffService
    {
        public StaffResponseData ReserveStaff(StaffRequestData msg)
        {
            int totalKolli = 0;
            foreach (var item in msg.Items)
            {
                totalKolli += item.Quantity;
            }
            Console.WriteLine("StaffService received message: {0} with total {1} kollis to get.", msg.OrderId, totalKolli);
            StaffResponseData rd = new StaffResponseData();
            rd.Success = true;
            return rd;
        }

    }

    [ServiceContract(Namespace = "http://northwind.com/services/StaffService")]
    public interface IStaffService
    {
        [OperationContract()]
        StaffResponseData ReserveStaff(StaffRequestData msg);

    }

    [DataContract(Namespace = "http://northwind.com/services/StaffService")]
    public class StaffRequestData
    {
        [DataMember]
        public string OrderId;
        [DataMember]
        public List<ItemData> Items;
    }

    [DataContract(Namespace = "http://northwind.com/services/StaffService")]
    public class ItemData
    {
        [DataMember]
        public string ItemId;
        [DataMember]
        public int Quantity;
    }

    [DataContract(Namespace = "http://northwind.com/services/StaffService")]
    public class StaffResponseData
    {
        [DataMember]
        public bool Success;
    }
}
