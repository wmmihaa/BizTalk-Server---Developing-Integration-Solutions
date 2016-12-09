namespace NWBusinessProcesses {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"ReserveDistributor", @"DistributorRequestData", @"ReserveDistributorResponse", @"DistributorResponseData"})]
    public sealed class DistributorService_northwind_com_services_DistributorService : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:tns=""http://northwind.com/services/DistributorService"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" elementFormDefault=""qualified"" targetNamespace=""http://northwind.com/services/DistributorService"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""ReserveDistributor"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""msg"" nillable=""true"" type=""tns:DistributorRequestData"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:complexType name=""DistributorRequestData"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""City"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""Country"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""FreightAmount"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""OrderId"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""State"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""Street"" nillable=""true"" type=""xs:string"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""DistributorRequestData"" nillable=""true"" type=""tns:DistributorRequestData"" />
  <xs:element name=""ReserveDistributorResponse"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""ReserveDistributorResult"" nillable=""true"" type=""tns:DistributorResponseData"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:complexType name=""DistributorResponseData"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""Accepted"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" name=""ShippingDate"" type=""xs:dateTime"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""DistributorResponseData"" nillable=""true"" type=""tns:DistributorResponseData"" />
</xs:schema>";
        
        public DistributorService_northwind_com_services_DistributorService() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [4];
                _RootElements[0] = "ReserveDistributor";
                _RootElements[1] = "DistributorRequestData";
                _RootElements[2] = "ReserveDistributorResponse";
                _RootElements[3] = "DistributorResponseData";
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
        
        [Schema(@"http://northwind.com/services/DistributorService",@"ReserveDistributor")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ReserveDistributor"})]
        public sealed class ReserveDistributor : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ReserveDistributor() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ReserveDistributor";
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
        
        [Schema(@"http://northwind.com/services/DistributorService",@"DistributorRequestData")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"DistributorRequestData"})]
        public sealed class DistributorRequestData : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public DistributorRequestData() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "DistributorRequestData";
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
        
        [Schema(@"http://northwind.com/services/DistributorService",@"ReserveDistributorResponse")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ReserveDistributorResponse"})]
        public sealed class ReserveDistributorResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ReserveDistributorResponse() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ReserveDistributorResponse";
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
        
        [Schema(@"http://northwind.com/services/DistributorService",@"DistributorResponseData")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"DistributorResponseData"})]
        public sealed class DistributorResponseData : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public DistributorResponseData() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "DistributorResponseData";
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
