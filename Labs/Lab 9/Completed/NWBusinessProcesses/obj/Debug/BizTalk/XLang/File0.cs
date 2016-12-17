
#pragma warning disable 162

namespace NWBusinessProcesses
{

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(NWBusinessProcesses.__messagetype_NWMessaging_CustomerOrder)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class OrderReceivePortType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public OrderReceivePortType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public OrderReceivePortType(OrderReceivePortType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            OrderReceivePortType p = new OrderReceivePortType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(OrderReceivePortType),
            typeof(__messagetype_NWMessaging_CustomerOrder),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Operation_1" ] = Operation_1;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(NWBusinessProcesses.__messagetype_NWMessaging_WarehouseShipRequest)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class WarehouseSendPortType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public WarehouseSendPortType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public WarehouseSendPortType(WarehouseSendPortType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            WarehouseSendPortType p = new WarehouseSendPortType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(WarehouseSendPortType),
            typeof(__messagetype_NWMessaging_WarehouseShipRequest),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Operation_1" ] = Operation_1;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(NWBusinessProcesses.__messagetype_NWMessaging_DistResp)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class WarehouseReceivePortType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public WarehouseReceivePortType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public WarehouseReceivePortType(WarehouseReceivePortType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            WarehouseReceivePortType p = new WarehouseReceivePortType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(WarehouseReceivePortType),
            typeof(__messagetype_NWMessaging_DistResp),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Operation_1" ] = Operation_1;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(NWBusinessProcesses.__messagetype_NWMessaging_AccountingInvoice)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class AccountingPortType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public AccountingPortType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public AccountingPortType(AccountingPortType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            AccountingPortType p = new AccountingPortType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(AccountingPortType),
            typeof(__messagetype_NWMessaging_AccountingInvoice),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Operation_1" ] = Operation_1;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(NWBusinessProcesses.__messagetype_NWMessaging_OrderResponse)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class CustomerAckPortType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public CustomerAckPortType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public CustomerAckPortType(CustomerAckPortType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            CustomerAckPortType p = new CustomerAckPortType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(CustomerAckPortType),
            typeof(__messagetype_NWMessaging_OrderResponse),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Operation_1" ] = Operation_1;
                return h;
            }
        }
        #endregion // port reflection support
    }
    [Microsoft.XLANGs.BaseTypes.CorrelationTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        new string[] {
            "NWMessaging.CustomerPONumber"
        }
    )]
    sealed internal class CustomerPOCorrType : Microsoft.XLANGs.Core.CorrelationType
    {
        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        private static Microsoft.XLANGs.BaseTypes.PropertyBase[] _properties = new Microsoft.XLANGs.BaseTypes.PropertyBase[] {
            new NWMessaging.CustomerPONumber()
         };
        public override Microsoft.XLANGs.BaseTypes.PropertyBase[] Properties { get { return _properties; } }
        public static Microsoft.XLANGs.BaseTypes.PropertyBase[] PropertiesList { get { return _properties; } }
    }
    //#line 469 "C:\Labs\Lab 9\Completed\NWBusinessProcesses\NWOrderProcessing.odx"
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "OrderReceivePort", "Operation_1", -1, -1, true
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eDynamic
        },
        new System.Type[] {
            typeof(NWBusinessProcesses.OrderReceivePortType),
            typeof(NWBusinessProcesses.WarehouseSendPortType),
            typeof(NWBusinessProcesses.WarehouseReceivePortType),
            typeof(NWBusinessProcesses.AccountingPortType),
            typeof(NWBusinessProcesses.CustomerAckPortType)
        },
        new System.String[] {
            "OrderReceivePort",
            "WarehouseSendPort",
            "WarehouseReceivePort",
            "AccountingPort",
            "CustomerAcknowledgementPort"
        },
        new System.Type[] {
            null,
            null,
            null,
            null,
            null
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceCallTreeAttribute(
        new System.Type[] {
        },
        new System.Type[] {
        },
        new System.Type[] {
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSServiceInfo.eNone
    )]
    [System.SerializableAttribute]
    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed internal class NWOrderProcessing : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
    {
        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        public static readonly bool __execable = false;
        [Microsoft.XLANGs.BaseTypes.CallCompensationAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSCallCompensationInfo.eNone,
            new System.String[] {
            },
            new System.String[] {
            }
        )]
        public static void __bodyProxy()
        {
        }
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(NWOrderProcessing));
        private static volatile System.Guid[] _activationSubIds;

        private static new object _lockIdentity = new object();

        public static System.Guid UUID { get { return _serviceId; } }
        public override System.Guid ServiceId { get { return UUID; } }

        protected override System.Guid[] ActivationSubGuids
        {
            get { return _activationSubIds; }
            set { _activationSubIds = value; }
        }

        protected override object StaleStateLock
        {
            get { return _lockIdentity; }
        }

        protected override bool HasActivation { get { return true; } }

        internal bool IsExeced = false;

        static NWOrderProcessing()
        {
            Microsoft.BizTalk.XLANGs.BTXEngine.BTXService.CacheStaticState( _serviceId );
        }

        private void ConstructorHelper()
        {
            _segments = new Microsoft.XLANGs.Core.Segment[] {
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment0), 0, 0, 0),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment1), 1, 1, 1)
            };

            _Locks = 1;
            _rootContext = new __NWOrderProcessing_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[2];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public NWOrderProcessing(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "NWOrderProcessing", tracker)
        {
            ConstructorHelper();
        }

        public NWOrderProcessing(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "NWOrderProcessing")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>2a76fb2f-3e98-4a33-8567-478e1f23d805</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>92734ffb-9dc2-46af-81e3-dae6bec13f33</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive_Order</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>66c2a08c-cd0b-4160-8508-847e330f2c61</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>ConstructMessage_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>86761f26-ce65-4286-ab32-1a95cd10bec9</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Transform_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>1398058f-796c-47c6-8481-beae722340f8</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>bbcdb8f7-aca0-4184-8767-aee1b9d14bac</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>7a144517-c037-4f28-807f-85c507de9f1c</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>7e3c7e3d-4433-43b6-86cd-300527819c3f</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Send_ShipRequest</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>41300a3d-d69e-4300-a0a0-829095e1a5cf</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive_ShipNotification</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionShape</shapeType>      <ShapeID>9568da08-0224-4e59-a2ba-34f4e8348a18</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Decide_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>e02c9311-1cfe-4ccc-8471-f14adf7cebdf</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Rule_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>a4cc8474-93d0-4faf-baf2-2c618de337f8</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ConstructMessage_2</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>30a242ca-1ef5-4074-8d14-bd2ca45a5ae6</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Transform_2</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>0896db03-12a2-4ef8-a028-6886a45a0101</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_3</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>3bd124b6-8f66-456a-acd9-c4b388eabc14</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_4</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>a3ecbe90-f464-4925-b64e-c6ed23a7d378</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>cd0c1d2d-1476-492d-8e30-c3f7fc8bb3ce</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send_AccountingRequest</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>9b7e8b71-5f21-4f71-b0bf-f2afdfead6d9</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Else</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>1cb56f74-b4e0-46d4-92ed-b56a84617c80</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>ConstructMessage_3</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>4e8d6f5a-f3ea-410e-9485-20983be2cd8f</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Transform_3</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>5dcbaf9a-ffb5-40f7-ab2c-21da7de2652e</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_5</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>466ffa40-7d3e-49bb-a847-c5ed143e8412</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_6</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>885338b6-f0aa-49a3-8f72-8fb058a09443</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>9282ebd0-fcf3-4004-ad22-0d99b3361cfd</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Expression_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>c870f155-15ea-42ba-9a39-bad51ae68a75</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Send_ClientNotification</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'NWOrderProcessing'</ActionName><IsAtomic>0</IsAtomic><Line>469</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>490</Line><Position>22</Position><ShapeID>'92734ffb-9dc2-46af-81e3-dae6bec13f33'</ShapeID>
