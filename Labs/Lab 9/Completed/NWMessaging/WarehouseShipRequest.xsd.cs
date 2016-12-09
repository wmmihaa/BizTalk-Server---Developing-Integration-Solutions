namespace NWMessaging {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://NWMessaging.WarehouseShipRequest",@"ShipRequest")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(NWMessaging.CustomerPONumber), XPath = @"/*[local-name()='ShipRequest' and namespace-uri()='http://NWMessaging.WarehouseShipRequest']/*[local-name()='CustomerOrderNumber' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"ShipRequest"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"NWMessaging.PropertySchema", typeof(NWMessaging.PropertySchema))]
    public sealed class WarehouseShipRequest : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:ns0=""http://NWMessaging.PropertySchema.PropertySchema"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns=""http://NWMessaging.WarehouseShipRequest"" targetNamespace=""http://NWMessaging.WarehouseShipRequest"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:imports>
        <b:namespace prefix=""ns0"" uri=""http://NWMessaging.PropertySchema.PropertySchema"" location=""NWMessaging.PropertySchema"" />
      </b:imports>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""ShipRequest"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property name=""ns0:CustomerPONumber"" xpath=""/*[local-name()='ShipRequest' and namespace-uri()='http://NWMessaging.WarehouseShipRequest']/*[local-name()='CustomerOrderNumber' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""CustomerOrderNumber"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public WarehouseShipRequest() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "ShipRequest";
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
