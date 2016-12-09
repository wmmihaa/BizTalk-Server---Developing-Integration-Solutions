namespace TravelService {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://TravelService.TravelResponse",@"TravelResponse")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"TravelResponse"})]
    public sealed class TravelResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://TravelService.TravelResponse"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://TravelService.TravelResponse"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""TravelResponse"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Approved"" type=""xs:boolean"" />
        <xs:element name=""BookingNotes"" type=""xs:string"" />
        <xs:element name=""AmountCharged"" type=""xs:double"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public TravelResponse() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "TravelResponse";
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
