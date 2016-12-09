namespace NWBusinessProcesses {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"anyType", @"anyURI", @"base64Binary", @"boolean", @"byte", @"dateTime", @"decimal", @"double", @"float", @"int", @"long", @"QName", @"short", @"string", @"unsignedByte", @"unsignedInt", @"unsignedLong", @"unsignedShort", @"char", @"duration", @"guid"})]
    public sealed class StaffService_schemas_microsoft_com_2003_10_Serialization : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:tns=""http://schemas.microsoft.com/2003/10/Serialization/"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" attributeFormDefault=""qualified"" elementFormDefault=""qualified"" targetNamespace=""http://schemas.microsoft.com/2003/10/Serialization/"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""anyType"" nillable=""true"" type=""xs:anyType"" />
  <xs:element name=""anyURI"" nillable=""true"" type=""xs:anyURI"" />
  <xs:element name=""base64Binary"" nillable=""true"" type=""xs:base64Binary"" />
  <xs:element name=""boolean"" nillable=""true"" type=""xs:boolean"" />
  <xs:element name=""byte"" nillable=""true"" type=""xs:byte"" />
  <xs:element name=""dateTime"" nillable=""true"" type=""xs:dateTime"" />
  <xs:element name=""decimal"" nillable=""true"" type=""xs:decimal"" />
  <xs:element name=""double"" nillable=""true"" type=""xs:double"" />
  <xs:element name=""float"" nillable=""true"" type=""xs:float"" />
  <xs:element name=""int"" nillable=""true"" type=""xs:int"" />
  <xs:element name=""long"" nillable=""true"" type=""xs:long"" />
  <xs:element name=""QName"" nillable=""true"" type=""xs:QName"" />
  <xs:element name=""short"" nillable=""true"" type=""xs:short"" />
  <xs:element name=""string"" nillable=""true"" type=""xs:string"" />
  <xs:element name=""unsignedByte"" nillable=""true"" type=""xs:unsignedByte"" />
  <xs:element name=""unsignedInt"" nillable=""true"" type=""xs:unsignedInt"" />
  <xs:element name=""unsignedLong"" nillable=""true"" type=""xs:unsignedLong"" />
  <xs:element name=""unsignedShort"" nillable=""true"" type=""xs:unsignedShort"" />
  <xs:element name=""char"" nillable=""true"" type=""tns:char"" />
  <xs:simpleType name=""char"">
    <xs:restriction base=""xs:int"" />
  </xs:simpleType>
  <xs:element name=""duration"" nillable=""true"" type=""tns:duration"" />
  <xs:simpleType name=""duration"">
    <xs:restriction base=""xs:duration"">
      <xs:pattern value=""\-?P(\d*D)?(T(\d*H)?(\d*M)?(\d*(\.\d*)?S)?)?"" />
      <xs:minInclusive value=""-P10675199DT2H48M5.4775808S"" />
      <xs:maxInclusive value=""P10675199DT2H48M5.4775807S"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:element name=""guid"" nillable=""true"" type=""tns:guid"" />
  <xs:simpleType name=""guid"">
    <xs:restriction base=""xs:string"">
      <xs:pattern value=""[\da-fA-F]{8}-[\da-fA-F]{4}-[\da-fA-F]{4}-[\da-fA-F]{4}-[\da-fA-F]{12}"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:attribute name=""FactoryType"" type=""xs:QName"" />
  <xs:attribute name=""Id"" type=""xs:ID"" />
  <xs:attribute name=""Ref"" type=""xs:IDREF"" />
