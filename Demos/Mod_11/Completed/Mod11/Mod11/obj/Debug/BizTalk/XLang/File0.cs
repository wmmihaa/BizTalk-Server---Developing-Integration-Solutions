
#pragma warning disable 162

namespace Mod11
{

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(Mod11.__messagetype_Mod11_Order)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class OrderPortType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public OrderPortType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public OrderPortType(OrderPortType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            OrderPortType p = new OrderPortType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(OrderPortType),
            typeof(__messagetype_Mod11_Order),
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
            "Mod11.PropertySchema.OrderId"
        }
    )]
    sealed internal class OrderIdCorrelationType : Microsoft.XLANGs.Core.CorrelationType
    {
        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        private static Microsoft.XLANGs.BaseTypes.PropertyBase[] _properties = new Microsoft.XLANGs.BaseTypes.PropertyBase[] {
            new Mod11.PropertySchema.OrderId()
         };
        public override Microsoft.XLANGs.BaseTypes.PropertyBase[] Properties { get { return _properties; } }
        public static Microsoft.XLANGs.BaseTypes.PropertyBase[] PropertiesList { get { return _properties; } }
    }
    //#line 297 "C:\Demos\Mod_11\Completed\Mod11\Mod11\OrderApprovalProcess.odx"
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "ReceiveOrderPort", "Operation_1", -1, -1, true
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(Mod11.OrderPortType),
            typeof(Mod11.OrderPortType),
            typeof(Mod11.OrderPortType),
            typeof(Mod11.OrderPortType),
            typeof(Mod11.OrderPortType)
        },
        new System.String[] {
            "ReceiveOrderPort",
            "SendOrderForApprovalPort",
            "ReceiveApprovalPort",
            "SendApprovedOrderPort",
            "SendDendiedOrderPort"
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
    sealed internal class OrderApprovalProcess : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
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
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(OrderApprovalProcess));
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

        static OrderApprovalProcess()
        {
            Microsoft.BizTalk.XLANGs.BTXEngine.BTXService.CacheStaticState( _serviceId );
        }

        private void ConstructorHelper()
        {
            _segments = new Microsoft.XLANGs.Core.Segment[] {
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment0), 0, 0, 0),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment1), 1, 1, 1),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment2), 1, 2, 2)
            };

            _Locks = 0;
            _rootContext = new __OrderApprovalProcess_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[3];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public OrderApprovalProcess(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "OrderApprovalProcess", tracker)
        {
            ConstructorHelper();
        }

        public OrderApprovalProcess(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "OrderApprovalProcess")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>82689c05-0088-440d-b2fd-b80d25e1b0b0</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>20bf35ee-f897-4eda-91a1-a4c8cef11949</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive Order</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>CallRulesShape</shapeType>      <ShapeID>3199e3b4-b41f-46c6-b951-cdd7672f82c4</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>CallRules_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>RulesParameterRefShape</shapeType>      <ShapeID>5c5423db-7dfb-4d34-a267-a6b83cf9d000</ShapeID>      <ParentLink>CallRules_RulesParameterRef</ParentLink>                <shapeText>RulesParameterRef_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionShape</shapeType>      <ShapeID>a03a8772-6247-4583-a1b3-61fc205d35be</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>AutoApproved?</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>e4eeae97-f194-4463-906e-a6406edeb3a9</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Approved</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>8701d8e7-93a1-47aa-8883-0c4335486953</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ConstructMessage_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>822eb35b-1b71-4fe5-9bb6-7630f3dcb9ae</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>MessageAssignment_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>aae3bbf7-6665-46ed-bb9e-a9f72f222b9e</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>bae15e7c-ff0d-4be7-af77-69b7a594cd0e</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Else</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>ebf1d608-5b47-4f84-9db4-02dfd0cae287</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send For Approval</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>ab67007b-3863-4269-b558-2a596cbe8ec7</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Receive Approval</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionShape</shapeType>      <ShapeID>a2958b76-959a-4e64-964e-2a02fa3cdeb0</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Approved?</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>f9e40e05-56d1-4061-82f8-51db63b3df14</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Approved</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>38141826-fc43-4984-a87d-09f73bbcfe30</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send Order</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>1f6b7e99-982d-49d7-92c3-fe6af2621b8e</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Else</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>80c13873-2004-43b8-ac63-80aa01cb73c5</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send Denied</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'OrderApprovalProcess'</ActionName><IsAtomic>0</IsAtomic><Line>297</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>315</Line><Position>22</Position><ShapeID>'20bf35ee-f897-4eda-91a1-a4c8cef11949'</ShapeID>
