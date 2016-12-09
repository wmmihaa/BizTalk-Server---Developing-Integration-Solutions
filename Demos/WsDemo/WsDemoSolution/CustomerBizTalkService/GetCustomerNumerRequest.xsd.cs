namespace CustomerBizTalkService {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://CustomerBizTalkService.GetCustomerNumerRequest",@"GetCustomerNumerRequest")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "name", XPath = @"/*[local-name()='GetCustomerNumerRequest' and namespace-uri()='http://CustomerBizTalkService.GetCustomerNumerRequest']/@*[local-name()='name' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"GetCustomerNumerRequest"})]
    public sealed class GetCustomerNumerRequest : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://CustomerBizTalkService.GetCustomerNumerRequest"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://CustomerBizTalkService.GetCustomerNumerRequest"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""GetCustomerNumerRequest"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='GetCustomerNumerRequest' and namespace-uri()='http://CustomerBizTalkService.GetCustomerNumerRequest']/@*[local-name()='name' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:attribute name=""name"" type=""xs:string"" />
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public GetCustomerNumerRequest() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "GetCustomerNumerRequest";
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
