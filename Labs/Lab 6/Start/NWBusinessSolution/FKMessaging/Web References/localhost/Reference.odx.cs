
#pragma warning disable 162

namespace FKMessaging.localhost.SuppService_
{

    [System.SerializableAttribute]
    sealed public class __FKMessaging_localhost_Reference__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static FKMessaging.localhost.Reference _schema = new FKMessaging.localhost.Reference();

        public __FKMessaging_localhost_Reference__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eRequest,
        "FKMessaging.localhost.SuppService.PostOrder",
        new System.Type[]{
            typeof(FKMessaging.localhost.Reference)
        },
        new string[]{
            "order"
        },
        new System.Type[]{
            typeof(__FKMessaging_localhost_Reference__)
        },
        0,
        @"http://tempuri.org/#SuppOrder"
    )]
    [System.SerializableAttribute]
    sealed public class PostOrder_request : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __FKMessaging_localhost_Reference__ order;

        private void __CreatePartWrappers()
        {
            order = new __FKMessaging_localhost_Reference__(this, "order", 0);
            this.AddPart("order", 0, order);
        }

        public PostOrder_request(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eResponse,
        "FKMessaging.localhost.SuppService.PostOrder",
        new System.Type[]{
        },
        new string[]{
        },
        new System.Type[]{
        },
        -1,
        ""
    )]
    [System.SerializableAttribute]
    sealed public class PostOrder_response : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {

        private void __CreatePartWrappers()
        {
        }

        public PostOrder_response(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "PostOrder",
        new System.Type[]{
            typeof(FKMessaging.localhost.SuppService_.PostOrder_request), 
            typeof(FKMessaging.localhost.SuppService_.PostOrder_response)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic, "")]
    [Microsoft.XLANGs.BaseTypes.WSDLProxyNameAttribute(typeof(FKMessaging.localhost.SuppService))]
    [System.SerializableAttribute]
    sealed public class SuppService : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public SuppService(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public SuppService(SuppService p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            SuppService p = new SuppService(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo PostOrder = new Microsoft.XLANGs.Core.OperationInfo
        (
            "PostOrder",
            System.Web.Services.Description.OperationFlow.RequestResponse,
            typeof(SuppService),
            typeof(PostOrder_request),
            typeof(PostOrder_response),
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "PostOrder" ] = PostOrder;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(true)]
    [Microsoft.XLANGs.BaseTypes.TargetXmlNamespaceAttribute("http://tempuri.org/")]
    sealed public class _MODULE_PROXY_ { }
}
