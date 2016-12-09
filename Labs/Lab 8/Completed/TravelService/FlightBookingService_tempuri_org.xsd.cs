namespace TravelService {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"SendFlightBookingRequest", @"SendFlightBookingRequestResponse"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"TravelService.FlightBookingService_schemas_datacontract_org_2004_07_FlightBookingService", typeof(global::TravelService.FlightBookingService_schemas_datacontract_org_2004_07_FlightBookingService))]
    public sealed class FlightBookingService_tempuri_org : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:tns=""http://tempuri.org/"" elementFormDefault=""qualified"" targetNamespace=""http://tempuri.org/"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""TravelService.FlightBookingService_schemas_datacontract_org_2004_07_FlightBookingService"" namespace=""http://schemas.datacontract.org/2004/07/FlightBookingService"" />
  <xs:annotation>
    <xs:appinfo>
      <references xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
        <reference targetNamespace=""http://schemas.datacontract.org/2004/07/FlightBookingService"" />
      </references>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""SendFlightBookingRequest"">
    <xs:complexType>
      <xs:sequence>
        <xs:element xmlns:q1=""http://schemas.datacontract.org/2004/07/FlightBookingService"" minOccurs=""0"" name=""FlightBookingRequest"" nillable=""true"" type=""q1:FlightBookingRequest"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""SendFlightBookingRequestResponse"">
    <xs:complexType>
      <xs:sequence>
        <xs:element xmlns:q2=""http://schemas.datacontract.org/2004/07/FlightBookingService"" minOccurs=""0"" name=""SendFlightBookingRequestResult"" nillable=""true"" type=""q2:FlightBookingResponse"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public FlightBookingService_tempuri_org() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [2];
                _RootElements[0] = "SendFlightBookingRequest";
                _RootElements[1] = "SendFlightBookingRequestResponse";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
        
        [Schema(@"http://tempuri.org/",@"SendFlightBookingRequest")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"SendFlightBookingRequest"})]
        public sealed class SendFlightBookingRequest : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public SendFlightBookingRequest() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "SendFlightBookingRequest";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"http://tempuri.org/",@"SendFlightBookingRequestResponse")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"SendFlightBookingRequestResponse"})]
        public sealed class SendFlightBookingRequestResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public SendFlightBookingRequestResponse() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "SendFlightBookingRequestResponse";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
    }
}