</xs:schema>";
        
        public StaffService_schemas_microsoft_com_2003_10_Serialization() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [21];
                _RootElements[0] = "anyType";
                _RootElements[1] = "anyURI";
                _RootElements[2] = "base64Binary";
                _RootElements[3] = "boolean";
                _RootElements[4] = "byte";
                _RootElements[5] = "dateTime";
                _RootElements[6] = "decimal";
                _RootElements[7] = "double";
                _RootElements[8] = "float";
                _RootElements[9] = "int";
                _RootElements[10] = "long";
                _RootElements[11] = "QName";
                _RootElements[12] = "short";
                _RootElements[13] = "string";
                _RootElements[14] = "unsignedByte";
                _RootElements[15] = "unsignedInt";
                _RootElements[16] = "unsignedLong";
                _RootElements[17] = "unsignedShort";
                _RootElements[18] = "char";
                _RootElements[19] = "duration";
                _RootElements[20] = "guid";
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
        
        [Schema(@"http://schemas.microsoft.com/2003/10/Serialization/",@"anyType")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"anyType"})]
        public sealed class anyType : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public anyType() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "anyType";
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
        
        [Schema(@"http://schemas.microsoft.com/2003/10/Serialization/",@"anyURI")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"anyURI"})]
        public sealed class anyURI : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public anyURI() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "anyURI";
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
        
        [Schema(@"http://schemas.microsoft.com/2003/10/Serialization/",@"base64Binary")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"base64Binary"})]
        public sealed class base64Binary : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public base64Binary() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "base64Binary";
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
        
        [Schema(@"http://schemas.microsoft.com/2003/10/Serialization/",@"boolean")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"boolean"})]
        public sealed class boolean : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public boolean() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "boolean";
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
        
        [Schema(@"http://schemas.microsoft.com/2003/10/Serialization/",@"byte")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"byte"})]
        public sealed class @byte : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public @byte() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "byte";
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
        
        [Schema(@"http://schemas.microsoft.com/2003/10/Serialization/",@"dateTime")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"dateTime"})]
        public sealed class dateTime : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public dateTime() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "dateTime";
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
        
        [Schema(@"http://schemas.microsoft.com/2003/10/Serialization/",@"decimal")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"decimal"})]
        public sealed class @decimal : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public @decimal() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "decimal";
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
        
        [Schema(@"http://schemas.microsoft.com/2003/10/Serialization/",@"double")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"double"})]
        public sealed class @double : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public @double() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "double";
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
        
        [Schema(@"http://schemas.microsoft.com/2003/10/Serialization/",@"float")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"float"})]
        public sealed class @float : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public @float() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "float";
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
        
        [Schema(@"http://schemas.microsoft.com/2003/10/Serialization/",@"int")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"int"})]
        public sealed class @int : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public @int() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "int";
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
        
        [Schema(@"http://schemas.microsoft.com/2003/10/Serialization/",@"long")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"long"})]
        public sealed class @long : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public @long() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "long";
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
        
        [Schema(@"http://schemas.microsoft.com/2003/10/Serialization/",@"QName")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"QName"})]
        public sealed class QName : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public QName() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "QName";
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
        
        [Schema(@"http://schemas.microsoft.com/2003/10/Serialization/",@"short")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"short"})]
        public sealed class @short : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public @short() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "short";
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
        
        [Schema(@"http://schemas.microsoft.com/2003/10/Serialization/",@"string")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"string"})]
        public sealed class @string : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public @string() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "string";
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
        
        [Schema(@"http://schemas.microsoft.com/2003/10/Serialization/",@"unsignedByte")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"unsignedByte"})]
        public sealed class unsignedByte : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public unsignedByte() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "unsignedByte";
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
        
        [Schema(@"http://schemas.microsoft.com/2003/10/Serialization/",@"unsignedInt")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"unsignedInt"})]
        public sealed class unsignedInt : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public unsignedInt() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "unsignedInt";
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
        
        [Schema(@"http://schemas.microsoft.com/2003/10/Serialization/",@"unsignedLong")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"unsignedLong"})]
        public sealed class unsignedLong : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public unsignedLong() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "unsignedLong";
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
        
        [Schema(@"http://schemas.microsoft.com/2003/10/Serialization/",@"unsignedShort")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"unsignedShort"})]
        public sealed class unsignedShort : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public unsignedShort() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "unsignedShort";
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
        
        [Schema(@"http://schemas.microsoft.com/2003/10/Serialization/",@"char")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"char"})]
        public sealed class @char : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public @char() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "char";
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
        
        [Schema(@"http://schemas.microsoft.com/2003/10/Serialization/",@"duration")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"duration"})]
        public sealed class duration : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public duration() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "duration";
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
        
        [Schema(@"http://schemas.microsoft.com/2003/10/Serialization/",@"guid")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"guid"})]
        public sealed class guid : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public guid() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "guid";
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
