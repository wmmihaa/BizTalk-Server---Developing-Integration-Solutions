namespace Lunch {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://Lunch.LunchEnvelope",@"Luncher")]
    [BodyXPath(@"/*[local-name()='Luncher' and namespace-uri()='http://Lunch.LunchEnvelope']")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Luncher"})]
    public sealed class LunchEnvelope : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://Lunch.LunchEnvelope"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://Lunch.LunchEnvelope"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:schemaInfo is_envelope=""yes"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" />
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""Luncher"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo body_xpath=""/*[local-name()='Luncher' and namespace-uri()='http://Lunch.LunchEnvelope']"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType />
  </xs:element>
</xs:schema>";
        
        public LunchEnvelope() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Luncher";
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
