
#pragma warning disable 162

namespace Lab7b
{

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(Lab7b.__messagetype_Lab7b_Tweet)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class PortType_1 : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public PortType_1(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public PortType_1(PortType_1 p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            PortType_1 p = new PortType_1(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(PortType_1),
            typeof(__messagetype_Lab7b_Tweet),
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
        "Insert",
        new System.Type[]{
            typeof(Lab7b.__messagetype_Lab7b_TableOperation_dbo_Tweets_Insert), 
            typeof(Lab7b.__messagetype_Lab7b_TableOperation_dbo_Tweets_InsertResponse)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class SndDemoDBType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public SndDemoDBType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public SndDemoDBType(SndDemoDBType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            SndDemoDBType p = new SndDemoDBType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Insert = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Insert",
            System.Web.Services.Description.OperationFlow.RequestResponse,
            typeof(SndDemoDBType),
            typeof(__messagetype_Lab7b_TableOperation_dbo_Tweets_Insert),
            typeof(__messagetype_Lab7b_TableOperation_dbo_Tweets_InsertResponse),
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Insert" ] = Insert;
                return h;
            }
        }
        #endregion // port reflection support
    }
    //#line 195 "C:\Labs\Lab 7b\Complete\Lab7b\Lab7b\TweetProcess.odx"
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "RcvTweet", "Operation_1", -1, -1, true
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(Lab7b.PortType_1),
            typeof(Lab7b.SndDemoDBType)
        },
        new System.String[] {
            "RcvTweet",
            "SndDemoDB"
        },
        new System.Type[] {
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
    sealed internal class TweetProcess : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
    {
        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        public static readonly bool __execable = false;
        [Microsoft.XLANGs.BaseTypes.CallCompensationAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSCallCompensationInfo.eHasRequestResponse
,
            new System.String[] {
            },
            new System.String[] {
            }
        )]
        public static void __bodyProxy()
        {
        }
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(TweetProcess));
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

        static TweetProcess()
        {
            Microsoft.BizTalk.XLANGs.BTXEngine.BTXService.CacheStaticState( _serviceId );
        }

        private void ConstructorHelper()
        {
            _segments = new Microsoft.XLANGs.Core.Segment[] {
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment0), 0, 0, 0),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment1), 1, 1, 1)
            };

            _Locks = 0;
            _rootContext = new __TweetProcess_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[2];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public TweetProcess(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "TweetProcess", tracker)
        {
            ConstructorHelper();
        }

        public TweetProcess(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "TweetProcess")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>1e6bcd64-74f9-4710-b9a9-d7a2bffc9cdb</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>88714cd5-d2b9-425d-88bd-73ea5aa0c8d6</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive Tweet</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>c64ac906-3240-4ae2-803c-5c337eb2694e</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>ConstructMessage_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>c0cd51cf-b805-4850-8f7e-daf6f6bdbd8d</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Transform_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>ac56d81e-99a9-4356-b1f8-8d56c5124b3c</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>80339885-d158-40f8-8457-fcd675f4df74</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>965405b9-89d8-442c-ab24-ee029b116f02</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>4c8fa51f-3b4f-4291-9d6b-055152cbac9a</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Send_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>2e216566-1a44-4621-87c4-3208bc9c30c6</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'TweetProcess'</ActionName><IsAtomic>0</IsAtomic><Line>195</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>207</Line><Position>22</Position><ShapeID>'88714cd5-d2b9-425d-88bd-73ea5aa0c8d6'</ShapeID>
<Messages>
	<MsgInfo><name>msgTweet</name><part>part</part><schema>Lab7b.Tweet</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>209</Line><Position>13</Position><ShapeID>'c64ac906-3240-4ae2-803c-5c337eb2694e'</ShapeID>
<Messages>
	<MsgInfo><name>msgInsert</name><part>part</part><schema>Lab7b.TableOperation_dbo_Tweets+Insert</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>msgTweet</name><part>part</part><schema>Lab7b.Tweet</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>215</Line><Position>13</Position><ShapeID>'4c8fa51f-3b4f-4291-9d6b-055152cbac9a'</ShapeID>
