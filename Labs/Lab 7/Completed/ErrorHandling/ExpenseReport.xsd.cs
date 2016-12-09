namespace ErrorHandling {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.Byte), "TotalExpenses", XPath = @"/*[local-name()='ExpenseReport' and namespace-uri()='http://ExpenseReports.ExpenseReport']/*[local-name()='TotalExpenses' and namespace-uri()='http://ExpenseReports.ExpenseReport']", XsdType = @"unsignedByte")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Header.Status", XPath = @"/*[local-name()='ExpenseReport' and namespace-uri()='http://ExpenseReports.ExpenseReport']/*[local-name()='Header' and namespace-uri()='http://ExpenseReports.ExpenseReport']/*[local-name()='Status' and namespace-uri()='http://ExpenseReports.ExpenseReport']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::ErrorHandling.PropertySchema.EmployeeID), XPath = @"/*[local-name()='ExpenseReport' and namespace-uri()='http://ExpenseReports.ExpenseReport']/*[local-name()='Employee' and namespace-uri()='http://ExpenseReports.ExpenseReport']/*[local-name()='EmployeeID' and namespace-uri()='http://ExpenseReports.ExpenseReport']", XsdType = @"unsignedShort")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::ErrorHandling.PropertySchema.SubmissionDate), XPath = @"/*[local-name()='ExpenseReport' and namespace-uri()='http://ExpenseReports.ExpenseReport']/*[local-name()='Header' and namespace-uri()='http://ExpenseReports.ExpenseReport']/*[local-name()='SubmissionDate' and namespace-uri()='http://ExpenseReports.ExpenseReport']", XsdType = @"date")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::ErrorHandling.PropertySchema.Status), XPath = @"/*[local-name()='ExpenseReport' and namespace-uri()='http://ExpenseReports.ExpenseReport']/*[local-name()='Header' and namespace-uri()='http://ExpenseReports.ExpenseReport']/*[local-name()='Status' and namespace-uri()='http://ExpenseReports.ExpenseReport']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"ExpenseReport", @"Header", @"Employee", @"Manager", @"Items", @"SubTotal", @"CashAdvance", @"TotalExpenses"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ErrorHandling.PropertySchema.PropertySchema", typeof(global::ErrorHandling.PropertySchema.PropertySchema))]
    public sealed class ExpenseReportMessageType : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:tns=""http://ExpenseReports.ExpenseReport"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""http://ErrorHandling.PropertySchema.PropertySchema"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" targetNamespace=""http://ExpenseReports.ExpenseReport"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:imports>
        <b:namespace prefix=""ns0"" uri=""http://ErrorHandling.PropertySchema.PropertySchema"" location=""ErrorHandling.PropertySchema.PropertySchema"" />
      </b:imports>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""ExpenseReport"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='ExpenseReport' and namespace-uri()='http://ExpenseReports.ExpenseReport']/*[local-name()='TotalExpenses' and namespace-uri()='http://ExpenseReports.ExpenseReport']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='ExpenseReport' and namespace-uri()='http://ExpenseReports.ExpenseReport']/*[local-name()='Header' and namespace-uri()='http://ExpenseReports.ExpenseReport']/*[local-name()='Status' and namespace-uri()='http://ExpenseReports.ExpenseReport']"" />
          <b:property name=""ns0:EmployeeID"" xpath=""/*[local-name()='ExpenseReport' and namespace-uri()='http://ExpenseReports.ExpenseReport']/*[local-name()='Employee' and namespace-uri()='http://ExpenseReports.ExpenseReport']/*[local-name()='EmployeeID' and namespace-uri()='http://ExpenseReports.ExpenseReport']"" />
          <b:property name=""ns0:SubmissionDate"" xpath=""/*[local-name()='ExpenseReport' and namespace-uri()='http://ExpenseReports.ExpenseReport']/*[local-name()='Header' and namespace-uri()='http://ExpenseReports.ExpenseReport']/*[local-name()='SubmissionDate' and namespace-uri()='http://ExpenseReports.ExpenseReport']"" />
          <b:property name=""ns0:Status"" xpath=""/*[local-name()='ExpenseReport' and namespace-uri()='http://ExpenseReports.ExpenseReport']/*[local-name()='Header' and namespace-uri()='http://ExpenseReports.ExpenseReport']/*[local-name()='Status' and namespace-uri()='http://ExpenseReports.ExpenseReport']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""tns:Header"" />
        <xs:element ref=""tns:Employee"" />
        <xs:element ref=""tns:Manager"" />
        <xs:element ref=""tns:Items"" />
        <xs:element ref=""tns:SubTotal"" />
        <xs:element ref=""tns:CashAdvance"" />
        <xs:element ref=""tns:TotalExpenses"" />
        <xs:element name=""Errors"" type=""tns:xhtml"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:complexType name=""xhtml"" mixed=""true"">
    <xs:sequence>
      <xs:any minOccurs=""0"" maxOccurs=""unbounded"" namespace=""http://www.w3.org/1999/xhtml"" processContents=""lax"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""Header"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Reference"" type=""xs:anyType"" />
        <xs:element name=""Status"" type=""xs:string"" />
        <xs:element name=""SubmissionDate"" type=""xs:date"" />
        <xs:element name=""PeriodFrom"" nillable=""true"" type=""xs:anyType"" />
        <xs:element name=""PeriodTo"" nillable=""true"" type=""xs:anyType"" />
        <xs:element name=""CostCenter"" type=""xs:anyType"" />
        <xs:element name=""Purpose"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""Employee"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""EmployeeID"" type=""xs:unsignedShort"" />
        <xs:element name=""FirstName"" type=""xs:string"" />
        <xs:element name=""LastName"" type=""xs:string"" />
        <xs:element name=""Email"">
          <xs:simpleType>
            <xs:restriction base=""xs:string"">
              <xs:pattern value=""\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element name=""JobTitle"" type=""xs:string"" />
        <xs:element name=""Department"" type=""xs:string"" />
        <xs:element name=""Phone"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""Manager"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""EmployeeID"" type=""xs:unsignedShort"" />
        <xs:element name=""FirstName"" type=""xs:string"" />
        <xs:element name=""LastName"" type=""xs:string"" />
        <xs:element name=""Email"">
          <xs:simpleType>
            <xs:restriction base=""xs:string"">
              <xs:pattern value=""\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element name=""JobTitle"" type=""xs:string"" />
        <xs:element name=""Department"" type=""xs:string"" />
        <xs:element name=""Phone"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""Items"">
    <xs:complexType>
      <xs:sequence>
        <xs:element maxOccurs=""unbounded"" name=""Item"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""ExpenseDate"" type=""xs:date"" />
              <xs:element name=""Description"" type=""xs:string"" />
              <xs:element name=""Category"" type=""xs:string"" />
              <xs:element name=""Cost"" type=""xs:string"" />
              <xs:element name=""Currency"" type=""xs:string"" />
              <xs:element name=""Rate"" type=""xs:unsignedByte"" />
              <xs:element name=""Total"" type=""xs:unsignedByte"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""SubTotal"" type=""xs:unsignedByte"" />
  <xs:element name=""CashAdvance"" type=""xs:unsignedByte"" />
  <xs:element name=""TotalExpenses"" type=""xs:unsignedByte"" />
</xs:schema>";
        
        public ExpenseReportMessageType() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [8];
                _RootElements[0] = "ExpenseReport";
                _RootElements[1] = "Header";
                _RootElements[2] = "Employee";
                _RootElements[3] = "Manager";
                _RootElements[4] = "Items";
                _RootElements[5] = "SubTotal";
                _RootElements[6] = "CashAdvance";
                _RootElements[7] = "TotalExpenses";
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
        
        [Schema(@"http://ExpenseReports.ExpenseReport",@"ExpenseReport")]
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.Byte), "TotalExpenses", XPath = @"/*[local-name()='ExpenseReport' and namespace-uri()='http://ExpenseReports.ExpenseReport']/*[local-name()='TotalExpenses' and namespace-uri()='http://ExpenseReports.ExpenseReport']", XsdType = @"unsignedByte")]
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Header.Status", XPath = @"/*[local-name()='ExpenseReport' and namespace-uri()='http://ExpenseReports.ExpenseReport']/*[local-name()='Header' and namespace-uri()='http://ExpenseReports.ExpenseReport']/*[local-name()='Status' and namespace-uri()='http://ExpenseReports.ExpenseReport']", XsdType = @"string")]
        [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::ErrorHandling.PropertySchema.EmployeeID), XPath = @"/*[local-name()='ExpenseReport' and namespace-uri()='http://ExpenseReports.ExpenseReport']/*[local-name()='Employee' and namespace-uri()='http://ExpenseReports.ExpenseReport']/*[local-name()='EmployeeID' and namespace-uri()='http://ExpenseReports.ExpenseReport']", XsdType = @"unsignedShort")]
        [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::ErrorHandling.PropertySchema.SubmissionDate), XPath = @"/*[local-name()='ExpenseReport' and namespace-uri()='http://ExpenseReports.ExpenseReport']/*[local-name()='Header' and namespace-uri()='http://ExpenseReports.ExpenseReport']/*[local-name()='SubmissionDate' and namespace-uri()='http://ExpenseReports.ExpenseReport']", XsdType = @"date")]
        [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::ErrorHandling.PropertySchema.Status), XPath = @"/*[local-name()='ExpenseReport' and namespace-uri()='http://ExpenseReports.ExpenseReport']/*[local-name()='Header' and namespace-uri()='http://ExpenseReports.ExpenseReport']/*[local-name()='Status' and namespace-uri()='http://ExpenseReports.ExpenseReport']", XsdType = @"string")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ExpenseReport"})]
        public sealed class ExpenseReport : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ExpenseReport() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ExpenseReport";
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
        
        [Schema(@"http://ExpenseReports.ExpenseReport",@"Header")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Header"})]
        public sealed class Header : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Header() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Header";
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
        
        [Schema(@"http://ExpenseReports.ExpenseReport",@"Employee")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Employee"})]
        public sealed class Employee : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Employee() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Employee";
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
        
        [Schema(@"http://ExpenseReports.ExpenseReport",@"Manager")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Manager"})]
        public sealed class Manager : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Manager() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Manager";
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
        
        [Schema(@"http://ExpenseReports.ExpenseReport",@"Items")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Items"})]
        public sealed class Items : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Items() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Items";
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
        
        [Schema(@"http://ExpenseReports.ExpenseReport",@"SubTotal")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"SubTotal"})]
        public sealed class SubTotal : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public SubTotal() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "SubTotal";
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
        
        [Schema(@"http://ExpenseReports.ExpenseReport",@"CashAdvance")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"CashAdvance"})]
        public sealed class CashAdvance : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public CashAdvance() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "CashAdvance";
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
        
        [Schema(@"http://ExpenseReports.ExpenseReport",@"TotalExpenses")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"TotalExpenses"})]
        public sealed class TotalExpenses : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public TotalExpenses() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "TotalExpenses";
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
}
