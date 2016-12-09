namespace NWMessaging {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://NWMessaging.CustomerOrder",@"CustomerOrder")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::NWMessaging.PropertySchema.CustomerPONumber), XPath = @"/*[local-name()='CustomerOrder' and namespace-uri()='http://NWMessaging.CustomerOrder']/*[local-name()='CustomerPONumber' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::NWMessaging.PropertySchema.TotalOrderAmount), XPath = @"/*[local-name()='CustomerOrder' and namespace-uri()='http://NWMessaging.CustomerOrder']/*[local-name()='TotalOrderAmount' and namespace-uri()='']", XsdType = @"double")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Status", XPath = @"/*[local-name()='CustomerOrder' and namespace-uri()='http://NWMessaging.CustomerOrder']/*[local-name()='Status' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Comments", XPath = @"/*[local-name()='CustomerOrder' and namespace-uri()='http://NWMessaging.CustomerOrder']/*[local-name()='Comments' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"CustomerOrder"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"NWMessaging.ShippingAddress", typeof(global::NWMessaging.ShippingAddress))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"NWMessaging.PropertySchema.PropertySchema", typeof(global::NWMessaging.PropertySchema.PropertySchema))]
    public sealed class CustomerOrder : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:ns2=""http://NWMessaging.PropertySchema.PropertySchema"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""http://OrderSchemas.PropertySchema"" xmlns=""http://NWMessaging.CustomerOrder"" xmlns:ns1=""http://NWMessaging.ShippingAddress"" targetNamespace=""http://NWMessaging.CustomerOrder"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""NWMessaging.ShippingAddress"" namespace=""http://NWMessaging.ShippingAddress"" />
  <xs:annotation>
    <xs:appinfo>
      <b:references>
        <b:reference targetNamespace=""http://NWMessaging.ShippingAddress"" />
      </b:references>
      <b:imports>
        <b:namespace prefix=""ns2"" uri=""http://NWMessaging.PropertySchema.PropertySchema"" location=""NWMessaging.PropertySchema.PropertySchema"" />
      </b:imports>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""CustomerOrder"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property name=""ns2:CustomerPONumber"" xpath=""/*[local-name()='CustomerOrder' and namespace-uri()='http://NWMessaging.CustomerOrder']/*[local-name()='CustomerPONumber' and namespace-uri()='']"" />
          <b:property name=""ns2:TotalOrderAmount"" xpath=""/*[local-name()='CustomerOrder' and namespace-uri()='http://NWMessaging.CustomerOrder']/*[local-name()='TotalOrderAmount' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='CustomerOrder' and namespace-uri()='http://NWMessaging.CustomerOrder']/*[local-name()='Status' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='CustomerOrder' and namespace-uri()='http://NWMessaging.CustomerOrder']/*[local-name()='Comments' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""CustomerName"" type=""xs:string"" />
        <xs:element name=""CustomerContact"" type=""xs:string"" />
        <xs:element name=""CustomerPONumber"" type=""xs:string"" />
        <xs:element name=""Priority"" type=""xs:string"" />
        <xs:element name=""QuoteReferenceID"" type=""xs:string"" />
        <xs:element name=""SalesOrderReferenceID"" type=""xs:string"" />
        <xs:element name=""CreatedDate"" type=""xs:string"" />
        <xs:element name=""FreightAmount"" type=""xs:string"" />
        <xs:element name=""MiscCharges"" type=""xs:string"" />
        <xs:element name=""SubTotal"" type=""xs:string"" />
        <xs:element name=""TotalOrderAmount"" type=""xs:double"" />
        <xs:element name=""Lines"">
          <xs:complexType>
            <xs:sequence>
              <xs:element maxOccurs=""unbounded"" name=""SalesOrderLine"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""LineNumber"" type=""xs:string"" />
                    <xs:element name=""UnitPrice"" type=""xs:string"" />
                    <xs:element name=""Quantity"" type=""xs:string"" />
                    <xs:element name=""ItemID"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""Status"" type=""xs:string"" />
        <xs:element name=""Comments"" type=""xs:string"" />
        <xs:element name=""UnitPrice"" type=""xs:string"" />
        <xs:element ref=""ns1:ShippingAddress"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public CustomerOrder() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "CustomerOrder";
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
