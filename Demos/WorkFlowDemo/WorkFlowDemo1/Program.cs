using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Activities;
using System.ServiceModel.Activities;

namespace WorkFlowDemo1
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, object> dic = new Dictionary<string, object>();
            dic.Add("inArg", "Test");

            WorkflowInvoker.Invoke(new FlowActivity(), dic);
            Console.ReadKey();

        }
    }
}
