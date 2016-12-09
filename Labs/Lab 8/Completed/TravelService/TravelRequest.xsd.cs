namespace TravelService {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://TravelService.TravelRequest",@"TravelRequest")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"TravelRequest"})]
    public sealed class TravelRequest : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://TravelService.TravelRequest"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://TravelService.TravelRequest"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""TravelRequest"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Customer"" type=""xs:string"" />
        <xs:element name=""CreditCardNumber"" type=""xs:string"" />
        <xs:element name=""DepartureFrom"" type=""xs:string"" />
        <xs:element name=""DepartureDate"" type=""xs:dateTime"" />
        <xs:element name=""Destination"" type=""xs:string"" />
        <xs:element name=""NumberOfNights"" type=""xs:int"" />
        <xs:element name=""Notes"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public TravelRequest() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "TravelRequest";
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
