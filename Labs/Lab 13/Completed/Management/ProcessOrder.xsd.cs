namespace Management {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://Management.ProcessOrder",@"ProcessOrder")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::Management.POId), XPath = @"/*[local-name()='ProcessOrder' and namespace-uri()='http://Management.ProcessOrder']/*[local-name()='OrderInfo' and namespace-uri()='']/*[local-name()='POId' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::Management.OrderDate), XPath = @"/*[local-name()='ProcessOrder' and namespace-uri()='http://Management.ProcessOrder']/*[local-name()='OrderInfo' and namespace-uri()='']/*[local-name()='OrderDate' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"ProcessOrder"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Management.PropertySchema", typeof(global::Management.PropertySchema))]
    public sealed class ProcessOrder : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://Management.ProcessOrder"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""http://Management.PropertySchema.PropertySchema"" targetNamespace=""http://Management.ProcessOrder"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:imports>
        <b:namespace prefix=""ns0"" uri=""http://Management.PropertySchema.PropertySchema"" location=""Management.PropertySchema"" />
      </b:imports>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""ProcessOrder"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property name=""ns0:POId"" xpath=""/*[local-name()='ProcessOrder' and namespace-uri()='http://Management.ProcessOrder']/*[local-name()='OrderInfo' and namespace-uri()='']/*[local-name()='POId' and namespace-uri()='']"" />
          <b:property name=""ns0:OrderDate"" xpath=""/*[local-name()='ProcessOrder' and namespace-uri()='http://Management.ProcessOrder']/*[local-name()='OrderInfo' and namespace-uri()='']/*[local-name()='OrderDate' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""OrderInfo"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""POId"" type=""xs:string"" />
              <xs:element name=""OrderDate"" type=""xs:string"" />
              <xs:element name=""SalesRepID"" type=""xs:string"" />
              <xs:element name=""Quote"" type=""xs:string"" />
              <xs:element name=""ProcessDate"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""CustomerInfo"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""Address"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""Street"" type=""xs:string"" />
                    <xs:element name=""City"" type=""xs:string"" />
                    <xs:element name=""State"" type=""xs:string"" />
                    <xs:element name=""Zip"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""PhoneNumber"" type=""xs:string"" />
            </xs:sequence>
            <xs:attribute name=""Title"" type=""xs:string"" use=""required"" />
            <xs:attribute name=""FirstName"" type=""xs:string"" />
            <xs:attribute name=""LastName"" type=""xs:string"" />
          </xs:complexType>
        </xs:element>
        <xs:element name=""Items"">
          <xs:complexType>
            <xs:sequence>
              <xs:element maxOccurs=""unbounded"" name=""ItemInfo"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""ProductNumber"" type=""xs:string"" />
                    <xs:element name=""Qty"" type=""xs:string"" />
                    <xs:element name=""Price"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""Comment"" type=""xs:string"" />
        <xs:element name=""Total"" type=""xs:decimal"" />
        <xs:element name=""Priority"" type=""xs:string"" />
        <xs:element name=""Status"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public ProcessOrder() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "ProcessOrder";
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