<Messages>
	<MsgInfo><name>OrderIn</name><part>part</part><schema>Mod11.Order</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<ActionName>'??__scope33'</ActionName><IsAtomic>0</IsAtomic><Line>318</Line><Position>13</Position><ShapeID>'3199e3b4-b41f-46c6-b951-cdd7672f82c4'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>341</Line><Position>13</Position><ShapeID>'a03a8772-6247-4583-a1b3-61fc205d35be'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>344</Line><Position>17</Position><ShapeID>'8701d8e7-93a1-47aa-8883-0c4335486953'</ShapeID>
<Messages>
	<MsgInfo><name>ApprovedOrder</name><part>part</part><schema>Mod11.Order</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>353</Line><Position>17</Position><ShapeID>'ebf1d608-5b47-4f84-9db4-02dfd0cae287'</ShapeID>
<Messages>
	<MsgInfo><name>OrderIn</name><part>part</part><schema>Mod11.Order</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>355</Line><Position>17</Position><ShapeID>'ab67007b-3863-4269-b558-2a596cbe8ec7'</ShapeID>
<Messages>
	<MsgInfo><name>ApprovedOrder</name><part>part</part><schema>Mod11.Order</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>358</Line><Position>13</Position><ShapeID>'a2958b76-959a-4e64-964e-2a02fa3cdeb0'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>361</Line><Position>17</Position><ShapeID>'38141826-fc43-4984-a87d-09f73bbcfe30'</ShapeID>
<Messages>
	<MsgInfo><name>ApprovedOrder</name><part>part</part><schema>Mod11.Order</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>366</Line><Position>17</Position><ShapeID>'80c13873-2004-43b8-ac63-80aa01cb73c5'</ShapeID>
