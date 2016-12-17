namespace Lunch {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://Lunch.Restaurang",@"Restaurang")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Restaurang"})]
    public sealed class Restaurang : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://Lunch.Restaurang"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://Lunch.Restaurang"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""Restaurang"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""GoodPlaceToEat"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public Restaurang() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Restaurang";
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
