namespace NWMessaging {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://NWMessaging.DistResp",@"WarehouseResponse")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"WarehouseResponse"})]
    public sealed class DistResp : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns=""http://NWMessaging.DistResp"" targetNamespace=""http://NWMessaging.DistResp"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""WarehouseResponse"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""CustomerPONumber"" type=""xs:string"" />
        <xs:element name=""Status"" type=""xs:string"" />
        <xs:element name=""DeliveryDate"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public DistResp() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "WarehouseResponse";
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