<Messages>
	<MsgInfo><name>ApprovedOrder</name><part>part</part><schema>Mod11.Order</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='96bccdb9-4e33-496a-a48e-48de00f64a59' LowerBound='1.1' HigherBound='90.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='Mod11' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='62172470-87e3-4474-b808-57d3ab38cccf' ParentLink='Module_PortType' LowerBound='4.1' HigherBound='11.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='OrderPortType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='OperationDeclaration' OID='d634f3d3-785c-48bc-be71-d06651caa7d7' ParentLink='PortType_OperationDeclaration' LowerBound='6.1' HigherBound='10.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='b8125cd2-74c7-4c73-9c0a-f5dc3fd4ece8' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='8.13' HigherBound='8.18'>
                    <om:Property Name='Ref' Value='Mod11.Order' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='CorrelationType' OID='b2085d88-c76c-4a11-91a8-f525f8f98100' ParentLink='Module_CorrelationType' LowerBound='11.1' HigherBound='15.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='OrderIdCorrelationType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='PropertyRef' OID='4c00ded7-014d-4eb8-ad6d-e11893db3f67' ParentLink='CorrelationType_PropertyRef' LowerBound='13.9' HigherBound='13.31'>
                <om:Property Name='Ref' Value='Mod11.PropertySchema.OrderId' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='PropertyRef_1' />
                <om:Property Name='Signal' Value='False' />
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='d8776a8e-020d-46ca-bb5c-f8cc0f237bb2' ParentLink='Module_ServiceDeclaration' LowerBound='15.1' HigherBound='89.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='OrderApprovalProcess' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='CorrelationDeclaration' OID='f2ede05e-3c87-4056-83cb-999b3828a7da' ParentLink='ServiceDeclaration_CorrelationDeclaration' LowerBound='28.1' HigherBound='29.1'>
                <om:Property Name='Type' Value='Mod11.OrderIdCorrelationType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='OrderIdCorrelation' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='StatementRef' OID='031e8fe9-9da0-40c6-b1c2-390c10283f65' ParentLink='CorrelationDeclaration_StatementRef' LowerBound='72.70' HigherBound='72.99'>
                    <om:Property Name='Initializes' Value='True' />
                    <om:Property Name='Ref' Value='ebf1d608-5b47-4f84-9db4-02dfd0cae287' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='StatementRef_1' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='StatementRef' OID='620e19a2-df06-4966-81c4-805313c183e2' ParentLink='CorrelationDeclaration_StatementRef' LowerBound='74.74' HigherBound='74.92'>
                    <om:Property Name='Initializes' Value='False' />
                    <om:Property Name='Ref' Value='ab67007b-3863-4269-b558-2a596cbe8ec7' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='StatementRef_2' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='8baaa874-5e2f-468c-9a58-0742044c6872' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='29.1' HigherBound='30.1'>
                <om:Property Name='Type' Value='Mod11.Order' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='OrderIn' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='c1a64507-98fc-457e-8b21-1ac349d3dc78' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='30.1' HigherBound='31.1'>
                <om:Property Name='Type' Value='Mod11.Order' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ApprovedOrder' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='82689c05-0088-440d-b2fd-b80d25e1b0b0' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='20bf35ee-f897-4eda-91a1-a4c8cef11949' ParentLink='ServiceBody_Statement' LowerBound='33.1' HigherBound='35.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='ReceiveOrderPort' />
                    <om:Property Name='MessageName' Value='OrderIn' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive Order' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='CallRules' OID='3199e3b4-b41f-46c6-b951-cdd7672f82c4' ParentLink='ServiceBody_Statement' LowerBound='35.1' HigherBound='59.1'>
                    <om:Property Name='PolicyName' Value='OrderPolicy' />
                    <om:Property Name='PolicyVersion' Value='-1' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='CallRules_1' />
                    <om:Property Name='Signal' Value='False' />
                    <om:Element Type='RulesParameterRef' OID='5c5423db-7dfb-4d34-a267-a6b83cf9d000' ParentLink='CallRules_RulesParameterRef'>
                        <om:Property Name='Reference' Value='OrderIn' />
                        <om:Property Name='Alias' Value='Mod11.Order' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='RulesParameterRef_1' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
                <om:Element Type='Decision' OID='a03a8772-6247-4583-a1b3-61fc205d35be' ParentLink='ServiceBody_Statement' LowerBound='59.1' HigherBound='76.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='AutoApproved?' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='DecisionBranch' OID='e4eeae97-f194-4463-906e-a6406edeb3a9' ParentLink='ReallyComplexStatement_Branch' LowerBound='60.13' HigherBound='69.1'>
                        <om:Property Name='Expression' Value='OrderIn.Approved == true' />
                        <om:Property Name='IsGhostBranch' Value='True' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Approved' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='Construct' OID='8701d8e7-93a1-47aa-8883-0c4335486953' ParentLink='ComplexStatement_Statement' LowerBound='62.1' HigherBound='68.1'>
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='ConstructMessage_1' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='MessageAssignment' OID='822eb35b-1b71-4fe5-9bb6-7630f3dcb9ae' ParentLink='ComplexStatement_Statement' LowerBound='65.1' HigherBound='67.1'>
                                <om:Property Name='Expression' Value='ApprovedOrder = OrderIn;' />
                                <om:Property Name='ReportToAnalyst' Value='False' />
                                <om:Property Name='Name' Value='MessageAssignment_1' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                            <om:Element Type='MessageRef' OID='aae3bbf7-6665-46ed-bb9e-a9f72f222b9e' ParentLink='Construct_MessageRef' LowerBound='63.27' HigherBound='63.40'>
                                <om:Property Name='Ref' Value='ApprovedOrder' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                        </om:Element>
                    </om:Element>
                    <om:Element Type='DecisionBranch' OID='bae15e7c-ff0d-4be7-af77-69b7a594cd0e' ParentLink='ReallyComplexStatement_Branch'>
                        <om:Property Name='IsGhostBranch' Value='True' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Else' />
                        <om:Property Name='Signal' Value='False' />
                        <om:Element Type='Send' OID='ebf1d608-5b47-4f84-9db4-02dfd0cae287' ParentLink='ComplexStatement_Statement' LowerBound='71.1' HigherBound='73.1'>
                            <om:Property Name='PortName' Value='SendOrderForApprovalPort' />
                            <om:Property Name='MessageName' Value='OrderIn' />
                            <om:Property Name='OperationName' Value='Operation_1' />
                            <om:Property Name='OperationMessageName' Value='Request' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Send For Approval' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                        <om:Element Type='Receive' OID='ab67007b-3863-4269-b558-2a596cbe8ec7' ParentLink='ComplexStatement_Statement' LowerBound='73.1' HigherBound='75.1'>
                            <om:Property Name='Activate' Value='False' />
                            <om:Property Name='PortName' Value='ReceiveApprovalPort' />
                            <om:Property Name='MessageName' Value='ApprovedOrder' />
                            <om:Property Name='OperationName' Value='Operation_1' />
                            <om:Property Name='OperationMessageName' Value='Request' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Receive Approval' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                    </om:Element>
                </om:Element>
                <om:Element Type='Decision' OID='a2958b76-959a-4e64-964e-2a02fa3cdeb0' ParentLink='ServiceBody_Statement' LowerBound='76.1' HigherBound='87.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Approved?' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='DecisionBranch' OID='f9e40e05-56d1-4061-82f8-51db63b3df14' ParentLink='ReallyComplexStatement_Branch' LowerBound='77.13' HigherBound='82.1'>
                        <om:Property Name='Expression' Value='ApprovedOrder.Approved == true' />
                        <om:Property Name='IsGhostBranch' Value='True' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Approved' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='Send' OID='38141826-fc43-4984-a87d-09f73bbcfe30' ParentLink='ComplexStatement_Statement' LowerBound='79.1' HigherBound='81.1'>
                            <om:Property Name='PortName' Value='SendApprovedOrderPort' />
                            <om:Property Name='MessageName' Value='ApprovedOrder' />
                            <om:Property Name='OperationName' Value='Operation_1' />
                            <om:Property Name='OperationMessageName' Value='Request' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Send Order' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='DecisionBranch' OID='1f6b7e99-982d-49d7-92c3-fe6af2621b8e' ParentLink='ReallyComplexStatement_Branch'>
                        <om:Property Name='IsGhostBranch' Value='True' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Else' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='Send' OID='80c13873-2004-43b8-ac63-80aa01cb73c5' ParentLink='ComplexStatement_Statement' LowerBound='84.1' HigherBound='86.1'>
                            <om:Property Name='PortName' Value='SendDendiedOrderPort' />
                            <om:Property Name='MessageName' Value='ApprovedOrder' />
                            <om:Property Name='OperationName' Value='Operation_1' />
                            <om:Property Name='OperationMessageName' Value='Request' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Send Denied' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                    </om:Element>
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='881adcd7-e7ba-448e-8e89-60e939a2d43a' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='18.1' HigherBound='20.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='Mod11.OrderPortType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ReceiveOrderPort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='1333057b-f275-449a-afc6-6dcfc29b2184' ParentLink='PortDeclaration_CLRAttribute' LowerBound='18.1' HigherBound='19.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='685436ef-a067-4cf1-af41-a007bf1e68f9' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='20.1' HigherBound='22.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='3' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='Mod11.OrderPortType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SendOrderForApprovalPort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='6ad714e2-1b52-4d37-9a25-bed31dfe38be' ParentLink='PortDeclaration_CLRAttribute' LowerBound='20.1' HigherBound='21.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='5de9f9af-176d-4ef8-a4f5-feffd07b9749' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='22.1' HigherBound='24.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='Mod11.OrderPortType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ReceiveApprovalPort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='7155ca55-0f2d-43de-889a-c621bbf7b41f' ParentLink='PortDeclaration_CLRAttribute' LowerBound='22.1' HigherBound='23.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='63848dfb-41cb-43d9-8386-ad8d34e0137a' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='24.1' HigherBound='26.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='21' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='Mod11.OrderPortType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SendApprovedOrderPort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='6c8a12c8-9cd1-490d-a810-49f8c57b514f' ParentLink='PortDeclaration_CLRAttribute' LowerBound='24.1' HigherBound='25.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='f6d39f47-7f1b-417e-b533-8101dd8ab651' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='26.1' HigherBound='28.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='11' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='Mod11.OrderPortType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SendDendiedOrderPort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='5d06758e-077a-4ed8-8c31-1de448204e99' ParentLink='PortDeclaration_CLRAttribute' LowerBound='26.1' HigherBound='27.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __OrderApprovalProcess_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __OrderApprovalProcess_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "OrderApprovalProcess")
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
                OrderApprovalProcess __svc__ = (OrderApprovalProcess)_service;
                __OrderApprovalProcess_root_0 __ctx0__ = (__OrderApprovalProcess_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.ReceiveOrderPort != null)
                {
                    __svc__.ReceiveOrderPort.Close(this, null);
                    __svc__.ReceiveOrderPort = null;
                }
                if (__svc__.SendOrderForApprovalPort != null)
                {
                    __svc__.SendOrderForApprovalPort.Close(this, null);
                    __svc__.SendOrderForApprovalPort = null;
                }
                if (__svc__.ReceiveApprovalPort != null)
                {
                    __svc__.ReceiveApprovalPort.Close(this, null);
                    __svc__.ReceiveApprovalPort = null;
                }
                if (__svc__.SendApprovedOrderPort != null)
                {
                    __svc__.SendApprovedOrderPort.Close(this, null);
                    __svc__.SendApprovedOrderPort = null;
                }
                if (__svc__.SendDendiedOrderPort != null)
                {
                    __svc__.SendDendiedOrderPort.Close(this, null);
                    __svc__.SendDendiedOrderPort = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
        }


        [System.SerializableAttribute]
        public class __OrderApprovalProcess_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __OrderApprovalProcess_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "OrderApprovalProcess")
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
                OrderApprovalProcess __svc__ = (OrderApprovalProcess)_service;
                __OrderApprovalProcess_1 __ctx1__ = (__OrderApprovalProcess_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null && __ctx1__.__OrderIn != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__OrderIn);
                    __ctx1__.__OrderIn = null;
                }
                if (__ctx1__ != null && __ctx1__.__ApprovedOrder != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__ApprovedOrder);
                    __ctx1__.__ApprovedOrder = null;
                }
                if (__ctx1__ != null && __ctx1__.__subWrapper1 != null)
                {
                    __ctx1__.__subWrapper1.Destroy(__svc__, __ctx1__);
                    __ctx1__.__subWrapper1 = null;
                }
                if (__ctx1__ != null && __ctx1__.__OrderIdCorrelation != null)
                    __ctx1__.__OrderIdCorrelation = null;
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("OrderIn")]
            public __messagetype_Mod11_Order __OrderIn;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ApprovedOrder")]
            public __messagetype_Mod11_Order __ApprovedOrder;
            [Microsoft.XLANGs.Core.UserVariableAttribute("OrderIdCorrelation")]
            internal Microsoft.XLANGs.Core.Correlation __OrderIdCorrelation;
            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper1;
        }


        [System.SerializableAttribute]
        public class ____scope33_2 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public ____scope33_2(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "??__scope33")
            {
            }

            public override int Index { get { return 2; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[2]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[2]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                OrderApprovalProcess __svc__ = (OrderApprovalProcess)_service;
                ____scope33_2 __ctx2__ = (____scope33_2)(__svc__._stateMgrs[2]);

                if (__ctx2__ != null)
                    __ctx2__.__policy_1__ = null;
                if (__ctx2__ != null)
                    __ctx2__.__policyParam_1_2__ = null;
                if (__ctx2__ != null)
                    __ctx2__.__policyParamAsTXD_1_2__ = null;
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("policy_1__")]
            internal Microsoft.RuleEngine.Policy __policy_1__;
            [Microsoft.XLANGs.Core.UserVariableAttribute("policyParam_1_2__")]
            internal Microsoft.XLANGs.RuntimeTypes.XmlDocumentSerializationProxy __policyParam_1_2__;
            [Microsoft.XLANGs.Core.UserVariableAttribute("policyParamAsTXD_1_2__")]
            internal Microsoft.RuleEngine.TypedXmlDocument __policyParamAsTXD_1_2__;
        }

        private static Microsoft.XLANGs.Core.CorrelationType[] _correlationTypes = new Microsoft.XLANGs.Core.CorrelationType[] { new OrderIdCorrelationType() };
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
        [Microsoft.XLANGs.Core.UserVariableAttribute("ReceiveOrderPort")]
        internal OrderPortType ReceiveOrderPort;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("SendOrderForApprovalPort")]
        internal OrderPortType SendOrderForApprovalPort;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("ReceiveApprovalPort")]
        internal OrderPortType ReceiveApprovalPort;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("SendApprovedOrderPort")]
        internal OrderPortType SendApprovedOrderPort;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("SendDendiedOrderPort")]
        internal OrderPortType SendDendiedOrderPort;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {OrderPortType.Operation_1},
                                               typeof(OrderApprovalProcess).GetField("ReceiveOrderPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(OrderApprovalProcess), "ReceiveOrderPort"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {OrderPortType.Operation_1},
                                               typeof(OrderApprovalProcess).GetField("SendOrderForApprovalPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(OrderApprovalProcess), "SendOrderForApprovalPort"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {OrderPortType.Operation_1},
                                               typeof(OrderApprovalProcess).GetField("ReceiveApprovalPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(OrderApprovalProcess), "ReceiveApprovalPort"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {OrderPortType.Operation_1},
                                               typeof(OrderApprovalProcess).GetField("SendApprovedOrderPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(OrderApprovalProcess), "SendApprovedOrderPort"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {OrderPortType.Operation_1},
                                               typeof(OrderApprovalProcess).GetField("SendDendiedOrderPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(OrderApprovalProcess), "SendDendiedOrderPort"),
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
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "20bf35ee-f897-4eda-91a1-a4c8cef11949", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "20bf35ee-f897-4eda-91a1-a4c8cef11949", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "3199e3b4-b41f-46c6-b951-cdd7672f82c4", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "00000000-0000-0000-0000-000000000000", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "00000000-0000-0000-0000-000000000000", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "3199e3b4-b41f-46c6-b951-cdd7672f82c4", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "a03a8772-6247-4583-a1b3-61fc205d35be", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "8701d8e7-93a1-47aa-8883-0c4335486953", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "8701d8e7-93a1-47aa-8883-0c4335486953", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(10, "ebf1d608-5b47-4f84-9db4-02dfd0cae287", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(11, "ebf1d608-5b47-4f84-9db4-02dfd0cae287", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(12, "ab67007b-3863-4269-b558-2a596cbe8ec7", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(13, "ab67007b-3863-4269-b558-2a596cbe8ec7", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(14, "a03a8772-6247-4583-a1b3-61fc205d35be", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(15, "a2958b76-959a-4e64-964e-2a02fa3cdeb0", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(16, "38141826-fc43-4984-a87d-09f73bbcfe30", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(17, "38141826-fc43-4984-a87d-09f73bbcfe30", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(18, "80c13873-2004-43b8-ac63-80aa01cb73c5", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(19, "80c13873-2004-43b8-ac63-80aa01cb73c5", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(20, "a2958b76-959a-4e64-964e-2a02fa3cdeb0", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(21, "00000000-0000-0000-0000-000000000000", 1, false)
        };

        public override Microsoft.XLANGs.RuntimeTypes.Location[] EventLocations
        {
            get { return __eventLocations; }
        }

        public static Microsoft.XLANGs.RuntimeTypes.EventData[] __eventData = new Microsoft.XLANGs.RuntimeTypes.EventData[] {
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Receive),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Scope),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Construct),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Scope),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.If),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Send),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.If),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,21,21,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,2,3,3,3,6,7,7,8,8,9,7,10,10,10,11,12,12,13,14,15,15,16,16,16,17,15,18,18,18,19,20,21,21,21,21,};
        public static int[] __progressLocation2 = new int[] { 0,0,0,0,0,0,0,0,0,0,0,0,};

        public static int[][] __progressLocations = new int[3] [] {__progressLocation0,__progressLocation1,__progressLocation2};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __OrderApprovalProcess_1 __ctx1__ = (__OrderApprovalProcess_1)_stateMgrs[1];
            __OrderApprovalProcess_root_0 __ctx0__ = (__OrderApprovalProcess_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                ReceiveOrderPort = new OrderPortType(0, this);
                SendOrderForApprovalPort = new OrderPortType(1, this);
                ReceiveApprovalPort = new OrderPortType(2, this);
                SendApprovedOrderPort = new OrderPortType(3, this);
                SendDendiedOrderPort = new OrderPortType(4, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], ReceiveOrderPort, this);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __OrderApprovalProcess_1(this);
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
            ____scope33_2 __ctx2__ = (____scope33_2)_stateMgrs[2];
            __OrderApprovalProcess_1 __ctx1__ = (__OrderApprovalProcess_1)_stateMgrs[1];
            __OrderApprovalProcess_root_0 __ctx0__ = (__OrderApprovalProcess_root_0)_stateMgrs[0];

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
                if (!ReceiveOrderPort.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__OrderIn != null)
                    __ctx1__.UnrefMessage(__ctx1__.__OrderIn);
                __ctx1__.__OrderIn = new __messagetype_Mod11_Order("OrderIn", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__OrderIn);
                ReceiveOrderPort.ReceiveMessage(0, __msgEnv__, __ctx1__.__OrderIn, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if (ReceiveOrderPort != null)
                {
                    ReceiveOrderPort.Close(__ctx1__, __seg__);
                    ReceiveOrderPort = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__OrderIn);
                    __edata.PortName = @"ReceiveOrderPort";
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
                __ctx2__ = new ____scope33_2(this);
                _stateMgrs[2] = __ctx2__;
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                __ctx1__.StartContext(__seg__, __ctx2__);
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 8:
                if ( !PreProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[6],__eventData[4],_stateMgrs[1].TrackDataStream );
                __ctx2__.Finally();
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 9;
            case 9:
                if ( !PreProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[7],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 10;
            case 10:
                __condition__ = (System.Boolean)__ctx1__.__OrderIn.part.GetDistinguishedField("Approved");
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 15 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 15;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 11;
            case 11:
                if ( !PreProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[8],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 12;
            case 12:
                {
                    __messagetype_Mod11_Order __ApprovedOrder = new __messagetype_Mod11_Order("ApprovedOrder", __ctx1__);

                    __ApprovedOrder.CopyFrom(__ctx1__.__OrderIn);

                    if (__ctx1__.__ApprovedOrder != null)
                        __ctx1__.UnrefMessage(__ctx1__.__ApprovedOrder);
                    __ctx1__.__ApprovedOrder = __ApprovedOrder;
                    __ctx1__.RefMessage(__ctx1__.__ApprovedOrder);
                }
                __ctx1__.__ApprovedOrder.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 13;
            case 13:
                if ( !PreProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__ApprovedOrder);
                    Tracker.FireEvent(__eventLocations[9],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 14;
            case 14:
                if ( !PostProgressInc( __seg__, __ctx__, 22 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 22;
            case 15:
                if ( !PreProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[10],__eventData[6],_stateMgrs[1].TrackDataStream );
                __ctx1__.__subWrapper1 = new Microsoft.XLANGs.Core.SubscriptionWrapper(1, System.Guid.Empty, ReceiveApprovalPort, 0, __ctx0__);
                __ctx1__.__OrderIdCorrelation = new Microsoft.XLANGs.Core.Correlation(this, 0, 1);
                __ctx1__.__OrderIdCorrelation.AddSubscription(((__OrderApprovalProcess_1)_stateMgrs[1]).__subWrapper1.getSubscription(this), __ctx1__);
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 16;
            case 16:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 17;
            case 17:
                if ( !PreProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                SendOrderForApprovalPort.SendMessage(0, __ctx1__.__OrderIn, new Microsoft.XLANGs.Core.Correlation[] { __ctx1__.__OrderIdCorrelation }, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 18;
            case 18:
                if ( !PreProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__OrderIn);
                    __edata.PortName = @"SendOrderForApprovalPort";
                    Tracker.FireEvent(__eventLocations[11],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 19;
            case 19:
                if ( !PreProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[12],__eventData[1],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 20;
            case 20:
                if (!ReceiveApprovalPort.GetMessageId(__ctx1__.__subWrapper1.getSubscription(this), __seg__, __ctx1__, out __msgEnv__, _locations[0]))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__ != null && __ctx1__.__subWrapper1 != null)
                {
                    __ctx1__.__subWrapper1.Destroy(this, __ctx1__);
                    __ctx1__.__subWrapper1 = null;
                }
                if (__ctx1__.__ApprovedOrder != null)
                    __ctx1__.UnrefMessage(__ctx1__.__ApprovedOrder);
                __ctx1__.__ApprovedOrder = new __messagetype_Mod11_Order("ApprovedOrder", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__ApprovedOrder);
                ReceiveApprovalPort.ReceiveMessage(0, __msgEnv__, __ctx1__.__ApprovedOrder, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if (__ctx1__ != null && __ctx1__.__OrderIdCorrelation != null)
                    __ctx1__.__OrderIdCorrelation = null;
                if ( !PostProgressInc( __seg__, __ctx__, 21 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 21;
            case 21:
                if ( !PreProgressInc( __seg__, __ctx__, 22 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__ApprovedOrder);
                    __edata.PortName = @"ReceiveApprovalPort";
                    Tracker.FireEvent(__eventLocations[13],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 22;
            case 22:
                if ( !PreProgressInc( __seg__, __ctx__, 23 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (__ctx1__ != null && __ctx1__.__OrderIn != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__OrderIn);
                    __ctx1__.__OrderIn = null;
                }
                if (ReceiveApprovalPort != null)
                {
                    ReceiveApprovalPort.Close(__ctx1__, __seg__);
                    ReceiveApprovalPort = null;
                }
                if (SendOrderForApprovalPort != null)
                {
                    SendOrderForApprovalPort.Close(__ctx1__, __seg__);
                    SendOrderForApprovalPort = null;
                }
                Tracker.FireEvent(__eventLocations[14],__eventData[7],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 23;
            case 23:
                if ( !PreProgressInc( __seg__, __ctx__, 24 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[15],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 24;
            case 24:
                __condition__ = (System.Boolean)__ctx1__.__ApprovedOrder.part.GetDistinguishedField("Approved");
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 30 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 30;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 25 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 25;
            case 25:
                if ( !PreProgressInc( __seg__, __ctx__, 26 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[16],__eventData[6],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 26;
            case 26:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 27 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 27;
            case 27:
                if ( !PreProgressInc( __seg__, __ctx__, 28 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                SendApprovedOrderPort.SendMessage(0, __ctx1__.__ApprovedOrder, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.NextActivityPersists );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 28;
            case 28:
                if ( !PreProgressInc( __seg__, __ctx__, 29 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__ApprovedOrder);
                    __edata.PortName = @"SendApprovedOrderPort";
                    Tracker.FireEvent(__eventLocations[17],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 29;
            case 29:
                if ( !PostProgressInc( __seg__, __ctx__, 34 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 34;
            case 30:
                if ( !PreProgressInc( __seg__, __ctx__, 31 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[18],__eventData[6],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 31;
            case 31:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 32 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 32;
            case 32:
                if ( !PreProgressInc( __seg__, __ctx__, 33 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                SendDendiedOrderPort.SendMessage(0, __ctx1__.__ApprovedOrder, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.NextActivityPersists );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 33;
            case 33:
                if ( !PreProgressInc( __seg__, __ctx__, 34 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__ApprovedOrder);
                    __edata.PortName = @"SendDendiedOrderPort";
                    Tracker.FireEvent(__eventLocations[19],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 34;
            case 34:
                if ( !PreProgressInc( __seg__, __ctx__, 35 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (__ctx1__ != null && __ctx1__.__ApprovedOrder != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__ApprovedOrder);
                    __ctx1__.__ApprovedOrder = null;
                }
                if (SendDendiedOrderPort != null)
                {
                    SendDendiedOrderPort.Close(__ctx1__, __seg__);
                    SendDendiedOrderPort = null;
                }
                if (SendApprovedOrderPort != null)
                {
                    SendApprovedOrderPort.Close(__ctx1__, __seg__);
                    SendApprovedOrderPort = null;
                }
                Tracker.FireEvent(__eventLocations[20],__eventData[7],_stateMgrs[1].TrackDataStream );
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

        public Microsoft.XLANGs.Core.StopConditions segment2(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[2];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[2];
            ____scope33_2 __ctx2__ = (____scope33_2)_stateMgrs[2];
            __OrderApprovalProcess_1 __ctx1__ = (__OrderApprovalProcess_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx2__.__policy_1__ = default(Microsoft.RuleEngine.Policy);
                __ctx2__.__policyParam_1_2__ = new Microsoft.XLANGs.RuntimeTypes.XmlDocumentSerializationProxy();
                __ctx2__.__policyParamAsTXD_1_2__ = default(Microsoft.RuleEngine.TypedXmlDocument);
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                __ctx2__.__policyParam_1_2__.UnderlyingXmlDocument = __ctx1__.__OrderIn.part.TypedValue;
                if ( !PostProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 2;
            case 2:
                __ctx2__.__policyParamAsTXD_1_2__ = new Microsoft.RuleEngine.TypedXmlDocument("Mod11.Order", (System.Xml.XmlDocument)__ctx2__.__policyParam_1_2__.UnderlyingXmlDocument);
                if (__ctx2__ != null)
                    __ctx2__.__policyParam_1_2__ = null;
                if ( !PostProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 3;
            case 3:
                __ctx2__.__policy_1__ = new Microsoft.RuleEngine.Policy("OrderPolicy");
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                __ctx2__.__policy_1__.Execute(__ctx2__.__policyParamAsTXD_1_2__);
                if ( !PostProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 5;
            case 5:
                if ( !PreProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[4],__eventData[3],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 6;
            case 6:
                {
                    __messagetype_Mod11_Order __OrderIn = new __messagetype_Mod11_Order("OrderIn", __ctx1__);

                    __OrderIn.part.LoadFrom(__ctx2__.__policyParamAsTXD_1_2__.Document);
                    if (__ctx2__ != null)
                        __ctx2__.__policyParamAsTXD_1_2__ = null;

                    if (__ctx1__.__OrderIn != null)
                        __ctx1__.UnrefMessage(__ctx1__.__OrderIn);
                    __ctx1__.__OrderIn = __OrderIn;
                    __ctx1__.RefMessage(__ctx1__.__OrderIn);
                }
                __ctx1__.__OrderIn.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                if ( !PreProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__OrderIn);
                    Tracker.FireEvent(__eventLocations[5],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 8;
            case 8:
                __ctx2__.__policy_1__.Dispose();
                if (__ctx2__ != null)
                    __ctx2__.__policy_1__ = null;
                if ( !PostProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 9;
            case 9:
                if (!__ctx2__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 10;
            case 10:
                if ( !PreProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx2__.OnCommit();
                goto case 11;
            case 11:
                __seg__.SegmentDone();
                _segments[1].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
        private static Microsoft.XLANGs.Core.CachedObject[] _locations = new Microsoft.XLANGs.Core.CachedObject[] {
            new Microsoft.XLANGs.Core.CachedObject(new System.Guid("{0E2E2E9E-F3EC-4DA9-B0A7-F1E2E4BE0BD3}"))
        };

    }

    [System.SerializableAttribute]
    sealed public class __Mod11_Order__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Mod11.Order _schema = new Mod11.Order();

        public __Mod11_Order__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "Mod11.Order",
        new System.Type[]{
            typeof(Mod11.Order)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__Mod11_Order__)
        },
        0,
        @"http://Mod11.Order#Order"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_Mod11_Order : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Mod11_Order__ part;

        private void __CreatePartWrappers()
        {
            part = new __Mod11_Order__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_Mod11_Order(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class _MODULE_PROXY_ { }
}
