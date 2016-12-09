namespace TravelService {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"FlightBookingRequest", @"FlightBookingResponse"})]
    public sealed class FlightBookingService_schemas_datacontract_org_2004_07_FlightBookingService : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:tns=""http://schemas.datacontract.org/2004/07/FlightBookingService"" elementFormDefault=""qualified"" targetNamespace=""http://schemas.datacontract.org/2004/07/FlightBookingService"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:complexType name=""FlightBookingRequest"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CreditCardNumber"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""Customer"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""DepartureDate"" type=""xs:dateTime"" />
      <xs:element minOccurs=""0"" name=""DepartureFrom"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""Destination"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""Notes"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""ReturnDate"" type=""xs:dateTime"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""FlightBookingRequest"" nillable=""true"" type=""tns:FlightBookingRequest"" />
  <xs:complexType name=""FlightBookingResponse"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""AmountCharged"" type=""xs:double"" />
      <xs:element minOccurs=""0"" name=""Approved"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""BookingNotes"" nillable=""true"" type=""xs:string"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""FlightBookingResponse"" nillable=""true"" type=""tns:FlightBookingResponse"" />
</xs:schema>";
        
        public FlightBookingService_schemas_datacontract_org_2004_07_FlightBookingService() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [2];
                _RootElements[0] = "FlightBookingRequest";
                _RootElements[1] = "FlightBookingResponse";
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
        
        [Schema(@"http://schemas.datacontract.org/2004/07/FlightBookingService",@"FlightBookingRequest")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"FlightBookingRequest"})]
        public sealed class FlightBookingRequest : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public FlightBookingRequest() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "FlightBookingRequest";
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
        
        [Schema(@"http://schemas.datacontract.org/2004/07/FlightBookingService",@"FlightBookingResponse")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"FlightBookingResponse"})]
        public sealed class FlightBookingResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public FlightBookingResponse() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "FlightBookingResponse";
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
