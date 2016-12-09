namespace ErrorHandling {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://ErrorHandling.ProcessedExpenses",@"Expenses")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Explaination", XPath = @"/*[local-name()='Expenses' and namespace-uri()='http://ErrorHandling.ProcessedExpenses']/*[local-name()='Explaination' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.DateTime), "ProcessedExpenses.SubmissionDate", XPath = @"/*[local-name()='Expenses' and namespace-uri()='http://ErrorHandling.ProcessedExpenses']/*[local-name()='ProcessedExpenses' and namespace-uri()='']/*[local-name()='SubmissionDate' and namespace-uri()='']", XsdType = @"date")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Expenses"})]
    public sealed class ProcessedExpenses : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://ErrorHandling.ProcessedExpenses"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://ErrorHandling.ProcessedExpenses"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""Expenses"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='Expenses' and namespace-uri()='http://ErrorHandling.ProcessedExpenses']/*[local-name()='Explaination' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='Expenses' and namespace-uri()='http://ErrorHandling.ProcessedExpenses']/*[local-name()='ProcessedExpenses' and namespace-uri()='']/*[local-name()='SubmissionDate' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""ProcessedExpenses"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""Name"" type=""xs:string"" />
              <xs:element name=""Status"" type=""xs:string"" />
              <xs:element name=""SubmissionDate"" type=""xs:date"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""TotalExpenses"" type=""xs:string"" />
        <xs:element name=""Explaination"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public ProcessedExpenses() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Expenses";
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