<Messages>
	<MsgInfo><name>msgInsert</name><part>part</part><schema>Lab7b.TableOperation_dbo_Tweets+Insert</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>217</Line><Position>13</Position><ShapeID>'2e216566-1a44-4621-87c4-3208bc9c30c6'</ShapeID>
<Messages>
	<MsgInfo><name>msgInsertResponse</name><part>part</part><schema>Lab7b.TableOperation_dbo_Tweets+InsertResponse</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='2e0a95ad-82bd-41c8-aef6-17d7849c23d7' LowerBound='1.1' HigherBound='45.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='Lab7b' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='4de7076f-46a8-4835-93c7-630a6d9e42ed' ParentLink='Module_PortType' LowerBound='4.1' HigherBound='11.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_1' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='7af1b231-31d4-48bb-be9f-b8d71445f856' ParentLink='PortType_OperationDeclaration' LowerBound='6.1' HigherBound='10.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='3b8de169-c99e-4950-89f2-3057b31d0466' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='8.13' HigherBound='8.18'>
                    <om:Property Name='Ref' Value='Lab7b.Tweet' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='3b637a50-17bc-4baa-9200-4bf1d2e47eb5' ParentLink='Module_PortType' LowerBound='11.1' HigherBound='18.1'>
            <om:Property Name='Synchronous' Value='True' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='SndDemoDBType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='7d637d2b-b73a-4074-9b7e-fd7908cc9621' ParentLink='PortType_OperationDeclaration' LowerBound='13.1' HigherBound='17.1'>
                <om:Property Name='OperationType' Value='RequestResponse' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Insert' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='5b1d3820-8844-4026-bdb5-5f9b829fdc82' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='15.13' HigherBound='15.45'>
                    <om:Property Name='Ref' Value='Lab7b.TableOperation_dbo_Tweets.Insert' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='MessageRef' OID='db97f348-a59e-4609-83ab-5d2f3eeec3d7' ParentLink='OperationDeclaration_ResponseMessageRef' LowerBound='15.47' HigherBound='15.87'>
                    <om:Property Name='Ref' Value='Lab7b.TableOperation_dbo_Tweets.InsertResponse' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Response' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='baa58c1d-af3a-47c9-9cbf-239b2c57c1c4' ParentLink='Module_ServiceDeclaration' LowerBound='18.1' HigherBound='44.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='TweetProcess' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='ServiceBody' OID='1e6bcd64-74f9-4710-b9a9-d7a2bffc9cdb' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='88714cd5-d2b9-425d-88bd-73ea5aa0c8d6' ParentLink='ServiceBody_Statement' LowerBound='30.1' HigherBound='32.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='RcvTweet' />
                    <om:Property Name='MessageName' Value='msgTweet' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive Tweet' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Construct' OID='c64ac906-3240-4ae2-803c-5c337eb2694e' ParentLink='ServiceBody_Statement' LowerBound='32.1' HigherBound='38.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='ConstructMessage_1' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='Transform' OID='c0cd51cf-b805-4850-8f7e-daf6f6bdbd8d' ParentLink='ComplexStatement_Statement' LowerBound='35.1' HigherBound='37.1'>
                        <om:Property Name='ClassName' Value='Lab7b.Tweet_to_Insert' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Transform_1' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='MessagePartRef' OID='ac56d81e-99a9-4356-b1f8-8d56c5124b3c' ParentLink='Transform_InputMessagePartRef' LowerBound='36.64' HigherBound='36.72'>
                            <om:Property Name='MessageRef' Value='msgTweet' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='MessagePartReference_1' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='MessagePartRef' OID='80339885-d158-40f8-8457-fcd675f4df74' ParentLink='Transform_OutputMessagePartRef' LowerBound='36.28' HigherBound='36.37'>
                            <om:Property Name='MessageRef' Value='msgInsert' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='MessagePartReference_2' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='MessageRef' OID='965405b9-89d8-442c-ab24-ee029b116f02' ParentLink='Construct_MessageRef' LowerBound='33.23' HigherBound='33.32'>
                        <om:Property Name='Ref' Value='msgInsert' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
                <om:Element Type='Send' OID='4c8fa51f-3b4f-4291-9d6b-055152cbac9a' ParentLink='ServiceBody_Statement' LowerBound='38.1' HigherBound='40.1'>
                    <om:Property Name='PortName' Value='SndDemoDB' />
                    <om:Property Name='MessageName' Value='msgInsert' />
                    <om:Property Name='OperationName' Value='Insert' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Send_1' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Receive' OID='2e216566-1a44-4621-87c4-3208bc9c30c6' ParentLink='ServiceBody_Statement' LowerBound='40.1' HigherBound='42.1'>
                    <om:Property Name='Activate' Value='False' />
                    <om:Property Name='PortName' Value='SndDemoDB' />
                    <om:Property Name='MessageName' Value='msgInsertResponse' />
                    <om:Property Name='OperationName' Value='Insert' />
                    <om:Property Name='OperationMessageName' Value='Response' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive_1' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='6b2ade4b-59da-4a82-8b8b-3824ee3bc495' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='21.1' HigherBound='23.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='Lab7b.PortType_1' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='RcvTweet' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='7b3a69d5-f221-4ec7-9de4-e9e532841ab1' ParentLink='PortDeclaration_CLRAttribute' LowerBound='21.1' HigherBound='22.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='07dd01da-4c11-4ad3-94bf-fc9938e990ed' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='23.1' HigherBound='25.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='Lab7b.SndDemoDBType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SndDemoDB' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='LogicalBindingAttribute' OID='d034a933-7501-4846-8ea3-a1d6943cf8df' ParentLink='PortDeclaration_CLRAttribute' LowerBound='23.1' HigherBound='24.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='4ed29c62-af3f-434d-b865-74611f2a6f73' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='25.1' HigherBound='26.1'>
                <om:Property Name='Type' Value='Lab7b.Tweet' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgTweet' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='63c72eee-d624-4d08-b587-a2d8a13abce2' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='26.1' HigherBound='27.1'>
                <om:Property Name='Type' Value='Lab7b.TableOperation_dbo_Tweets.Insert' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgInsert' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='76b523fa-fe0c-4019-9598-5b80f2c85d90' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='27.1' HigherBound='28.1'>
                <om:Property Name='Type' Value='Lab7b.TableOperation_dbo_Tweets.InsertResponse' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgInsertResponse' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __TweetProcess_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __TweetProcess_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "TweetProcess")
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
                TweetProcess __svc__ = (TweetProcess)_service;
                __TweetProcess_root_0 __ctx0__ = (__TweetProcess_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.RcvTweet != null)
                {
                    __svc__.RcvTweet.Close(this, null);
                    __svc__.RcvTweet = null;
                }
                if (__svc__.SndDemoDB != null)
                {
                    __svc__.SndDemoDB.Close(this, null);
                    __svc__.SndDemoDB = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper1;
        }


        [System.SerializableAttribute]
        public class __TweetProcess_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __TweetProcess_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "TweetProcess")
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
                TweetProcess __svc__ = (TweetProcess)_service;
                __TweetProcess_root_0 __ctx0__ = (__TweetProcess_root_0)(__svc__._stateMgrs[0]);
                __TweetProcess_1 __ctx1__ = (__TweetProcess_1)(__svc__._stateMgrs[1]);

                if (__ctx0__ != null && __ctx0__.__subWrapper1 != null)
                {
                    __ctx0__.__subWrapper1.Destroy(__svc__, __ctx0__);
                    __ctx0__.__subWrapper1 = null;
                }
                if (__ctx1__ != null && __ctx1__.__msgInsertResponse != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgInsertResponse);
                    __ctx1__.__msgInsertResponse = null;
                }
                if (__ctx1__ != null && __ctx1__.__msgTweet != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgTweet);
                    __ctx1__.__msgTweet = null;
                }
                if (__ctx1__ != null && __ctx1__.__msgInsert != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgInsert);
                    __ctx1__.__msgInsert = null;
                }
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("msgTweet")]
            public __messagetype_Lab7b_Tweet __msgTweet;
            [Microsoft.XLANGs.Core.UserVariableAttribute("msgInsert")]
            public __messagetype_Lab7b_TableOperation_dbo_Tweets_Insert __msgInsert;
            [Microsoft.XLANGs.Core.UserVariableAttribute("msgInsertResponse")]
            public __messagetype_Lab7b_TableOperation_dbo_Tweets_InsertResponse __msgInsertResponse;
        }

        private static Microsoft.XLANGs.Core.CorrelationType[] _correlationTypes = null;
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
        [Microsoft.XLANGs.Core.UserVariableAttribute("RcvTweet")]
        internal PortType_1 RcvTweet;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("SndDemoDB")]
        internal SndDemoDBType SndDemoDB;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_1.Operation_1},
                                               typeof(TweetProcess).GetField("RcvTweet", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(TweetProcess), "RcvTweet"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {SndDemoDBType.Insert},
                                               typeof(TweetProcess).GetField("SndDemoDB", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(TweetProcess), "SndDemoDB"),
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
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "88714cd5-d2b9-425d-88bd-73ea5aa0c8d6", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "88714cd5-d2b9-425d-88bd-73ea5aa0c8d6", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "c64ac906-3240-4ae2-803c-5c337eb2694e", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "c64ac906-3240-4ae2-803c-5c337eb2694e", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "4c8fa51f-3b4f-4291-9d6b-055152cbac9a", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "4c8fa51f-3b4f-4291-9d6b-055152cbac9a", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "2e216566-1a44-4621-87c4-3208bc9c30c6", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "2e216566-1a44-4621-87c4-3208bc9c30c6", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "00000000-0000-0000-0000-000000000000", 1, false)
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
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,9,9,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,2,3,3,4,5,5,5,6,7,7,8,9,9,9,9,};

        public static int[][] __progressLocations = new int[2] [] {__progressLocation0,__progressLocation1};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __TweetProcess_root_0 __ctx0__ = (__TweetProcess_root_0)_stateMgrs[0];
            __TweetProcess_1 __ctx1__ = (__TweetProcess_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                RcvTweet = new PortType_1(0, this);
                SndDemoDB = new SndDemoDBType(1, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], RcvTweet, this);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __TweetProcess_1(this);
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
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[1];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[1];
            __TweetProcess_root_0 __ctx0__ = (__TweetProcess_root_0)_stateMgrs[0];
            __TweetProcess_1 __ctx1__ = (__TweetProcess_1)_stateMgrs[1];

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
                if (!RcvTweet.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__msgTweet != null)
                    __ctx1__.UnrefMessage(__ctx1__.__msgTweet);
                __ctx1__.__msgTweet = new __messagetype_Lab7b_Tweet("msgTweet", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__msgTweet);
                RcvTweet.ReceiveMessage(0, __msgEnv__, __ctx1__.__msgTweet, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if (RcvTweet != null)
                {
                    RcvTweet.Close(__ctx1__, __seg__);
                    RcvTweet = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__msgTweet);
                    __edata.PortName = @"RcvTweet";
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
                    __messagetype_Lab7b_TableOperation_dbo_Tweets_Insert __msgInsert = new __messagetype_Lab7b_TableOperation_dbo_Tweets_Insert("msgInsert", __ctx1__);

                    ApplyTransform(typeof(Lab7b.Tweet_to_Insert), new object[] {__msgInsert.part}, new object[] {__ctx1__.__msgTweet.part});

                    if (__ctx1__.__msgInsert != null)
                        __ctx1__.UnrefMessage(__ctx1__.__msgInsert);
                    __ctx1__.__msgInsert = __msgInsert;
                    __ctx1__.RefMessage(__ctx1__.__msgInsert);
                }
                __ctx1__.__msgInsert.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                if ( !PreProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__msgInsert);
                    __edata.Messages.Add(__ctx1__.__msgTweet);
                    Tracker.FireEvent(__eventLocations[4],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__msgTweet != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgTweet);
                    __ctx1__.__msgTweet = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 8;
            case 8:
                if ( !PreProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[5],__eventData[3],_stateMgrs[1].TrackDataStream );
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
                SndDemoDB.SendMessage(0, __ctx1__.__msgInsert, null, null, out __ctx0__.__subWrapper1, __ctx1__, __seg__ );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 11;
            case 11:
                if ( !PreProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__msgInsert);
                    __edata.PortName = @"SndDemoDB";
                    Tracker.FireEvent(__eventLocations[6],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__msgInsert != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgInsert);
                    __ctx1__.__msgInsert = null;
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
                if (!SndDemoDB.GetMessageId(__ctx0__.__subWrapper1.getSubscription(this), __seg__, __ctx1__, out __msgEnv__, _locations[0]))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx0__ != null && __ctx0__.__subWrapper1 != null)
                {
                    __ctx0__.__subWrapper1.Destroy(this, __ctx0__);
                    __ctx0__.__subWrapper1 = null;
                }
                if (__ctx1__.__msgInsertResponse != null)
                    __ctx1__.UnrefMessage(__ctx1__.__msgInsertResponse);
                __ctx1__.__msgInsertResponse = new __messagetype_Lab7b_TableOperation_dbo_Tweets_InsertResponse("msgInsertResponse", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__msgInsertResponse);
                SndDemoDB.ReceiveMessage(0, __msgEnv__, __ctx1__.__msgInsertResponse, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if (SndDemoDB != null)
                {
                    SndDemoDB.Close(__ctx1__, __seg__);
                    SndDemoDB = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 14;
            case 14:
                if ( !PreProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__msgInsertResponse);
                    __edata.PortName = @"SndDemoDB";
                    Tracker.FireEvent(__eventLocations[8],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__msgInsertResponse != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgInsertResponse);
                    __ctx1__.__msgInsertResponse = null;
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
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 17;
            case 17:
                if ( !PreProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 18;
            case 18:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
        private static Microsoft.XLANGs.Core.CachedObject[] _locations = new Microsoft.XLANGs.Core.CachedObject[] {
            new Microsoft.XLANGs.Core.CachedObject(new System.Guid("{A5FCB72A-A2B1-4490-8B5D-F5CC9D9604AE}"))
        };

    }

    [System.SerializableAttribute]
    sealed public class __Lab7b_Tweet__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Lab7b.Tweet _schema = new Lab7b.Tweet();

        public __Lab7b_Tweet__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "Lab7b.Tweet",
        new System.Type[]{
            typeof(Lab7b.Tweet)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__Lab7b_Tweet__)
        },
        0,
        @"http://A372.Tweet#Tweet"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_Lab7b_Tweet : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Lab7b_Tweet__ part;

        private void __CreatePartWrappers()
        {
            part = new __Lab7b_Tweet__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_Lab7b_Tweet(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __Lab7b_TableOperation_dbo_Tweets_Insert__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Lab7b.TableOperation_dbo_Tweets.Insert _schema = new Lab7b.TableOperation_dbo_Tweets.Insert();

        public __Lab7b_TableOperation_dbo_Tweets_Insert__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "Lab7b.TableOperation_dbo_Tweets.Insert",
        new System.Type[]{
            typeof(Lab7b.TableOperation_dbo_Tweets.Insert)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__Lab7b_TableOperation_dbo_Tweets_Insert__)
        },
        0,
        @"http://schemas.microsoft.com/Sql/2008/05/TableOp/dbo/Tweets#Insert"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_Lab7b_TableOperation_dbo_Tweets_Insert : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Lab7b_TableOperation_dbo_Tweets_Insert__ part;

        private void __CreatePartWrappers()
        {
            part = new __Lab7b_TableOperation_dbo_Tweets_Insert__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_Lab7b_TableOperation_dbo_Tweets_Insert(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __Lab7b_TableOperation_dbo_Tweets_InsertResponse__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Lab7b.TableOperation_dbo_Tweets.InsertResponse _schema = new Lab7b.TableOperation_dbo_Tweets.InsertResponse();

        public __Lab7b_TableOperation_dbo_Tweets_InsertResponse__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "Lab7b.TableOperation_dbo_Tweets.InsertResponse",
        new System.Type[]{
            typeof(Lab7b.TableOperation_dbo_Tweets.InsertResponse)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__Lab7b_TableOperation_dbo_Tweets_InsertResponse__)
        },
        0,
        @"http://schemas.microsoft.com/Sql/2008/05/TableOp/dbo/Tweets#InsertResponse"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_Lab7b_TableOperation_dbo_Tweets_InsertResponse : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Lab7b_TableOperation_dbo_Tweets_InsertResponse__ part;

        private void __CreatePartWrappers()
        {
            part = new __Lab7b_TableOperation_dbo_Tweets_InsertResponse__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_Lab7b_TableOperation_dbo_Tweets_InsertResponse(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class _MODULE_PROXY_ { }
}