<Messages>
	<MsgInfo><name>OrderMessage</name><part>part</part><schema>NWMessaging.CustomerOrder</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>492</Line><Position>13</Position><ShapeID>'66c2a08c-cd0b-4160-8508-847e330f2c61'</ShapeID>
<Messages>
	<MsgInfo><name>WarehouseRequest</name><part>part</part><schema>NWMessaging.WarehouseShipRequest</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>OrderMessage</name><part>part</part><schema>NWMessaging.CustomerOrder</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>498</Line><Position>13</Position><ShapeID>'7e3c7e3d-4433-43b6-86cd-300527819c3f'</ShapeID>
<Messages>
	<MsgInfo><name>WarehouseRequest</name><part>part</part><schema>NWMessaging.WarehouseShipRequest</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>500</Line><Position>13</Position><ShapeID>'41300a3d-d69e-4300-a0a0-829095e1a5cf'</ShapeID>
<Messages>
	<MsgInfo><name>WarehouseResponse</name><part>part</part><schema>NWMessaging.DistResp</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>502</Line><Position>13</Position><ShapeID>'9568da08-0224-4e59-a2ba-34f4e8348a18'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>505</Line><Position>17</Position><ShapeID>'a4cc8474-93d0-4faf-baf2-2c618de337f8'</ShapeID>
<Messages>
	<MsgInfo><name>AccountingRequest</name><part>part</part><schema>NWMessaging.AccountingInvoice</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>OrderMessage</name><part>part</part><schema>NWMessaging.CustomerOrder</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>511</Line><Position>17</Position><ShapeID>'cd0c1d2d-1476-492d-8e30-c3f7fc8bb3ce'</ShapeID>
<Messages>
	<MsgInfo><name>AccountingRequest</name><part>part</part><schema>NWMessaging.AccountingInvoice</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>514</Line><Position>13</Position><ShapeID>'1cb56f74-b4e0-46d4-92ed-b56a84617c80'</ShapeID>
<Messages>
	<MsgInfo><name>CustomerReply</name><part>part</part><schema>NWMessaging.OrderResponse</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>WarehouseResponse</name><part>part</part><schema>NWMessaging.DistResp</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>520</Line><Position>77</Position><ShapeID>'9282ebd0-fcf3-4004-ad22-0d99b3361cfd'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>522</Line><Position>13</Position><ShapeID>'c870f155-15ea-42ba-9a39-bad51ae68a75'</ShapeID>
