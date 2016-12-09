using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Channels;

namespace IDC.MockServiceApplication
{
    [ServiceContract]
    public interface IMockService
    {
        [OperationContract(Action = "*", ReplyAction = "*")]
        Message GetAnyData(Message message);
    }
}
