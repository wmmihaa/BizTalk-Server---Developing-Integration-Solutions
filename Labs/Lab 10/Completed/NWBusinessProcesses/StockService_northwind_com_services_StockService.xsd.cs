namespace NWBusinessProcesses {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [SchemaType(SchemaTypeEnum.Document)]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.Boolean), "ReserveStockResult.Success", XPath = @"/*[local-name()='ReserveStockResponse' and namespace-uri()='http://northwind.com/services/StockService']/*[local-name()='ReserveStockResult' and namespace-uri()='http://northwind.com/services/StockService']/*[local-name()='Success' and namespace-uri()='http://northwind.com/services/StockService']", XsdType = @"boolean")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"ReserveStock", @"StockRequestData", @"ArrayOfItemData", @"ItemData", @"ReserveStockResponse", @"StockResponseData"})]
    public sealed class StockService_northwind_com_services_StockService : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:tns=""http://northwind.com/services/StockService"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" elementFormDefault=""qualified"" targetNamespace=""http://northwind.com/services/StockService"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""ReserveStock"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""msg"" nillable=""true"" type=""tns:StockRequestData"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:complexType name=""StockRequestData"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""Items"" nillable=""true"" type=""tns:ArrayOfItemData"" />
      <xs:element minOccurs=""0"" name=""OrderId"" nillable=""true"" type=""xs:string"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""StockRequestData"" nillable=""true"" type=""tns:StockRequestData"" />
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
  <xs:element name=""ReserveStockResponse"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='ReserveStockResponse' and namespace-uri()='http://northwind.com/services/StockService']/*[local-name()='ReserveStockResult' and namespace-uri()='http://northwind.com/services/StockService']/*[local-name()='Success' and namespace-uri()='http://northwind.com/services/StockService']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""ReserveStockResult"" nillable=""true"" type=""tns:StockResponseData"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:complexType name=""StockResponseData"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""Success"" type=""xs:boolean"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""StockResponseData"" nillable=""true"" type=""tns:StockResponseData"" />
</xs:schema>";
        
        public StockService_northwind_com_services_StockService() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [6];
                _RootElements[0] = "ReserveStock";
                _RootElements[1] = "StockRequestData";
                _RootElements[2] = "ArrayOfItemData";
                _RootElements[3] = "ItemData";
                _RootElements[4] = "ReserveStockResponse";
                _RootElements[5] = "StockResponseData";
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
        
        [Schema(@"http://northwind.com/services/StockService",@"ReserveStock")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ReserveStock"})]
        public sealed class ReserveStock : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ReserveStock() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ReserveStock";
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
        
        [Schema(@"http://northwind.com/services/StockService",@"StockRequestData")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"StockRequestData"})]
        public sealed class StockRequestData : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public StockRequestData() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "StockRequestData";
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
        
        [Schema(@"http://northwind.com/services/StockService",@"ArrayOfItemData")]
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
        
        [Schema(@"http://northwind.com/services/StockService",@"ItemData")]
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
        
        [Schema(@"http://northwind.com/services/StockService",@"ReserveStockResponse")]
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.Boolean), "ReserveStockResult.Success", XPath = @"/*[local-name()='ReserveStockResponse' and namespace-uri()='http://northwind.com/services/StockService']/*[local-name()='ReserveStockResult' and namespace-uri()='http://northwind.com/services/StockService']/*[local-name()='Success' and namespace-uri()='http://northwind.com/services/StockService']", XsdType = @"boolean")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ReserveStockResponse"})]
        public sealed class ReserveStockResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ReserveStockResponse() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ReserveStockResponse";
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
        
        [Schema(@"http://northwind.com/services/StockService",@"StockResponseData")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"StockResponseData"})]
        public sealed class StockResponseData : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public StockResponseData() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "StockResponseData";
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
