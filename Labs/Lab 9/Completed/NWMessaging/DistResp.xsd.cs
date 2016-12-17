namespace NWMessaging {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://NWMessaging.DistResp",@"WarehouseResponse")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Status", XPath = @"/*[local-name()='WarehouseResponse' and namespace-uri()='http://NWMessaging.DistResp']/*[local-name()='Status' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::NWMessaging.CustomerPONumber), XPath = @"/*[local-name()='WarehouseResponse' and namespace-uri()='http://NWMessaging.DistResp']/*[local-name()='CustomerPONumber' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"WarehouseResponse"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"NWMessaging.PropertySchema", typeof(global::NWMessaging.PropertySchema))]
    public sealed class DistResp : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://NWMessaging.DistResp"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns1=""http://NWMessaging.PropertySchema.PropertySchema"" targetNamespace=""http://NWMessaging.DistResp"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:imports>
        <b:namespace prefix=""ns1"" uri=""http://NWMessaging.PropertySchema.PropertySchema"" location=""NWMessaging.PropertySchema"" />
      </b:imports>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""WarehouseResponse"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='WarehouseResponse' and namespace-uri()='http://NWMessaging.DistResp']/*[local-name()='Status' and namespace-uri()='']"" />
          <b:property name=""ns1:CustomerPONumber"" xpath=""/*[local-name()='WarehouseResponse' and namespace-uri()='http://NWMessaging.DistResp']/*[local-name()='CustomerPONumber' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
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
