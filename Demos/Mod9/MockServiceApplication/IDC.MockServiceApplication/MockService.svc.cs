using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.IO;
using System.ServiceModel.Channels;
using System.Xml;
using System.Diagnostics;

namespace IDC.MockServiceApplication
{
    public class MockService : IMockService
    {
        #region IMockService Members

        public System.ServiceModel.Channels.Message GetAnyData(System.ServiceModel.Channels.Message message)
        {
            string requestAction = message.Headers.Action;
            Debug.WriteLine("[MockServiceHost]: Received unknown message, action:" + requestAction);

            try
            {
                FileStream stream = new FileStream(ResponseHelper.GetResponseFile(requestAction), FileMode.Open, FileAccess.Read);
                XmlDictionaryReader xdr = XmlDictionaryReader.CreateTextReader(stream, new XmlDictionaryReaderQuotas());
                MessageVersion ver = OperationContext.Current.IncomingMessageVersion;
                return Message.CreateMessage(ver, ResponseHelper.GetResponseAction(requestAction), xdr);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("[MockServiceHost]: " + ex.Message);
                throw;
            }
        }

        #endregion
    }
}
