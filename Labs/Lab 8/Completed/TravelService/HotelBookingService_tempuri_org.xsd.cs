namespace TravelService {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"SendHotelBookingRequest", @"SendHotelBookingRequestResponse"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"TravelService.HotelBookingService_schemas_datacontract_org_2004_07_HotelBookingService", typeof(global::TravelService.HotelBookingService_schemas_datacontract_org_2004_07_HotelBookingService))]
    public sealed class HotelBookingService_tempuri_org : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:tns=""http://tempuri.org/"" elementFormDefault=""qualified"" targetNamespace=""http://tempuri.org/"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""TravelService.HotelBookingService_schemas_datacontract_org_2004_07_HotelBookingService"" namespace=""http://schemas.datacontract.org/2004/07/HotelBookingService"" />
  <xs:annotation>
    <xs:appinfo>
      <references xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
        <reference targetNamespace=""http://schemas.datacontract.org/2004/07/HotelBookingService"" />
      </references>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""SendHotelBookingRequest"">
    <xs:complexType>
      <xs:sequence>
        <xs:element xmlns:q1=""http://schemas.datacontract.org/2004/07/HotelBookingService"" minOccurs=""0"" name=""hotelBookingRequest"" nillable=""true"" type=""q1:HotelBookingRequest"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""SendHotelBookingRequestResponse"">
    <xs:complexType>
      <xs:sequence>
        <xs:element xmlns:q2=""http://schemas.datacontract.org/2004/07/HotelBookingService"" minOccurs=""0"" name=""SendHotelBookingRequestResult"" nillable=""true"" type=""q2:HotelBookingResponse"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public HotelBookingService_tempuri_org() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [2];
                _RootElements[0] = "SendHotelBookingRequest";
                _RootElements[1] = "SendHotelBookingRequestResponse";
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
        
        [Schema(@"http://tempuri.org/",@"SendHotelBookingRequest")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"SendHotelBookingRequest"})]
        public sealed class SendHotelBookingRequest : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public SendHotelBookingRequest() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "SendHotelBookingRequest";
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
        
        [Schema(@"http://tempuri.org/",@"SendHotelBookingRequestResponse")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"SendHotelBookingRequestResponse"})]
        public sealed class SendHotelBookingRequestResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public SendHotelBookingRequestResponse() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "SendHotelBookingRequestResponse";
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