<Messages>
	<MsgInfo><name>CustomerReply</name><part>part</part><schema>NWMessaging.OrderResponse</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='fa2cc769-993c-4e7f-abd8-15060f818c26' LowerBound='1.1' HigherBound='101.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='NWBusinessProcesses' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='8db57abb-a193-4b1d-b8b6-d3548212958a' ParentLink='Module_PortType' LowerBound='4.1' HigherBound='11.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='OrderReceivePortType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='c7d91725-9343-4ab9-ad4e-8e4a746fa717' ParentLink='PortType_OperationDeclaration' LowerBound='6.1' HigherBound='10.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='2b9e300f-e5ea-483c-b156-c6162956bd54' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='8.13' HigherBound='8.38'>
                    <om:Property Name='Ref' Value='NWMessaging.CustomerOrder' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='0cd9c2ae-b0b5-40a3-a41b-cafcae386a8a' ParentLink='Module_PortType' LowerBound='11.1' HigherBound='18.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='WarehouseSendPortType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='f722c149-f584-4717-a444-d95ba8633224' ParentLink='PortType_OperationDeclaration' LowerBound='13.1' HigherBound='17.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='d7658bf3-6cdf-487b-837f-9a0cacd86f0b' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='15.13' HigherBound='15.45'>
                    <om:Property Name='Ref' Value='NWMessaging.WarehouseShipRequest' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='77941644-f8a1-4db9-9cfd-57aa6e0faebc' ParentLink='Module_PortType' LowerBound='18.1' HigherBound='25.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='WarehouseReceivePortType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='eb149699-f968-4d3e-bc01-a0b14d61bc0b' ParentLink='PortType_OperationDeclaration' LowerBound='20.1' HigherBound='24.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='d302bd81-94b5-499c-83f5-4cfd0d60e51d' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='22.13' HigherBound='22.33'>
                    <om:Property Name='Ref' Value='NWMessaging.DistResp' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='043f4f3c-5c23-4920-8902-a43f1e65f941' ParentLink='Module_PortType' LowerBound='25.1' HigherBound='32.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='AccountingPortType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='f111f852-f085-4746-be92-a55a297591e5' ParentLink='PortType_OperationDeclaration' LowerBound='27.1' HigherBound='31.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='6b915390-4485-495f-8e65-f15db9ebafeb' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='29.13' HigherBound='29.42'>
                    <om:Property Name='Ref' Value='NWMessaging.AccountingInvoice' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='7f781a97-ac54-438a-8351-d9ba53fc10c4' ParentLink='Module_PortType' LowerBound='32.1' HigherBound='39.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='CustomerAckPortType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='651d1291-2243-4f79-a9f0-3c2f5724ea56' ParentLink='PortType_OperationDeclaration' LowerBound='34.1' HigherBound='38.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='eb0dca05-949a-4d27-a1fc-5b911f129f82' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='36.13' HigherBound='36.38'>
                    <om:Property Name='Ref' Value='NWMessaging.OrderResponse' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='a852ff29-c153-434f-9a8e-e2bc1399567f' ParentLink='Module_ServiceDeclaration' LowerBound='43.1' HigherBound='100.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='NWOrderProcessing' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='CorrelationDeclaration' OID='8215fb6c-baa1-4edd-a55b-441af2ef7ab5' ParentLink='ServiceDeclaration_CorrelationDeclaration' LowerBound='56.1' HigherBound='57.1'>
                <om:Property Name='Type' Value='NWBusinessProcesses.CustomerPOCorrType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='CustomerOrderCorrelation' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='StatementRef' OID='6161ee09-42e6-4d98-a4a4-cc948776895c' ParentLink='CorrelationDeclaration_StatementRef' LowerBound='73.68' HigherBound='73.103'>
                    <om:Property Name='Initializes' Value='True' />
                    <om:Property Name='Ref' Value='7e3c7e3d-4433-43b6-86cd-300527819c3f' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='StatementRef_1' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='StatementRef' OID='dc79b105-7c3a-4330-be9d-476aaefcd88e' ParentLink='CorrelationDeclaration_StatementRef' LowerBound='75.75' HigherBound='75.99'>
                    <om:Property Name='Initializes' Value='False' />
                    <om:Property Name='Ref' Value='41300a3d-d69e-4300-a0a0-829095e1a5cf' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='StatementRef_2' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='b2601654-4c3e-436f-a468-6ed7bdd7c059' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='57.1' HigherBound='58.1'>
                <om:Property Name='Type' Value='NWMessaging.CustomerOrder' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='OrderMessage' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='3646f695-57f5-4a4b-9c74-6b66bf2b687c' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='58.1' HigherBound='59.1'>
                <om:Property Name='Type' Value='NWMessaging.OrderResponse' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='CustomerReply' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='10a3c0df-16c8-43e0-be0b-ba97af02c30c' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='59.1' HigherBound='60.1'>
                <om:Property Name='Type' Value='NWMessaging.WarehouseShipRequest' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='WarehouseRequest' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='b05ab29e-3a63-42fb-9cf2-0c6b27697f00' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='60.1' HigherBound='61.1'>
                <om:Property Name='Type' Value='NWMessaging.DistResp' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='WarehouseResponse' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='c45c681d-d6e1-4662-b923-fbdcd8bb91d4' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='61.1' HigherBound='62.1'>
                <om:Property Name='Type' Value='NWMessaging.AccountingInvoice' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='AccountingRequest' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='2a76fb2f-3e98-4a33-8567-478e1f23d805' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='92734ffb-9dc2-46af-81e3-dae6bec13f33' ParentLink='ServiceBody_Statement' LowerBound='64.1' HigherBound='66.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='OrderReceivePort' />
                    <om:Property Name='MessageName' Value='OrderMessage' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive_Order' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Construct' OID='66c2a08c-cd0b-4160-8508-847e330f2c61' ParentLink='ServiceBody_Statement' LowerBound='66.1' HigherBound='72.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='ConstructMessage_1' />
                    <om:Property Name='Signal' Value='False' />
                    <om:Element Type='Transform' OID='86761f26-ce65-4286-ab32-1a95cd10bec9' ParentLink='ComplexStatement_Statement' LowerBound='69.1' HigherBound='71.1'>
                        <om:Property Name='ClassName' Value='NWMessaging.MapOrderToShipRequest' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Transform_1' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='MessagePartRef' OID='1398058f-796c-47c6-8481-beae722340f8' ParentLink='Transform_InputMessagePartRef' LowerBound='70.83' HigherBound='70.95'>
                            <om:Property Name='MessageRef' Value='OrderMessage' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='MessagePartReference_1' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='MessagePartRef' OID='bbcdb8f7-aca0-4184-8767-aee1b9d14bac' ParentLink='Transform_OutputMessagePartRef' LowerBound='70.28' HigherBound='70.44'>
                            <om:Property Name='MessageRef' Value='WarehouseRequest' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='MessagePartReference_2' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='MessageRef' OID='7a144517-c037-4f28-807f-85c507de9f1c' ParentLink='Construct_MessageRef' LowerBound='67.23' HigherBound='67.39'>
                        <om:Property Name='Ref' Value='WarehouseRequest' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
                <om:Element Type='Send' OID='7e3c7e3d-4433-43b6-86cd-300527819c3f' ParentLink='ServiceBody_Statement' LowerBound='72.1' HigherBound='74.1'>
                    <om:Property Name='PortName' Value='WarehouseSendPort' />
                    <om:Property Name='MessageName' Value='WarehouseRequest' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Send_ShipRequest' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Receive' OID='41300a3d-d69e-4300-a0a0-829095e1a5cf' ParentLink='ServiceBody_Statement' LowerBound='74.1' HigherBound='76.1'>
                    <om:Property Name='Activate' Value='False' />
                    <om:Property Name='PortName' Value='WarehouseReceivePort' />
                    <om:Property Name='MessageName' Value='WarehouseResponse' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive_ShipNotification' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Decision' OID='9568da08-0224-4e59-a2ba-34f4e8348a18' ParentLink='ServiceBody_Statement' LowerBound='76.1' HigherBound='88.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Decide_1' />
                    <om:Property Name='Signal' Value='False' />
                    <om:Element Type='DecisionBranch' OID='e02c9311-1cfe-4ccc-8471-f14adf7cebdf' ParentLink='ReallyComplexStatement_Branch' LowerBound='77.13' HigherBound='88.1'>
                        <om:Property Name='Expression' Value='WarehouseResponse.Status == &quot;Shipped&quot;' />
                        <om:Property Name='IsGhostBranch' Value='True' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Rule_1' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='Construct' OID='a4cc8474-93d0-4faf-baf2-2c618de337f8' ParentLink='ComplexStatement_Statement' LowerBound='79.1' HigherBound='85.1'>
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='ConstructMessage_2' />
                            <om:Property Name='Signal' Value='False' />
                            <om:Element Type='Transform' OID='30a242ca-1ef5-4074-8d14-bd2ca45a5ae6' ParentLink='ComplexStatement_Statement' LowerBound='82.1' HigherBound='84.1'>
                                <om:Property Name='ClassName' Value='NWMessaging.MapCustomerOrderToAccountingInvoice' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Transform_2' />
                                <om:Property Name='Signal' Value='True' />
                                <om:Element Type='MessagePartRef' OID='0896db03-12a2-4ef8-a028-6886a45a0101' ParentLink='Transform_InputMessagePartRef' LowerBound='83.102' HigherBound='83.114'>
                                    <om:Property Name='MessageRef' Value='OrderMessage' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='MessagePartReference_3' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                                <om:Element Type='MessagePartRef' OID='3bd124b6-8f66-456a-acd9-c4b388eabc14' ParentLink='Transform_OutputMessagePartRef' LowerBound='83.32' HigherBound='83.49'>
                                    <om:Property Name='MessageRef' Value='AccountingRequest' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='MessagePartReference_4' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                            </om:Element>
                            <om:Element Type='MessageRef' OID='a3ecbe90-f464-4925-b64e-c6ed23a7d378' ParentLink='Construct_MessageRef' LowerBound='80.27' HigherBound='80.44'>
                                <om:Property Name='Ref' Value='AccountingRequest' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                        </om:Element>
                        <om:Element Type='Send' OID='cd0c1d2d-1476-492d-8e30-c3f7fc8bb3ce' ParentLink='ComplexStatement_Statement' LowerBound='85.1' HigherBound='87.1'>
                            <om:Property Name='PortName' Value='AccountingPort' />
                            <om:Property Name='MessageName' Value='AccountingRequest' />
                            <om:Property Name='OperationName' Value='Operation_1' />
                            <om:Property Name='OperationMessageName' Value='Request' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Send_AccountingRequest' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='DecisionBranch' OID='9b7e8b71-5f21-4f71-b0bf-f2afdfead6d9' ParentLink='ReallyComplexStatement_Branch'>
                        <om:Property Name='IsGhostBranch' Value='True' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Else' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
                <om:Element Type='Construct' OID='1cb56f74-b4e0-46d4-92ed-b56a84617c80' ParentLink='ServiceBody_Statement' LowerBound='88.1' HigherBound='94.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='ConstructMessage_3' />
                    <om:Property Name='Signal' Value='False' />
                    <om:Element Type='Transform' OID='4e8d6f5a-f3ea-410e-9485-20983be2cd8f' ParentLink='ComplexStatement_Statement' LowerBound='91.1' HigherBound='93.1'>
                        <om:Property Name='ClassName' Value='NWMessaging.MapWarehouseResponseToOrderResponse' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Transform_3' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='MessagePartRef' OID='5dcbaf9a-ffb5-40f7-ab2c-21da7de2652e' ParentLink='Transform_InputMessagePartRef' LowerBound='92.94' HigherBound='92.111'>
                            <om:Property Name='MessageRef' Value='WarehouseResponse' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='MessagePartReference_5' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='MessagePartRef' OID='466ffa40-7d3e-49bb-a847-c5ed143e8412' ParentLink='Transform_OutputMessagePartRef' LowerBound='92.28' HigherBound='92.41'>
                            <om:Property Name='MessageRef' Value='CustomerReply' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='MessagePartReference_6' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='MessageRef' OID='885338b6-f0aa-49a3-8f72-8fb058a09443' ParentLink='Construct_MessageRef' LowerBound='89.23' HigherBound='89.36'>
                        <om:Property Name='Ref' Value='CustomerReply' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
                <om:Element Type='VariableAssignment' OID='9282ebd0-fcf3-4004-ad22-0d99b3361cfd' ParentLink='ServiceBody_Statement' LowerBound='94.1' HigherBound='96.1'>
                    <om:Property Name='Expression' Value='CustomerAcknowledgementPort(Microsoft.XLANGs.BaseTypes.Address) = OrderMessage.ReplyAddress;' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Expression_1' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='Send' OID='c870f155-15ea-42ba-9a39-bad51ae68a75' ParentLink='ServiceBody_Statement' LowerBound='96.1' HigherBound='98.1'>
                    <om:Property Name='PortName' Value='CustomerAcknowledgementPort' />
                    <om:Property Name='MessageName' Value='CustomerReply' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Send_ClientNotification' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='67b67f8a-5679-4ef4-a370-1e25a31d6db5' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='46.1' HigherBound='48.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='3' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='NWBusinessProcesses.OrderReceivePortType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='OrderReceivePort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='5927cad6-2137-4177-be23-5ad3c4072129' ParentLink='PortDeclaration_CLRAttribute' LowerBound='46.1' HigherBound='47.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='9af6d9f2-0b47-4c37-9200-626116428f96' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='48.1' HigherBound='50.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='3' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='NWBusinessProcesses.WarehouseSendPortType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='WarehouseSendPort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='518d9bf3-1f59-4c54-ae35-ef03158042ee' ParentLink='PortDeclaration_CLRAttribute' LowerBound='48.1' HigherBound='49.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='e41868cd-fe9e-4327-ac7b-8acc36b20475' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='50.1' HigherBound='52.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='6' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='NWBusinessProcesses.WarehouseReceivePortType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='WarehouseReceivePort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='c8cb9297-e1c3-425e-8e09-1d94d5d696b6' ParentLink='PortDeclaration_CLRAttribute' LowerBound='50.1' HigherBound='51.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='99386b0b-232c-4d69-a416-caacc03b66f9' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='52.1' HigherBound='54.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='9' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='NWBusinessProcesses.AccountingPortType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='AccountingPort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='fd76c5bb-3f08-4477-a275-aefc00737074' ParentLink='PortDeclaration_CLRAttribute' LowerBound='52.1' HigherBound='53.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='bcb3bef9-e76b-48ef-9715-832e1197f565' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='54.1' HigherBound='56.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='16' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='NWBusinessProcesses.CustomerAckPortType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='CustomerAcknowledgementPort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='PhysicalBindingAttribute' OID='dbf9c529-cd04-43b8-9306-bdd9f1dc7d16' ParentLink='PortDeclaration_CLRAttribute' LowerBound='54.1' HigherBound='55.1'>
                    <om:Property Name='InPipeline' Value='Microsoft.BizTalk.DefaultPipelines.XMLReceive' />
                    <om:Property Name='OutPipeline' Value='Microsoft.BizTalk.DefaultPipelines.PassThruTransmit' />
                    <om:Property Name='TransportType' Value='HTTP' />
                    <om:Property Name='URI' Value='http://tempURI' />
                    <om:Property Name='IsDynamic' Value='True' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='CorrelationType' OID='96b2d6aa-db84-44e6-a986-3ae5340f7b71' ParentLink='Module_CorrelationType' LowerBound='39.1' HigherBound='43.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='CustomerPOCorrType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='PropertyRef' OID='c8e4cae4-4f70-44b3-aecd-496c5aaa4e55' ParentLink='CorrelationType_PropertyRef' LowerBound='41.9' HigherBound='41.37'>
                <om:Property Name='Ref' Value='NWMessaging.CustomerPONumber' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='PropertyRef_1' />
                <om:Property Name='Signal' Value='False' />
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __NWOrderProcessing_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __NWOrderProcessing_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "NWOrderProcessing")
            {
            }

            public override int Index { get { return 0; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[0]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[0]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                NWOrderProcessing __svc__ = (NWOrderProcessing)_service;
                __NWOrderProcessing_root_0 __ctx0__ = (__NWOrderProcessing_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.AccountingPort != null)
                {
                    __svc__.AccountingPort.Close(this, null);
                    __svc__.AccountingPort = null;
                }
                if (__svc__.WarehouseSendPort != null)
                {
                    __svc__.WarehouseSendPort.Close(this, null);
                    __svc__.WarehouseSendPort = null;
                }
                if (__svc__.WarehouseReceivePort != null)
                {
                    __svc__.WarehouseReceivePort.Close(this, null);
                    __svc__.WarehouseReceivePort = null;
                }
                if (__svc__.OrderReceivePort != null)
                {
                    __svc__.OrderReceivePort.Close(this, null);
                    __svc__.OrderReceivePort = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
        }


        [System.SerializableAttribute]
        public class __NWOrderProcessing_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __NWOrderProcessing_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "NWOrderProcessing")
            {
            }

            public override int Index { get { return 1; } }

            public override bool CombineParentCommit { get { return true; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[1]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[1]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                NWOrderProcessing __svc__ = (NWOrderProcessing)_service;
                __NWOrderProcessing_1 __ctx1__ = (__NWOrderProcessing_1)(__svc__._stateMgrs[1]);
                __NWOrderProcessing_root_0 __ctx0__ = (__NWOrderProcessing_root_0)(__svc__._stateMgrs[0]);

                if (__ctx1__ != null && __ctx1__.__subWrapper1 != null)
                {
                    __ctx1__.__subWrapper1.Destroy(__svc__, __ctx1__);
                    __ctx1__.__subWrapper1 = null;
                }
                if (__svc__.CustomerAcknowledgementPort != null)
                {
                    __svc__.CustomerAcknowledgementPort.Close(this, null);
                    __svc__.CustomerAcknowledgementPort = null;
                }
                if (__ctx1__ != null && __ctx1__.__WarehouseRequest != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__WarehouseRequest);
                    __ctx1__.__WarehouseRequest = null;
                }
                if (__ctx1__ != null && __ctx1__.__OrderMessage != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__OrderMessage);
                    __ctx1__.__OrderMessage = null;
                }
                if (__ctx1__ != null && __ctx1__.__CustomerReply != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__CustomerReply);
                    __ctx1__.__CustomerReply = null;
                }
                if (__ctx1__ != null && __ctx1__.__WarehouseResponse != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__WarehouseResponse);
                    __ctx1__.__WarehouseResponse = null;
                }
                if (__ctx1__ != null && __ctx1__.__AccountingRequest != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__AccountingRequest);
                    __ctx1__.__AccountingRequest = null;
                }
                if (__ctx1__ != null && __ctx1__.__CustomerOrderCorrelation != null)
                    __ctx1__.__CustomerOrderCorrelation = null;
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("OrderMessage")]
            public __messagetype_NWMessaging_CustomerOrder __OrderMessage;
            [Microsoft.XLANGs.Core.UserVariableAttribute("CustomerReply")]
            public __messagetype_NWMessaging_OrderResponse __CustomerReply;
            [Microsoft.XLANGs.Core.UserVariableAttribute("WarehouseRequest")]
            public __messagetype_NWMessaging_WarehouseShipRequest __WarehouseRequest;
            [Microsoft.XLANGs.Core.UserVariableAttribute("WarehouseResponse")]
            public __messagetype_NWMessaging_DistResp __WarehouseResponse;
            [Microsoft.XLANGs.Core.UserVariableAttribute("AccountingRequest")]
            public __messagetype_NWMessaging_AccountingInvoice __AccountingRequest;
            [Microsoft.XLANGs.Core.UserVariableAttribute("CustomerOrderCorrelation")]
            internal Microsoft.XLANGs.Core.Correlation __CustomerOrderCorrelation;
            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper1;
        }

        private static Microsoft.XLANGs.Core.CorrelationType[] _correlationTypes = new Microsoft.XLANGs.Core.CorrelationType[] { new CustomerPOCorrType() };
        public override Microsoft.XLANGs.Core.CorrelationType[] CorrelationTypes { get { return _correlationTypes; } }

        private static System.Guid[] _convoySetIds;

        public override System.Guid[] ConvoySetGuids
        {
            get { return _convoySetIds; }
            set { _convoySetIds = value; }
        }

        public static object[] StaticConvoySetInformation
        {
            get {
                return null;
            }
        }

        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("OrderReceivePort")]
        internal OrderReceivePortType OrderReceivePort;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("WarehouseSendPort")]
        internal WarehouseSendPortType WarehouseSendPort;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("WarehouseReceivePort")]
        internal WarehouseReceivePortType WarehouseReceivePort;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("AccountingPort")]
        internal AccountingPortType AccountingPort;
        [Microsoft.XLANGs.BaseTypes.PhysicalBindingAttribute(typeof(Microsoft.BizTalk.DefaultPipelines.PassThruTransmit))]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eDynamic
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("CustomerAcknowledgementPort")]
        internal CustomerAckPortType CustomerAcknowledgementPort;  // lock index = 0

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {OrderReceivePortType.Operation_1},
                                               typeof(NWOrderProcessing).GetField("OrderReceivePort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(NWOrderProcessing), "OrderReceivePort"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {WarehouseSendPortType.Operation_1},
                                               typeof(NWOrderProcessing).GetField("WarehouseSendPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(NWOrderProcessing), "WarehouseSendPort"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {WarehouseReceivePortType.Operation_1},
                                               typeof(NWOrderProcessing).GetField("WarehouseReceivePort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(NWOrderProcessing), "WarehouseReceivePort"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {AccountingPortType.Operation_1},
                                               typeof(NWOrderProcessing).GetField("AccountingPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(NWOrderProcessing), "AccountingPort"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {CustomerAckPortType.Operation_1},
                                               typeof(NWOrderProcessing).GetField("CustomerAcknowledgementPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               true,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(NWOrderProcessing), "CustomerAcknowledgementPort"),
                                               null)
        };

        public override Microsoft.XLANGs.Core.PortInfo[] PortInformation
        {
            get { return _portInfo; }
        }

        static public System.Collections.Hashtable PortsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[_portInfo[0].Name] = _portInfo[0];
                h[_portInfo[1].Name] = _portInfo[1];
                h[_portInfo[2].Name] = _portInfo[2];
                h[_portInfo[3].Name] = _portInfo[3];
                h[_portInfo[4].Name] = _portInfo[4];
                return h;
            }
        }

        public static System.Type[] InvokedServicesTypes
        {
            get
            {
                return new System.Type[] {
                    // type of each service invoked by this service
                };
            }
        }

        public static System.Type[] CalledServicesTypes
        {
            get
            {
                return new System.Type[] {
                };
            }
        }

        public static System.Type[] ExecedServicesTypes
        {
            get
            {
                return new System.Type[] {
                };
            }
        }

        public static object[] StaticSubscriptionsInformation {
            get {
                return new object[1]{
                     new object[5] { _portInfo[0], 0, null , -1, true }
                };
            }
        }

        public static Microsoft.XLANGs.RuntimeTypes.Location[] __eventLocations = new Microsoft.XLANGs.RuntimeTypes.Location[] {
            new Microsoft.XLANGs.RuntimeTypes.Location(0, "00000000-0000-0000-0000-000000000000", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "92734ffb-9dc2-46af-81e3-dae6bec13f33", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "92734ffb-9dc2-46af-81e3-dae6bec13f33", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "66c2a08c-cd0b-4160-8508-847e330f2c61", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "66c2a08c-cd0b-4160-8508-847e330f2c61", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "7e3c7e3d-4433-43b6-86cd-300527819c3f", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "7e3c7e3d-4433-43b6-86cd-300527819c3f", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "41300a3d-d69e-4300-a0a0-829095e1a5cf", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "41300a3d-d69e-4300-a0a0-829095e1a5cf", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "9568da08-0224-4e59-a2ba-34f4e8348a18", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(10, "a4cc8474-93d0-4faf-baf2-2c618de337f8", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(11, "a4cc8474-93d0-4faf-baf2-2c618de337f8", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(12, "cd0c1d2d-1476-492d-8e30-c3f7fc8bb3ce", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(13, "cd0c1d2d-1476-492d-8e30-c3f7fc8bb3ce", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(14, "9568da08-0224-4e59-a2ba-34f4e8348a18", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(15, "1cb56f74-b4e0-46d4-92ed-b56a84617c80", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(16, "1cb56f74-b4e0-46d4-92ed-b56a84617c80", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(17, "9282ebd0-fcf3-4004-ad22-0d99b3361cfd", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(18, "9282ebd0-fcf3-4004-ad22-0d99b3361cfd", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(19, "c870f155-15ea-42ba-9a39-bad51ae68a75", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(20, "c870f155-15ea-42ba-9a39-bad51ae68a75", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(21, "00000000-0000-0000-0000-000000000000", 1, false)
        };

        public override Microsoft.XLANGs.RuntimeTypes.Location[] EventLocations
        {
            get { return __eventLocations; }
        }

        public static Microsoft.XLANGs.RuntimeTypes.EventData[] __eventData = new Microsoft.XLANGs.RuntimeTypes.EventData[] {
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Receive),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Construct),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Send),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.If),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.If),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Expression),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Expression),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,21,21,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,2,3,3,4,5,5,5,6,7,7,8,9,9,10,10,11,12,12,12,13,14,15,15,16,17,17,18,19,19,19,20,21,21,21,21,};

        public static int[][] __progressLocations = new int[2] [] {__progressLocation0,__progressLocation1};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __NWOrderProcessing_1 __ctx1__ = (__NWOrderProcessing_1)_stateMgrs[1];
            __NWOrderProcessing_root_0 __ctx0__ = (__NWOrderProcessing_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                OrderReceivePort = new OrderReceivePortType(0, this);
                WarehouseSendPort = new WarehouseSendPortType(1, this);
                WarehouseReceivePort = new WarehouseReceivePortType(2, this);
                AccountingPort = new AccountingPortType(3, this);
                CustomerAcknowledgementPort = new CustomerAckPortType(4, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], OrderReceivePort, this);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __NWOrderProcessing_1(this);
                _stateMgrs[1] = __ctx1__;
                if ( !PostProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 2;
            case 2:
                __ctx0__.StartContext(__seg__, __ctx1__);
                if ( !PostProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 3:
                if (!__ctx0__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                __ctx1__.Finally();
                ServiceDone(__seg__, (Microsoft.XLANGs.Core.Context)_stateMgrs[0]);
                __ctx0__.OnCommit();
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment1(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Envelope __msgEnv__ = null;
            bool __condition__;
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[1];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[1];
            __NWOrderProcessing_1 __ctx1__ = (__NWOrderProcessing_1)_stateMgrs[1];
            __NWOrderProcessing_root_0 __ctx0__ = (__NWOrderProcessing_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                if ( !PreProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[0],__eventData[0],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[1],__eventData[1],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                if (!OrderReceivePort.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__OrderMessage != null)
                    __ctx1__.UnrefMessage(__ctx1__.__OrderMessage);
                __ctx1__.__OrderMessage = new __messagetype_NWMessaging_CustomerOrder("OrderMessage", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__OrderMessage);
                OrderReceivePort.ReceiveMessage(0, __msgEnv__, __ctx1__.__OrderMessage, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if (OrderReceivePort != null)
                {
                    OrderReceivePort.Close(__ctx1__, __seg__);
                    OrderReceivePort = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__OrderMessage);
                    __edata.PortName = @"OrderReceivePort";
                    Tracker.FireEvent(__eventLocations[2],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                if ( !PreProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 6;
            case 6:
                {
                    __messagetype_NWMessaging_WarehouseShipRequest __WarehouseRequest = new __messagetype_NWMessaging_WarehouseShipRequest("WarehouseRequest", __ctx1__);

                    ApplyTransform(typeof(NWMessaging.MapOrderToShipRequest), new object[] {__WarehouseRequest.part}, new object[] {__ctx1__.__OrderMessage.part});

                    if (__ctx1__.__WarehouseRequest != null)
                        __ctx1__.UnrefMessage(__ctx1__.__WarehouseRequest);
                    __ctx1__.__WarehouseRequest = __WarehouseRequest;
                    __ctx1__.RefMessage(__ctx1__.__WarehouseRequest);
                }
                __ctx1__.__WarehouseRequest.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                if ( !PreProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__WarehouseRequest);
                    __edata.Messages.Add(__ctx1__.__OrderMessage);
                    Tracker.FireEvent(__eventLocations[4],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 8;
            case 8:
                if ( !PreProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[5],__eventData[3],_stateMgrs[1].TrackDataStream );
                __ctx1__.__subWrapper1 = new Microsoft.XLANGs.Core.SubscriptionWrapper(1, System.Guid.Empty, WarehouseReceivePort, 0, __ctx0__);
                __ctx1__.__CustomerOrderCorrelation = new Microsoft.XLANGs.Core.Correlation(this, 0, 1);
                __ctx1__.__CustomerOrderCorrelation.AddSubscription(((__NWOrderProcessing_1)_stateMgrs[1]).__subWrapper1.getSubscription(this), __ctx1__);
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 9;
            case 9:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 10;
            case 10:
                if ( !PreProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                WarehouseSendPort.SendMessage(0, __ctx1__.__WarehouseRequest, new Microsoft.XLANGs.Core.Correlation[] { __ctx1__.__CustomerOrderCorrelation }, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
                if (WarehouseSendPort != null)
                {
                    WarehouseSendPort.Close(__ctx1__, __seg__);
                    WarehouseSendPort = null;
                }
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 11;
            case 11:
                if ( !PreProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__WarehouseRequest);
                    __edata.PortName = @"WarehouseSendPort";
                    Tracker.FireEvent(__eventLocations[6],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__WarehouseRequest != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__WarehouseRequest);
                    __ctx1__.__WarehouseRequest = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 12;
            case 12:
                if ( !PreProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[7],__eventData[1],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 13;
            case 13:
                if (!WarehouseReceivePort.GetMessageId(__ctx1__.__subWrapper1.getSubscription(this), __seg__, __ctx1__, out __msgEnv__, _locations[0]))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__ != null && __ctx1__.__subWrapper1 != null)
                {
                    __ctx1__.__subWrapper1.Destroy(this, __ctx1__);
                    __ctx1__.__subWrapper1 = null;
                }
                if (__ctx1__.__WarehouseResponse != null)
                    __ctx1__.UnrefMessage(__ctx1__.__WarehouseResponse);
                __ctx1__.__WarehouseResponse = new __messagetype_NWMessaging_DistResp("WarehouseResponse", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__WarehouseResponse);
                WarehouseReceivePort.ReceiveMessage(0, __msgEnv__, __ctx1__.__WarehouseResponse, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if (__ctx1__ != null && __ctx1__.__CustomerOrderCorrelation != null)
                    __ctx1__.__CustomerOrderCorrelation = null;
                if (WarehouseReceivePort != null)
                {
                    WarehouseReceivePort.Close(__ctx1__, __seg__);
                    WarehouseReceivePort = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 14;
            case 14:
                if ( !PreProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__WarehouseResponse);
                    __edata.PortName = @"WarehouseReceivePort";
                    Tracker.FireEvent(__eventLocations[8],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 15;
            case 15:
                if ( !PreProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[9],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 16;
            case 16:
                __condition__ = (System.String)__ctx1__.__WarehouseResponse.part.GetDistinguishedField("Status") == "Shipped";
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 24 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 24;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 17;
            case 17:
                if ( !PreProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[10],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 18;
            case 18:
                {
                    __messagetype_NWMessaging_AccountingInvoice __AccountingRequest = new __messagetype_NWMessaging_AccountingInvoice("AccountingRequest", __ctx1__);

                    ApplyTransform(typeof(NWMessaging.MapCustomerOrderToAccountingInvoice), new object[] {__AccountingRequest.part}, new object[] {__ctx1__.__OrderMessage.part});

                    if (__ctx1__.__AccountingRequest != null)
                        __ctx1__.UnrefMessage(__ctx1__.__AccountingRequest);
                    __ctx1__.__AccountingRequest = __AccountingRequest;
                    __ctx1__.RefMessage(__ctx1__.__AccountingRequest);
                }
                __ctx1__.__AccountingRequest.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 19;
            case 19:
                if ( !PreProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__AccountingRequest);
                    __edata.Messages.Add(__ctx1__.__OrderMessage);
                    Tracker.FireEvent(__eventLocations[11],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 20;
            case 20:
                if ( !PreProgressInc( __seg__, __ctx__, 21 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[12],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 21;
            case 21:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 22 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 22;
            case 22:
                if ( !PreProgressInc( __seg__, __ctx__, 23 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                AccountingPort.SendMessage(0, __ctx1__.__AccountingRequest, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 23;
            case 23:
                if ( !PreProgressInc( __seg__, __ctx__, 24 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__AccountingRequest);
                    __edata.PortName = @"AccountingPort";
                    Tracker.FireEvent(__eventLocations[13],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__AccountingRequest != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__AccountingRequest);
                    __ctx1__.__AccountingRequest = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 24;
            case 24:
                if ( !PreProgressInc( __seg__, __ctx__, 25 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (AccountingPort != null)
                {
                    AccountingPort.Close(__ctx1__, __seg__);
                    AccountingPort = null;
                }
                Tracker.FireEvent(__eventLocations[14],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 25;
            case 25:
                if ( !PreProgressInc( __seg__, __ctx__, 26 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[15],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 26;
            case 26:
                {
                    __messagetype_NWMessaging_OrderResponse __CustomerReply = new __messagetype_NWMessaging_OrderResponse("CustomerReply", __ctx1__);

                    ApplyTransform(typeof(NWMessaging.MapWarehouseResponseToOrderResponse), new object[] {__CustomerReply.part}, new object[] {__ctx1__.__WarehouseResponse.part});

                    if (__ctx1__.__CustomerReply != null)
                        __ctx1__.UnrefMessage(__ctx1__.__CustomerReply);
                    __ctx1__.__CustomerReply = __CustomerReply;
                    __ctx1__.RefMessage(__ctx1__.__CustomerReply);
                }
                __ctx1__.__CustomerReply.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 27 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 27;
            case 27:
                if ( !PreProgressInc( __seg__, __ctx__, 28 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__CustomerReply);
                    __edata.Messages.Add(__ctx1__.__WarehouseResponse);
                    Tracker.FireEvent(__eventLocations[16],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__WarehouseResponse != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__WarehouseResponse);
                    __ctx1__.__WarehouseResponse = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 28;
            case 28:
                if ( !PreProgressInc( __seg__, __ctx__, 29 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[17],__eventData[6],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 29;
            case 29:
                CustomerAcknowledgementPort.SetPropertyValue(typeof(Microsoft.XLANGs.BaseTypes.Address), (System.String)__ctx1__.__OrderMessage.part.GetDistinguishedField("ReplyAddress"));
                if (__ctx1__ != null && __ctx1__.__OrderMessage != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__OrderMessage);
                    __ctx1__.__OrderMessage = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 30 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 30;
            case 30:
                if ( !PreProgressInc( __seg__, __ctx__, 31 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[18],__eventData[7],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 31;
            case 31:
                if ( !PreProgressInc( __seg__, __ctx__, 32 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[19],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 32;
            case 32:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 33 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 33;
            case 33:
                if ( !PreProgressInc( __seg__, __ctx__, 34 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                CustomerAcknowledgementPort.SendMessage(0, __ctx1__.__CustomerReply, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.NextActivityPersists );
                if (CustomerAcknowledgementPort != null)
                {
                    CustomerAcknowledgementPort.Close(__ctx1__, __seg__);
                    CustomerAcknowledgementPort = null;
                }
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 34;
            case 34:
                if ( !PreProgressInc( __seg__, __ctx__, 35 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__CustomerReply);
                    __edata.PortName = @"CustomerAcknowledgementPort";
                    Tracker.FireEvent(__eventLocations[20],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__CustomerReply != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__CustomerReply);
                    __ctx1__.__CustomerReply = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 35;
            case 35:
                if ( !PreProgressInc( __seg__, __ctx__, 36 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[21],__eventData[8],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 36;
            case 36:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 37 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 37;
            case 37:
                if ( !PreProgressInc( __seg__, __ctx__, 38 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 38;
            case 38:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
        private static Microsoft.XLANGs.Core.CachedObject[] _locations = new Microsoft.XLANGs.Core.CachedObject[] {
            new Microsoft.XLANGs.Core.CachedObject(new System.Guid("{D53161F6-4CBA-4A37-B4D7-0B55F0B52850}"))
        };

    }

    [System.SerializableAttribute]
    sealed public class __NWMessaging_CustomerOrder__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static NWMessaging.CustomerOrder _schema = new NWMessaging.CustomerOrder();

        public __NWMessaging_CustomerOrder__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "NWMessaging.CustomerOrder",
        new System.Type[]{
            typeof(NWMessaging.CustomerOrder)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__NWMessaging_CustomerOrder__)
        },
        0,
        @"http://NWMessaging.CustomerOrder#CustomerOrder"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_NWMessaging_CustomerOrder : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __NWMessaging_CustomerOrder__ part;

        private void __CreatePartWrappers()
        {
            part = new __NWMessaging_CustomerOrder__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_NWMessaging_CustomerOrder(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __NWMessaging_WarehouseShipRequest__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static NWMessaging.WarehouseShipRequest _schema = new NWMessaging.WarehouseShipRequest();

        public __NWMessaging_WarehouseShipRequest__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "NWMessaging.WarehouseShipRequest",
        new System.Type[]{
            typeof(NWMessaging.WarehouseShipRequest)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__NWMessaging_WarehouseShipRequest__)
        },
        0,
        @"http://NWMessaging.WarehouseShipRequest#ShipRequest"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_NWMessaging_WarehouseShipRequest : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __NWMessaging_WarehouseShipRequest__ part;

        private void __CreatePartWrappers()
        {
            part = new __NWMessaging_WarehouseShipRequest__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_NWMessaging_WarehouseShipRequest(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __NWMessaging_DistResp__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static NWMessaging.DistResp _schema = new NWMessaging.DistResp();

        public __NWMessaging_DistResp__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "NWMessaging.DistResp",
        new System.Type[]{
            typeof(NWMessaging.DistResp)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__NWMessaging_DistResp__)
        },
        0,
        @"http://NWMessaging.DistResp#WarehouseResponse"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_NWMessaging_DistResp : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __NWMessaging_DistResp__ part;

        private void __CreatePartWrappers()
        {
            part = new __NWMessaging_DistResp__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_NWMessaging_DistResp(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __NWMessaging_AccountingInvoice__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static NWMessaging.AccountingInvoice _schema = new NWMessaging.AccountingInvoice();

        public __NWMessaging_AccountingInvoice__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "NWMessaging.AccountingInvoice",
        new System.Type[]{
            typeof(NWMessaging.AccountingInvoice)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__NWMessaging_AccountingInvoice__)
        },
        0,
        @"http://NWMessaging.AccountingInvoice#Invoice"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_NWMessaging_AccountingInvoice : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __NWMessaging_AccountingInvoice__ part;

        private void __CreatePartWrappers()
        {
            part = new __NWMessaging_AccountingInvoice__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_NWMessaging_AccountingInvoice(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __NWMessaging_OrderResponse__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static NWMessaging.OrderResponse _schema = new NWMessaging.OrderResponse();

        public __NWMessaging_OrderResponse__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "NWMessaging.OrderResponse",
        new System.Type[]{
            typeof(NWMessaging.OrderResponse)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__NWMessaging_OrderResponse__)
        },
        0,
        @"http://NWMessaging.OrderResponse#OrderResponse"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_NWMessaging_OrderResponse : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __NWMessaging_OrderResponse__ part;

        private void __CreatePartWrappers()
        {
            part = new __NWMessaging_OrderResponse__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_NWMessaging_OrderResponse(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class _MODULE_PROXY_ { }
}
