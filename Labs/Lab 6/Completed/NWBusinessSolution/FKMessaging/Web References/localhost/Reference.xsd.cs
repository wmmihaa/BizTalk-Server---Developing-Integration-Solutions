namespace FKMessaging.localhost {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://tempuri.org/",@"SuppOrder")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"SuppOrder"})]
    public sealed class Reference : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:tns=""http://tempuri.org/"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" elementFormDefault=""qualified"" targetNamespace=""http://tempuri.org/"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""SuppOrder"" nillable=""true"" type=""tns:SuppOrder"" />
  <xs:complexType name=""SuppOrder"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""customerPONumber"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ItemId"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Quantity"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Priority"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""OrderDate"" type=""xs:string"" />
    </xs:sequence>
  </xs:complexType>
</xs:schema>";
        
        public Reference() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "SuppOrder";
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
