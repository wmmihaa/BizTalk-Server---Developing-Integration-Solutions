namespace NWMessaging {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://NWMessaging.OrderResponse",@"OrderResponse")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"OrderResponse"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"NWMessaging.PropertySchema", typeof(global::NWMessaging.PropertySchema))]
    public sealed class OrderResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://NWMessaging.OrderResponse"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns1=""http://NWMessaging.PropertySchema.PropertySchema"" targetNamespace=""http://NWMessaging.OrderResponse"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:imports>
        <b:namespace prefix=""ns1"" uri=""http://NWMessaging.PropertySchema.PropertySchema"" location=""NWMessaging.PropertySchema"" />
      </b:imports>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""OrderResponse"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""CustomerPONumber"" type=""xs:string"" />
        <xs:element name=""Expected_x0020_Date"" type=""xs:string"" />
        <xs:element name=""Status"" type=""xs:string"" />
        <xs:element name=""Comments"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public OrderResponse() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "OrderResponse";
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
