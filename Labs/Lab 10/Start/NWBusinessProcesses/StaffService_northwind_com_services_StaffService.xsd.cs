namespace NWBusinessProcesses {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"ReserveStaff", @"StaffRequestData", @"ArrayOfItemData", @"ItemData", @"ReserveStaffResponse", @"StaffResponseData"})]
    public sealed class StaffService_northwind_com_services_StaffService : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:tns=""http://northwind.com/services/StaffService"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" elementFormDefault=""qualified"" targetNamespace=""http://northwind.com/services/StaffService"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""ReserveStaff"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""msg"" nillable=""true"" type=""tns:StaffRequestData"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:complexType name=""StaffRequestData"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""Items"" nillable=""true"" type=""tns:ArrayOfItemData"" />
      <xs:element minOccurs=""0"" name=""OrderId"" nillable=""true"" type=""xs:string"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""StaffRequestData"" nillable=""true"" type=""tns:StaffRequestData"" />
  <xs:complexType name=""ArrayOfItemData"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ItemData"" nillable=""true"" type=""tns:ItemData"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfItemData"" nillable=""true"" type=""tns:ArrayOfItemData"" />
  <xs:complexType name=""ItemData"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""ItemId"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""Quantity"" type=""xs:int"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ItemData"" nillable=""true"" type=""tns:ItemData"" />
  <xs:element name=""ReserveStaffResponse"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""ReserveStaffResult"" nillable=""true"" type=""tns:StaffResponseData"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:complexType name=""StaffResponseData"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""Success"" type=""xs:boolean"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""StaffResponseData"" nillable=""true"" type=""tns:StaffResponseData"" />
</xs:schema>";
        
        public StaffService_northwind_com_services_StaffService() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [6];
                _RootElements[0] = "ReserveStaff";
                _RootElements[1] = "StaffRequestData";
                _RootElements[2] = "ArrayOfItemData";
                _RootElements[3] = "ItemData";
                _RootElements[4] = "ReserveStaffResponse";
                _RootElements[5] = "StaffResponseData";
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
        
        [Schema(@"http://northwind.com/services/StaffService",@"ReserveStaff")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ReserveStaff"})]
        public sealed class ReserveStaff : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ReserveStaff() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ReserveStaff";
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
        
        [Schema(@"http://northwind.com/services/StaffService",@"StaffRequestData")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"StaffRequestData"})]
        public sealed class StaffRequestData : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public StaffRequestData() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "StaffRequestData";
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
        
        [Schema(@"http://northwind.com/services/StaffService",@"ArrayOfItemData")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfItemData"})]
        public sealed class ArrayOfItemData : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfItemData() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfItemData";
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
        
        [Schema(@"http://northwind.com/services/StaffService",@"ItemData")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ItemData"})]
        public sealed class ItemData : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ItemData() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ItemData";
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
        
        [Schema(@"http://northwind.com/services/StaffService",@"ReserveStaffResponse")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ReserveStaffResponse"})]
        public sealed class ReserveStaffResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ReserveStaffResponse() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ReserveStaffResponse";
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
        
        [Schema(@"http://northwind.com/services/StaffService",@"StaffResponseData")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"StaffResponseData"})]
        public sealed class StaffResponseData : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public StaffResponseData() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "StaffResponseData";
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
