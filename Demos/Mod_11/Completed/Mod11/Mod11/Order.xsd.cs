namespace Mod11 {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://Mod11.Order",@"Order")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::Mod11.PropertySchema.OrderId), XPath = @"/*[local-name()='Order' and namespace-uri()='http://Mod11.Order']/*[local-name()='OrderId' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.Boolean), "Approved", XPath = @"/*[local-name()='Order' and namespace-uri()='http://Mod11.Order']/*[local-name()='Approved' and namespace-uri()='']", XsdType = @"boolean")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Order"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Mod11.PropertySchema.PropertySchema", typeof(global::Mod11.PropertySchema.PropertySchema))]
    public sealed class Order : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://Mod11.Order"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""https://Mod11.PropertySchema"" targetNamespace=""http://Mod11.Order"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:imports>
        <b:namespace prefix=""ns0"" uri=""https://Mod11.PropertySchema"" location=""Mod11.PropertySchema.PropertySchema"" />
      </b:imports>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""Order"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property name=""ns0:OrderId"" xpath=""/*[local-name()='Order' and namespace-uri()='http://Mod11.Order']/*[local-name()='OrderId' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='Order' and namespace-uri()='http://Mod11.Order']/*[local-name()='Approved' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""OrderId"" type=""xs:string"" />
        <xs:element name=""CustomerName"" type=""xs:string"" />
        <xs:element name=""OrderDate"" type=""xs:dateTime"" />
        <xs:element name=""ShippingDate"" type=""xs:dateTime"" />
        <xs:element name=""ItemData"" type=""xs:string"" />
        <xs:element name=""TotalSum"" type=""xs:int"" />
        <xs:element name=""Approved"" type=""xs:boolean"" />
        <xs:element name=""DeliveryNotes"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public Order() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Order";
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
