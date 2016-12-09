using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.ServiceModel.Description;

namespace StockService
{
    class Program
    {
        static void Main(string[] args)
        {
            string uri = "http://localhost:8090";
            Uri baseuri = new Uri(uri);
            ServiceHost sh = new ServiceHost(typeof(StockService), new Uri[] { baseuri });
            WSHttpBinding binding = new WSHttpBinding();
            ServiceEndpoint se = sh.AddServiceEndpoint(typeof(IStockService), binding, "StockService");
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
            Console.WriteLine("StockService started (press ENTER to exit)...");
            Console.ReadLine();
        }
    }

    public class StockService : IStockService
    {
        public StockResponseData ReserveStock(StockRequestData msg)
        {
            Console.WriteLine("StockService received message: {0} with {1} type of items.", msg.OrderId, msg.Items.Count);
            StockResponseData rd = new StockResponseData();
            rd.Success = true;
            foreach (var item in msg.Items)
            {
                if (item.ItemId == "666")
                    rd.Success = false;
                System.Threading.Thread.Sleep(3000); // Sleep to make understanding of compensations easier
            }
            return rd;
        }

    }

    [ServiceContract(Namespace = "http://northwind.com/services/StockService")]
    public interface IStockService
    {
        [OperationContract()]
        StockResponseData ReserveStock(StockRequestData msg);

    }

    [DataContract(Namespace = "http://northwind.com/services/StockService")]
    public class StockRequestData
    {
        [DataMember]
        public string OrderId;
        [DataMember]
        public List<ItemData> Items;
    }

    [DataContract(Namespace = "http://northwind.com/services/StockService")]
    public class ItemData
    {
        [DataMember]
        public string ItemId;
        [DataMember]
        public int Quantity;
    }

    [DataContract(Namespace = "http://northwind.com/services/StockService")]
    public class StockResponseData
    {
        [DataMember]
        public bool Success;
    }
}
