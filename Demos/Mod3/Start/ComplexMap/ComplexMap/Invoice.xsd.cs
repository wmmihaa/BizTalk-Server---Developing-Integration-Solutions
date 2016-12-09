namespace ComplexMap {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"",@"invoices")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"invoices"})]
    public sealed class Invoice : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" version=""1.0"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:schemaInfo BizTalkServerEditorTool_Version=""1.5"" root_reference=""invoices"" displayroot_reference=""invoices"" standard=""XML"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
      </b:schemaInfo>
    </xs:appinfo>
  </xs:annotation>
  <xs:annotation>
    <xs:documentation>Schema name: invoices</xs:documentation>
  </xs:annotation>
  <xs:element name=""vat_sum"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>Vat amount</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""vat_pros"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>MVA%</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""vat"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>MVA Belop</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""unitprice_prediscount"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""unit_price"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>Enh pris</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""textfield"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>Tekst fra leverantor for faktura</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""tax_percent"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>Mva%</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""tax_lineitem_subtotal"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""t9"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>Profile</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""t8"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>MVA</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""t7"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>Resource type</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""t6"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>Ps</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""t5"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>Periode</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""t43"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>Resource type name</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""t42"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>Pa</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""t41"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>Activity</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""t40"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>Dummytxt</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""t4"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>Open item</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""t39"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>Qty</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""t38"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>Operating unit</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""t37"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>MotKST</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""t36"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>Kst name</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""t34"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>Reference</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""t33"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>KST</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""t32"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>Motkonto</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""t31"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>Project</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""t3"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>Formål</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""t27"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>VAT Usetype</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""t26"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>IN/OUT</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""t24"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>Py</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""t23"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>Product name</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""t22"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>Product</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""t20"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>Activity name</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""t2"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>Baerer</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""t19"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>Profile name</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""t18"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>Qty name</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""t17"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>Tekst</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""t16"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>Konto</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""t15"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>Operating unit name</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""t14"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>Open item name</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""t13"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>Project name</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""t12"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>Avelingsnavn</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""t10"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>Kontonr</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""t1"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>Avdeling</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""supplier_fee"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""supplier_discrate"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""supplier_discount"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>Rabatt %</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""supplier"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""name"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""address1"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""address2"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""address3"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""orgno"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""locno"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""bankacc"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:choice>
    </xs:complexType>
  </xs:element>
  <xs:element name=""part_num_detail"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>Vare nr</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""orgno"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>OrgNr</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""ordered_qty"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""order_num"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>Ordrenr</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""net_lineitem_subtotal"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""name"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>Navn</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""messageversion"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""messagetype"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""messagetimestamp"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>Dato og kl xml var generert</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""locno"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>LokasjonsNr</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""linedescription"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>Beskrivelse</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""line_item_number"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""ioc_invoice_detail"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""line_item_number"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""part_num_detail"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""customer_part_num_detail"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""linedescription"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""ordered_qty"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""delievered_qty"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""unit_price"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""gross_lineitem_subtotal"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""tax_percent"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""net_lineitem_subtotal"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""tax_lineitem_subtotal"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""supplier_discount"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""supplier_fee"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""discount_payment_early"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""unitprice_prediscount"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""eanpartno"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""supplier_discrate"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:choice>
    </xs:complexType>
  </xs:element>
  <xs:element name=""invoicetype"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>Fakturatype faktura/kreditnota</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""invoices"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""invoice"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:choice>
    </xs:complexType>
  </xs:element>
  <xs:element name=""invoicee"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""name"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""address1"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""address2"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""address3"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""orgno"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""locno"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:choice>
    </xs:complexType>
  </xs:element>
  <xs:element name=""invoice_type"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>Fakturatype</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""invoice_sum_calc"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>Fakturabelop NOK</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""invoice_sum"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>Fakturabelop</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""invoice_num"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>Fakturanr</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""invoice_last_date"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>Forfallsdato</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""invoice_date"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>Fakturadato</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""invoice"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""messagetype"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""messageversion"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""messagetimestamp"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""invoicetype"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element ref=""docs"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element ref=""doc_data"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""ioc_invoice_detail"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""acc_data"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element ref=""supplier"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element ref=""buyer"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element ref=""invoicee"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""textfield"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""attachment"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:choice>
    </xs:complexType>
  </xs:element>
  <xs:element name=""gross_lineitem_subtotal"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>Sum</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""exchange_rate"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>Valutakurs</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""eanpartno"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""docs"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""invoicetype"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""invoice_num"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""invoice_date"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""invoice_last_date"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""invoice_sum"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""invoice_sum_calc"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""currency"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""exchange_rate"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""order_num"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""attrib_t6"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""attrib_t4"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""contract_num"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""invoice_type"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""attrib_d"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""attrib_d2"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""vat_sum"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""attrib_d3"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:choice>
    </xs:complexType>
  </xs:element>
  <xs:element name=""doc_data"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
        <xs:element minOccurs=""0"" ref=""data_value_3"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""data_value_13"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""data_value_17"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""data_value_23"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""data_value_24"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""data_value_25"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""data_value_26"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""data_value_27"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""data_value_28"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""data_value_30"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""data_value_38"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""data_value_39"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""data_value_40"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""data_value_43"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""data_value_44"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""data_value_45"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""data_value_48"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""data_value_49"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""data_value_50"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""data_value_51"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""data_value_52"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""data_value_54"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""data_value_55"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""data_value_56"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""data_value_57"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""data_value_58"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""data_value_59"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""data_value_60"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""data_value_61"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""data_value_62"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""data_value_63"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""data_value_64"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""data_value_65"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""data_value_66"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""data_value_100"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:choice>
      <xs:attribute name=""data_value_53"" type=""xs:string"" use=""optional"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
            </b:fieldInfo>
          </xs:appinfo>
        </xs:annotation>
      </xs:attribute>
    </xs:complexType>
  </xs:element>
  <xs:element name=""discount_payment_early"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""delievered_qty"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>Ant</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""data_value_66"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>Bank acc</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""data_value_65"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>EKB Period date</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""data_value_64"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>EKB Account</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""data_value_63"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>Fastab id</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""data_value_62"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>Message from scanning</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""data_value_61"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>Batch no</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""data_value_60"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>Batch prefix</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""data_value_59"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>City</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""data_value_58"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>Postal no</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""data_value_57"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>Address</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""data_value_56"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>Phone</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""data_value_55"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>VAT reg no</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""data_value_54"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>Factoring Bg/Pg</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""data_value_52"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>Bank CD</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""data_value_51"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>Swift</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""data_value_50"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>Country</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""data_value_49"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>Payments terms</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""data_value_48"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>Payment Code</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""data_value_45"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>skan id</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""data_value_44"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>7% mva</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""data_value_43"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>Grunnlag 7% mva</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""data_value_40"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>Rabatt ink mva</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""data_value_39"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>Gebyr</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""data_value_38"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>Rabatt eks mva</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""data_value_30"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>Pant</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""data_value_3"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>Bankkonto</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""data_value_28"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>25% mva</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""data_value_27"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>11% mva</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""data_value_26"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>Grunnlag 25% mva</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""data_value_25"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>Grunnlag 11% mva</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""data_value_24"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>Grunnlag 0% mva</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""data_value_23"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>Ref org faktura</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""data_value_17"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>Control Group</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""data_value_13"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>KID</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""data_value_100"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>Byer ContactPerson Name</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""customer_part_num_detail"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""currency"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>Valuta</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""contract_num"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>ICA ordrenr (Rek.ref)</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""buyer"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""name"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""address1"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""address2"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""address3"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""orgno"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""locno"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:choice>
    </xs:complexType>
  </xs:element>
  <xs:element name=""brutto_calc"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>Nettobelop NOK</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""brutto"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>Belop</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""bankacc"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>Bankkontonr</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""attrib_t6"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>Pakkseddelnr</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""attrib_t4"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>Avdeling</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""attrib_d3"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>Booking date</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""attrib_d2"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>Leveringsdato</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""attrib_d"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>Ordredato</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""attachment"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>Referanse til fil attachement (bilde)</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""address3"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>Adresse linje 3</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""address2"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>Adresse linje 2</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""address1"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>Adresse linje 1</xs:documentation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""acc_data"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""t10"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""t16"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""t1"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""t2"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""brutto"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""t8"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""brutto_calc"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""vat"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""t17"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""t3"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""t5"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""t40"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""vat_pros"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""t7"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""t43"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""t39"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""t18"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""t9"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""t19"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""t41"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""t20"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""t22"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""t23"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""t24"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""t34"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""t26"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""t27"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""t32"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""t33"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""t36"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""t37"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""t12"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""t31"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""t13"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""t4"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""t14"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""t38"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""t15"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""t6"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""t42"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:choice>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public Invoice() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "invoices";
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
