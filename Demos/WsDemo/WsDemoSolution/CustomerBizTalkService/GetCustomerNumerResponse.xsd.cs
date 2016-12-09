namespace CustomerBizTalkService {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://CustomerBizTalkService.GetCustomerNumerResponse",@"GetCustomerNumerResponse")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.Int32), "CustomerNumber", XPath = @"/*[local-name()='GetCustomerNumerResponse' and namespace-uri()='http://CustomerBizTalkService.GetCustomerNumerResponse']/@*[local-name()='CustomerNumber' and namespace-uri()='']", XsdType = @"int")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"GetCustomerNumerResponse"})]
    public sealed class GetCustomerNumerResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://CustomerBizTalkService.GetCustomerNumerResponse"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://CustomerBizTalkService.GetCustomerNumerResponse"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""GetCustomerNumerResponse"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='GetCustomerNumerResponse' and namespace-uri()='http://CustomerBizTalkService.GetCustomerNumerResponse']/@*[local-name()='CustomerNumber' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:attribute name=""CustomerNumber"" type=""xs:int"" />
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public GetCustomerNumerResponse() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "GetCustomerNumerResponse";
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
