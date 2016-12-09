namespace TravelService {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"HotelBookingRequest", @"HotelBookingResponse"})]
    public sealed class HotelBookingService_schemas_datacontract_org_2004_07_HotelBookingService : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:tns=""http://schemas.datacontract.org/2004/07/HotelBookingService"" elementFormDefault=""qualified"" targetNamespace=""http://schemas.datacontract.org/2004/07/HotelBookingService"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:complexType name=""HotelBookingRequest"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CreditCardNumber"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""Customer"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""FromDate"" type=""xs:dateTime"" />
      <xs:element minOccurs=""0"" name=""Notes"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""NumberOfNights"" type=""xs:int"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""HotelBookingRequest"" nillable=""true"" type=""tns:HotelBookingRequest"" />
  <xs:complexType name=""HotelBookingResponse"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""AmountCharged"" type=""xs:double"" />
      <xs:element minOccurs=""0"" name=""Approved"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""BookingNotes"" nillable=""true"" type=""xs:string"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""HotelBookingResponse"" nillable=""true"" type=""tns:HotelBookingResponse"" />
</xs:schema>";
        
        public HotelBookingService_schemas_datacontract_org_2004_07_HotelBookingService() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [2];
                _RootElements[0] = "HotelBookingRequest";
                _RootElements[1] = "HotelBookingResponse";
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
        
        [Schema(@"http://schemas.datacontract.org/2004/07/HotelBookingService",@"HotelBookingRequest")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"HotelBookingRequest"})]
        public sealed class HotelBookingRequest : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public HotelBookingRequest() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "HotelBookingRequest";
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
        
        [Schema(@"http://schemas.datacontract.org/2004/07/HotelBookingService",@"HotelBookingResponse")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"HotelBookingResponse"})]
        public sealed class HotelBookingResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public HotelBookingResponse() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "HotelBookingResponse";
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
