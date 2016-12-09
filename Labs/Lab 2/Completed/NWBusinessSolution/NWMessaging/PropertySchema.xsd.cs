namespace NWMessaging.PropertySchema {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [SchemaType(SchemaTypeEnum.Property)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Property1", @"CustomerPONumber", @"TotalOrderAmount"})]
    public sealed class PropertySchema : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns=""http://NWMessaging.PropertySchema"" targetNamespace=""https://NWMessaging.PropertySchema"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:schemaInfo schema_type=""property"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" />
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""Property1"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo propertyGuid=""d0780a65-5181-4717-94d4-73a6dc5ca1f0"" />
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""CustomerPONumber"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo propertyGuid=""19cf8601-d5f1-4f89-a77d-e871b865480f"" />
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""TotalOrderAmount"" type=""xs:double"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo propertyGuid=""be9d6b8b-a365-4c37-b4f4-d54326c0b3a8"" />
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
</xs:schema>";
        
        public PropertySchema() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [3];
                _RootElements[0] = "Property1";
                _RootElements[1] = "CustomerPONumber";
                _RootElements[2] = "TotalOrderAmount";
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
    
    [System.SerializableAttribute()]
    [PropertyType(@"Property1",@"https://NWMessaging.PropertySchema","string","System.String")]
    [PropertyGuidAttribute(@"d0780a65-5181-4717-94d4-73a6dc5ca1f0")]
    public sealed class Property1 : Microsoft.XLANGs.BaseTypes.MessageDataPropertyBase {
        
        [System.NonSerializedAttribute()]
        private static System.Xml.XmlQualifiedName _QName = new System.Xml.XmlQualifiedName(@"Property1", @"https://NWMessaging.PropertySchema");
        
        private static string PropertyValueType {
            get {
                throw new System.NotSupportedException();
            }
        }
        
        public override System.Xml.XmlQualifiedName Name {
            get {
                return _QName;
            }
        }
        
        public override System.Type Type {
            get {
                return typeof(string);
            }
        }
    }
    
    [System.SerializableAttribute()]
    [PropertyType(@"CustomerPONumber",@"https://NWMessaging.PropertySchema","string","System.String")]
    [PropertyGuidAttribute(@"19cf8601-d5f1-4f89-a77d-e871b865480f")]
    public sealed class CustomerPONumber : Microsoft.XLANGs.BaseTypes.MessageDataPropertyBase {
        
        [System.NonSerializedAttribute()]
        private static System.Xml.XmlQualifiedName _QName = new System.Xml.XmlQualifiedName(@"CustomerPONumber", @"https://NWMessaging.PropertySchema");
        
        private static string PropertyValueType {
            get {
                throw new System.NotSupportedException();
            }
        }
        
        public override System.Xml.XmlQualifiedName Name {
            get {
                return _QName;
            }
        }
        
        public override System.Type Type {
            get {
                return typeof(string);
            }
        }
    }
    
    [System.SerializableAttribute()]
    [PropertyType(@"TotalOrderAmount",@"https://NWMessaging.PropertySchema","double","System.Double")]
    [PropertyGuidAttribute(@"be9d6b8b-a365-4c37-b4f4-d54326c0b3a8")]
    public sealed class TotalOrderAmount : Microsoft.XLANGs.BaseTypes.MessageDataPropertyBase {
        
        [System.NonSerializedAttribute()]
        private static System.Xml.XmlQualifiedName _QName = new System.Xml.XmlQualifiedName(@"TotalOrderAmount", @"https://NWMessaging.PropertySchema");
        
        private static double PropertyValueType {
            get {
                throw new System.NotSupportedException();
            }
        }
        
        public override System.Xml.XmlQualifiedName Name {
            get {
                return _QName;
            }
        }
        
        public override System.Type Type {
            get {
                return typeof(double);
            }
        }
    }
}
