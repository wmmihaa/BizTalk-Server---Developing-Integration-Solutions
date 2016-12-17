namespace NWMessaging {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://NWMessaging.ShippingAddress",@"ShippingAddress")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"ShippingAddress"})]
    public sealed class ShippingAddress : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://NWMessaging.ShippingAddress"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://NWMessaging.ShippingAddress"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""ShippingAddress"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""City"" type=""xs:string"" />
        <xs:element name=""Country"" type=""xs:string"" />
        <xs:element name=""Street"" type=""xs:string"" />
        <xs:element name=""Email"" type=""xs:string"" />
        <xs:element name=""Fax"" type=""xs:string"" />
        <xs:element name=""State"" type=""xs:string"" />
        <xs:element name=""Zip"" type=""xs:string"" />
        <xs:element name=""Phone"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public ShippingAddress() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "ShippingAddress";
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
