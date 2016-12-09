namespace Lab7b {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://A372.Tweet",@"Tweet")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Tweet"})]
    public sealed class Tweet : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://A372.Tweet"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://A372.Tweet"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""Tweet"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""name"" type=""xs:string"" />
        <xs:element name=""tweet"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public Tweet() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Tweet";
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
