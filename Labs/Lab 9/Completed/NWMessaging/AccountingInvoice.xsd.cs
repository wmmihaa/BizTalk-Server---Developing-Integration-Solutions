namespace NWMessaging {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://NWMessaging.AccountingInvoice",@"Invoice")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Invoice"})]
    public sealed class AccountingInvoice : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns=""http://NWMessaging.AccountingInvoice"" targetNamespace=""http://NWMessaging.AccountingInvoice"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""Invoice"">
    <xs:complexType />
  </xs:element>
</xs:schema>";
        
        public AccountingInvoice() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Invoice";
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
