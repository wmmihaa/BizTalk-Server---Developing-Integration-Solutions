namespace ComplexMap {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://www.e2b.no/XMLSchema",@"Interchange")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Interchange"})]
    public sealed class E2B : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://www.e2b.no/XMLSchema"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://www.e2b.no/XMLSchema"" version=""1.0"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:schemaInfo BizTalkServerEditorTool_Version=""1.5"" root_reference=""Interchange"" displayroot_reference=""Interchange"" standard=""XML"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
      </b:schemaInfo>
    </xs:appinfo>
  </xs:annotation>
  <xs:annotation>
    <xs:documentation>Schema name: Interchange</xs:documentation>
  </xs:annotation>
  <xs:element name=""language"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""e2bTelecom_VoucherSummary"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" ref=""e2bTelecom_VoucherNo"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""e2bTelecom_UniqID"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""e2bTelecom_SecretNumber"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""e2bTelecom_Ref"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""e2bTelecom_Totals"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""e2bTelecom_Vat"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""e2bTelecom_PostingInformation"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""e2bTelecom_PostingDetails"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""e2bTelecom_Details"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""e2bTelecom_VoucherNo"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""e2bTelecom_Voucher"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" ref=""e2bTelecom_VoucherNo"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""e2bTelecom_UniqID"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""e2bTelecom_SecretNumber"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""e2bTelecom_Ref"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""e2bTelecom_Totals"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""e2bTelecom_Vat"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""e2bTelecom_PostingInformation"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""e2bTelecom_PostingDetails"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""e2bTelecom_Details"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""e2bTelecom_VolUnit"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""e2bTelecom_Vol"" type=""fixed.14.4"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""e2bTelecom_VatPercent"" type=""fixed.14.4"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""e2bTelecom_VatCode"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""e2bTelecom_VatBaseAmount"" type=""fixed.14.4"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""e2bTelecom_VatAmount"" type=""fixed.14.4"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""e2bTelecom_Vat"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" ref=""e2bTelecom_VatCode"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element ref=""e2bTelecom_VatPercent"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element ref=""e2bTelecom_VatBaseAmount"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""e2bTelecom_VatAmount"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""e2bTelecom_CorporateVatBaseAmount"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""e2bTelecom_CorporateVatAmount"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""e2bTelecom_PrivateVatBaseAmount"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""e2bTelecom_PrivateVatAmount"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""e2bTelecom_UniqID"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""e2bTelecom_Totals"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""e2bTelecom_VatBaseAmount"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""e2bTelecom_VatAmount"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""e2bTelecom_GrossAmount"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""e2bTelecom_CorporateVatBaseAmount"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""e2bTelecom_CorporateVatAmount"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""e2bTelecom_PrivateVatBaseAmount"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""e2bTelecom_PrivateVatAmount"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""e2bTelecom_PrivateGrossAmount"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""e2bTelecom_ToNumber"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""e2bTelecom_ToDest"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""e2bTelecom_ToCountry"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""e2bTelecom_Time"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""e2bTelecom_Text"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""e2bTelecom_Start"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""e2bTelecom_SecretNumber"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""e2bTelecom_Ref"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""e2bTelecom_Code"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""e2bTelecom_Text"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""e2bTelecom_Qty"" type=""fixed.14.4"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""e2bTelecom_PrivateVatBaseAmount"" type=""fixed.14.4"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""e2bTelecom_PrivateVatAmount"" type=""fixed.14.4"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""e2bTelecom_PrivateGrossAmount"" type=""fixed.14.4"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""e2bTelecom_PreviousBalanceForNextInvoice"" type=""fixed.14.4"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""e2bTelecom_PreviousBalance"" type=""fixed.14.4"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""e2bTelecom_PostingInformation"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""e2bTelecom_PostingDetails"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""e2bTelecom_Dimension"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element ref=""e2bTelecom_PostingCode"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""e2bTelecom_PostingCode"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""e2bTelecom_Name"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""e2bTelecom_Itemisation"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""e2bTelecom_Date"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element ref=""e2bTelecom_Time"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""e2bTelecom_FreeText"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""e2bTelecom_FromNumber"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""e2bTelecom_ToNumber"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""e2bTelecom_FromCountry"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""e2bTelecom_ToCountry"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""e2bTelecom_FromDest"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""e2bTelecom_ToDest"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""e2bTelecom_Dur"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""e2bTelecom_Vol"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""e2bTelecom_VolUnit"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element ref=""e2bTelecom_VatBaseAmount"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""e2bTelecom_VatAmount"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""e2bTelecom_GrossAmount"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""e2bTelecom_ID"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""e2bTelecom_GrossAmount"" type=""fixed.14.4"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""e2bTelecom_FromNumber"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""e2bTelecom_FromDest"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""e2bTelecom_FromCountry"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""e2bTelecom_FreeText"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""e2bTelecom_End"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""e2bTelecom_Dur"" type=""fixed.14.4"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""e2bTelecom_Dimension"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element xmlns:xp_0=""http://schemas.microsoft.com/BizTalk/2003"" xp_0:cyclecount=""7"" name=""e2bTelecom_Details"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" ref=""e2bTelecom_ID"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element ref=""e2bTelecom_Name"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""e2bTelecom_Start"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""e2bTelecom_End"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""e2bTelecom_Dur"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""e2bTelecom_Qty"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""e2bTelecom_Vol"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""e2bTelecom_VolUnit"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""e2bTelecom_VatPercent"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element ref=""e2bTelecom_VatBaseAmount"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""e2bTelecom_VatAmount"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""e2bTelecom_GrossAmount"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""e2bTelecom_Ref"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""e2bTelecom_PostingInformation"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""e2bTelecom_PostingDetails"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""e2bTelecom_Details"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""e2bTelecom_Itemisation"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""e2bTelecom_Date"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""e2bTelecom_CorporateVatBaseAmount"" type=""fixed.14.4"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""e2bTelecom_CorporateVatAmount"" type=""fixed.14.4"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""e2bTelecom_Code"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""e2bCard_Type"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""e2bCard_TransactionsInPeriod"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""e2bCard_TransactionReferences"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""e2bCard_BookingReference"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""e2bCard_CustomerReference"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""e2bCard_ProjectNumber"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""e2bCard_RequisitionNumber"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""e2bCard_EmployeeId"">
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
  <xs:element name=""e2bCard_TransactionDate"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""e2bCard_ToDate"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""e2bCard_Status"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""e2bCard_RequisitionNumber"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""e2bCard_ProjectNumber"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""e2bCard_PaymentsInPeriodDetails"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""e2bCard_Date"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""e2bCard_Type"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""e2bCard_Amount"">
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
  <xs:element name=""e2bCard_PaymentsInPeriod"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""e2bCard_OriginalAmount"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""e2bCard_OpenTransactionsDetails"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""e2bCard_InvoiceNumber"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""e2bCard_DueDate"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""e2bCard_Status"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""e2bCard_OriginalAmount"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""e2bCard_Amount"">
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
  <xs:element name=""e2bCard_OpenTransactions"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""e2bCard_NumberOfLines"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""e2bCard_MinimumPayment"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""e2bCard_InvoiceNumber"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""e2bCard_FromDate"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""e2bCard_EmployeeId"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""e2bCard_DueDate"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""e2bCard_Date"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""e2bCard_CustomerReference"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""e2bCard_Company"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""e2bCard_CardNumber"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""e2bCard_CardHolderName"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""e2bCard_BookingReference"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""e2bCard_Balance"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""e2bCard_AmountToPay"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""e2bCard_Amount"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""WebAddress"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""Version"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""VatTotalsInfo"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""VatPercent"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""VatBaseAmount"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""VatAmount"">
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
  <xs:element name=""VatTotalsAmount"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""VatPercent"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""VatInfo"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""VatPercent"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""VatBaseAmount"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""VatAmount"">
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
  <xs:element name=""VatId"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""VatBaseAmount"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""VatAmount"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""UnitPrice"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""UnitOfMeasure"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""UltimateCustomer"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""PartyId"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""LocationId"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Name"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""ContactInformation"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""StreetAddress"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""PostalAddress"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""ContactPerson"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""OrgNumber"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""VatId"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Department"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""AccountInformation"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""ProjectRef"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""ContractNumber"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Ref"">
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
  <xs:element name=""To"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""Time"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""Text"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""TestIndicator"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""TelecomHeader"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" ref=""e2bTelecom_PreviousBalance"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""e2bTelecom_PreviousBalanceForNextInvoice"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""e2bTelecom_Totals"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""e2bTelecom_Vat"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""e2bTelecom_VoucherSummary"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
      <xs:attribute name=""MessageVersion"" type=""xs:string"" use=""required"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
            </b:fieldInfo>
          </xs:appinfo>
        </xs:annotation>
      </xs:attribute>
    </xs:complexType>
  </xs:element>
  <xs:element name=""TelecomDetails"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""e2bTelecom_Voucher"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""TaxTreatment"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:simpleContent>
        <xs:extension base=""xs:string"">
          <xs:attribute name=""codetext"" type=""xs:string"">
            <xs:annotation>
              <xs:appinfo>
                <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                </b:fieldInfo>
              </xs:appinfo>
            </xs:annotation>
          </xs:attribute>
        </xs:extension>
      </xs:simpleContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""TaxTotalsInfo"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""TaxCode"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""TaxDescription"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""TaxAmount"">
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
  <xs:element name=""TaxTotalsAmount"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""TaxInfo"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Code"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Description"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Percent"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""BaseAmount"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Amount"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Quantity"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""UnitOfMeasure"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""RatePerUnit"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""VatInfo"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""CalculationSequence"">
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
  <xs:element name=""TaxDescription"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""TaxCode"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""TaxAmount"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""SwiftNumber"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""SuppliersProductId"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""SuppliersOrderNumber"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""SuppliersOrderInformation"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""UnitOfMeasure"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""UnitPrice"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""PriceType"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Quantity"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""LineNum"">
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
  <xs:element name=""Supplier"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
        <xs:element minOccurs=""0"" ref=""PartyId"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""LocationId"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Name"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""ContactInformation"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""StreetAddress"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""PostalAddress"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""ContactPerson"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""OrgNumber"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""VatId"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Department"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""AccountInformation"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""ProjectRef"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""ContractNumber"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Ref"">
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
  <xs:element name=""SubInvoice"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Header"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Details"">
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
  <xs:element name=""SubAddress"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""StreetAddress"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Address1"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Address2"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Address3"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""PostalCode"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""PostalDistrict"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""CountryCode"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""CountryName"">
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
  <xs:element name=""StartDate"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""SpecialCond"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""ShippedFrom"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""PartyId"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""LocationId"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Name"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""ContactInformation"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""StreetAddress"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""PostalAddress"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""ContactPerson"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""OrgNumber"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""VatId"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Department"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""AccountInformation"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""ProjectRef"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""ContractNumber"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Ref"">
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
  <xs:element name=""RoundingAmount"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""Ref"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Code"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Text"">
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
  <xs:element name=""Recipient"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""Address"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""SubAddress"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element ref=""AddressQualifier"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""ReceiptType"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:simpleContent>
        <xs:extension base=""xs:string"">
          <xs:attribute name=""code"" type=""xs:string"" use=""required"">
            <xs:annotation>
              <xs:appinfo>
                <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                </b:fieldInfo>
              </xs:appinfo>
            </xs:annotation>
          </xs:attribute>
        </xs:extension>
      </xs:simpleContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""ReceiptNotificationRequest"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""ReceiptNotificationReference"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""RatePerUnit"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""QuantityInvoiced"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""Quantity"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""ProjectRef"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""ProcessInstructions"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Instruction"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""PriceType"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:simpleContent>
        <xs:extension base=""xs:string"">
          <xs:attribute name=""codetext"" type=""xs:string"">
            <xs:annotation>
              <xs:appinfo>
                <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                </b:fieldInfo>
              </xs:appinfo>
            </xs:annotation>
          </xs:attribute>
        </xs:extension>
      </xs:simpleContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""PriceDenomination"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""PrePaidAmount"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""PostingInformation"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""PostingDetails"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Dimension"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""PostingCode"">
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
  <xs:element name=""PostingCode"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""PostalDistrict"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""PostalCode"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""PostalAddress"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Address1"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Address2"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Address3"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""PostalCode"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""PostalDistrict"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""CountryCode"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""CountryName"">
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
  <xs:element name=""PhoneNumber"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""Percent"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""PerQuantity"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""PaymentTerms"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""PaymentDiscount"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""DiscountPercent"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""DiscountDays"">
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
  <xs:element name=""Payment"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""DueDate"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Currency"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""KidNumber"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""PaymentTerms"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""PaymentDiscount"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""OverDuePercent"">
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
  <xs:element name=""PartyId"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:simpleContent>
        <xs:extension base=""xs:string"">
          <xs:attribute name=""schemeId"" type=""xs:string"" use=""optional"">
            <xs:annotation>
              <xs:appinfo>
                <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                </b:fieldInfo>
              </xs:appinfo>
            </xs:annotation>
          </xs:attribute>
          <xs:attribute name=""schemeName"" type=""xs:string"" use=""optional"">
            <xs:annotation>
              <xs:appinfo>
                <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                </b:fieldInfo>
              </xs:appinfo>
            </xs:annotation>
          </xs:attribute>
          <xs:attribute name=""schemeAgencyName"" type=""xs:string"" use=""optional"">
            <xs:annotation>
              <xs:appinfo>
                <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                </b:fieldInfo>
              </xs:appinfo>
            </xs:annotation>
          </xs:attribute>
        </xs:extension>
      </xs:simpleContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""OverDuePercent"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""Originator"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""Address"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""SubAddress"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element ref=""AddressQualifier"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""OrgNumber"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""OrderedBy"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""PartyId"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""LocationId"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Name"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""ContactInformation"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""StreetAddress"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""PostalAddress"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""ContactPerson"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""OrgNumber"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""VatId"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Department"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""AccountInformation"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""ProjectRef"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""ContractNumber"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Ref"">
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
  <xs:element name=""OrderInformation"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""UnitOfMeasure"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""UnitPrice"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""PriceType"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Quantity"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""LineNum"">
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
  <xs:element name=""Option"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""NumberOfMessages"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""NumberOfLines"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""NetAmount"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""Name"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""MessageVersion"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""MessageType"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""MessageTimestamp"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""MessageReference"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""MessageRecipient"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""Address"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""SubAddress"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element ref=""AddressQualifier"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""MessageOwner"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""MessageOriginator"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""Address"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""SubAddress"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element ref=""AddressQualifier"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""MessageNumber"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""MessageHeader"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""Version"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element ref=""DocumentType"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element ref=""MessageReference"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element ref=""MessageOwner"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element ref=""MessageType"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element ref=""MessageVersion"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element ref=""language"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""DocumentContent"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""LineOfBusiness"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""MessageOriginator"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""MessageRecipient"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Attachment"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""ReceiptNotificationRequest"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""ReceiptType"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""ReceiptNotificationReference"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""ProcessInstructions"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""FormatOptions"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""LocationId"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:simpleContent>
        <xs:extension base=""xs:string"">
          <xs:attribute name=""schemeId"" type=""xs:string"" use=""optional"">
            <xs:annotation>
              <xs:appinfo>
                <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                </b:fieldInfo>
              </xs:appinfo>
            </xs:annotation>
          </xs:attribute>
          <xs:attribute name=""schemeName"" type=""xs:string"" use=""optional"">
            <xs:annotation>
              <xs:appinfo>
                <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                </b:fieldInfo>
              </xs:appinfo>
            </xs:annotation>
          </xs:attribute>
          <xs:attribute name=""schemeAgencyName"" type=""xs:string"" use=""optional"">
            <xs:annotation>
              <xs:appinfo>
                <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                </b:fieldInfo>
              </xs:appinfo>
            </xs:annotation>
          </xs:attribute>
        </xs:extension>
      </xs:simpleContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""LineOfBusiness"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:simpleContent>
        <xs:extension base=""xs:string"">
          <xs:attribute name=""codetext"" type=""xs:string"" use=""optional"">
            <xs:annotation>
              <xs:appinfo>
                <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                </b:fieldInfo>
              </xs:appinfo>
            </xs:annotation>
          </xs:attribute>
        </xs:extension>
      </xs:simpleContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""LineNum"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""LineItemTotalsAmount"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""LineItemPreDiscountAmount"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""LineItemNum"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""LineItemGrossAmount"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""LineItemAmount"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""Licencee"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""PartyId"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""LocationId"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Name"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""ContactInformation"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""StreetAddress"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""PostalAddress"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""ContactPerson"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""OrgNumber"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""VatId"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Department"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""AccountInformation"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""ProjectRef"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""ContractNumber"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Ref"">
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
  <xs:element name=""Level"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""LastName"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""KidNumber"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""Invoicee"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""PartyId"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""LocationId"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Name"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""ContactInformation"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""StreetAddress"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""PostalAddress"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""ContactPerson"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""OrgNumber"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""VatId"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Department"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""AccountInformation"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""ProjectRef"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""ContractNumber"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Ref"">
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
  <xs:element name=""InvoiceType"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:simpleContent>
        <xs:extension base=""xs:string"">
          <xs:attribute name=""codetext"" type=""xs:string"">
            <xs:annotation>
              <xs:appinfo>
                <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                </b:fieldInfo>
              </xs:appinfo>
            </xs:annotation>
          </xs:attribute>
        </xs:extension>
      </xs:simpleContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""InvoiceTotals"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""LineItemTotalsAmount"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""DiscountTotalsAmount"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""ChargesTotalsAmount"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""TaxTotalsAmount"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""PrePaidAmount"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""CommissionAmount"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""GrossAmount"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""VatTotalsAmount"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""NetAmount"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""RoundingAmount"">
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
  <xs:element name=""InvoiceTax"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Code"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Description"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Percent"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""BaseAmount"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Amount"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Quantity"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""UnitOfMeasure"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""RatePerUnit"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""VatInfo"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""CalculationSequence"">
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
  <xs:element name=""InvoiceSummary"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""FreeText"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""InvoiceTotals"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""VatTotalsInfo"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""TaxTotalsInfo"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""DiscountTotals"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""ChargesTotals"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""ActualPayment"">
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
  <xs:element name=""InvoiceStatus"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:simpleContent>
        <xs:extension base=""xs:string"">
          <xs:attribute name=""codetext"" type=""xs:string"">
            <xs:annotation>
              <xs:appinfo>
                <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                </b:fieldInfo>
              </xs:appinfo>
            </xs:annotation>
          </xs:attribute>
        </xs:extension>
      </xs:simpleContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""InvoiceReferences"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""BuyersOrderNumber"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""BuyersOrderDate"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""BuyersProjectCode"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""InvoiceNumber"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""SuppliersOrderNumber"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""DeliveryTerms"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""DeliveryTermsCode"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""DeliveryTermsPlace"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""DeliveryNoteNum"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""DeliveryDate"">
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
  <xs:element name=""InvoiceNumber"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""InvoiceIssuer"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""PartyId"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""LocationId"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Name"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""ContactInformation"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""StreetAddress"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""PostalAddress"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""ContactPerson"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""OrgNumber"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""VatId"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Department"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""AccountInformation"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""ProjectRef"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""ContractNumber"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Ref"">
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
  <xs:element name=""InvoiceHeader"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
        <xs:element minOccurs=""0"" ref=""InvoiceType"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""InvoiceStatus"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""InvoiceNumber"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""InvoiceDate"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""TaxTreatment"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""DiscountTreatment"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""Supplier"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""InvoiceIssuer"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""Buyer"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""Invoicee"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""OrderedBy"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""DeliveryPart"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""UltimateCustomer"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""ShippedFrom"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""Factoring"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""InvoiceReferences"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""Payment"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Attachments"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Ref"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""FreeText"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""CardHeaderInformation"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""TelecomHeader"">
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
  <xs:element name=""InvoiceDiscountChargesAndTax"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""InvoiceDiscount"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""InvoiceCharges"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""InvoiceTax"">
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
  <xs:element name=""InvoiceDiscount"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Code"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Description"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Percent"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""BaseAmount"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Amount"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Quantity"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""UnitOfMeasure"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""RatePerUnit"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""VatInfo"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""CalculationSequence"">
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
  <xs:element name=""InvoiceDetails"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
        <xs:element maxOccurs=""unbounded"" ref=""BaseItemDetails"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""FreeText"">
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
  <xs:element name=""InvoiceDate"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""InvoiceContent"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""InvoiceCharges"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Code"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Description"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Percent"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""BaseAmount"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Amount"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Quantity"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""UnitOfMeasure"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""RatePerUnit"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""VatInfo"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""CalculationSequence"">
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
  <xs:element name=""Invoice"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
        <xs:element minOccurs=""0"" ref=""InvoiceContent"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""LineOfBusiness"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""MessageNumber"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""MessageTimestamp"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""NumberOfLines"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element ref=""InvoiceHeader"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element ref=""InvoiceDetails"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""InvoiceDiscountChargesAndTax"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""InvoiceSummary"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:choice>
      <xs:attribute name=""MessageVersion"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
            </b:fieldInfo>
          </xs:appinfo>
        </xs:annotation>
      </xs:attribute>
      <xs:attribute name=""MessageOwner"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
            </b:fieldInfo>
          </xs:appinfo>
        </xs:annotation>
      </xs:attribute>
      <xs:attribute name=""MessageType"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
            </b:fieldInfo>
          </xs:appinfo>
        </xs:annotation>
      </xs:attribute>
      <xs:attribute name=""language"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
            </b:fieldInfo>
          </xs:appinfo>
        </xs:annotation>
      </xs:attribute>
    </xs:complexType>
  </xs:element>
  <xs:element name=""InterchangeTime"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""InterchangeId"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""InterchangeHeader"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""Version"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element ref=""InterchangeId"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element ref=""InterchangeTime"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""Originator"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""Recipient"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""ReceiptNotificationRequest"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""ReceiptType"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""ReceiptNotificationReference"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""TestIndicator"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""ProcessInstructions"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""FormatOptions"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""Interchange"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
        <xs:element ref=""Envelope"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""InterchangeHeader"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""MessageHeader"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element maxOccurs=""unbounded"" ref=""Invoice"">
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
  <xs:element name=""Instruction"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""IbanNumber"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""Header"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""InvoiceType"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""InvoiceStatus"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""InvoiceNumber"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""InvoiceDate"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""TaxTreatment"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""DiscountTreatment"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Supplier"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""InvoiceIssuer"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Buyer"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Invoicee"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""OrderedBy"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""DeliveryPart"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""UltimateCustomer"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""ShippedFrom"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Factoring"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""InvoiceReferences"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Payment"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Attachments"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Ref"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""FreeText"">
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
  <xs:element name=""GrossAmount"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""Function"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""From"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""FreeText"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""FormatOptions"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Option"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""ForeignAmount"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""FirstName"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""FaxNumber"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""Factoring"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
        <xs:element minOccurs=""0"" ref=""PartyId"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""LocationId"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Name"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""ContactInformation"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""StreetAddress"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""PostalAddress"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""ContactPerson"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""OrgNumber"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""VatId"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Department"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""AccountInformation"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""ProjectRef"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""ContractNumber"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Ref"">
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
  <xs:element name=""ExchangeRate"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""ExchangeInformation"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Currency"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""ForeignAmount"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""ExchangeRate"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""ExchangeDate"">
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
  <xs:element name=""ExchangeDate"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""Envelope"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""InterchangeId"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""From"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""To"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Date"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Time"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""NumberOfMessages"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""TestIndicator"">
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
  <xs:element name=""EndDate"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""EmailAddress"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""Duration"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:simpleContent>
        <xs:extension base=""xs:string"">
          <xs:attribute name=""unitCode"" type=""xs:string"" use=""required"">
            <xs:annotation>
              <xs:appinfo>
                <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                </b:fieldInfo>
              </xs:appinfo>
            </xs:annotation>
          </xs:attribute>
        </xs:extension>
      </xs:simpleContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""DueDate"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""DocumentType"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""DocumentCode"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""DocumentDescriptiveName"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""DocumentDescriptiveName"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""DocumentContent"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""DocumentCode"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""DiscountTreatment"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:simpleContent>
        <xs:extension base=""xs:string"">
          <xs:attribute name=""codetext"" type=""xs:string"">
            <xs:annotation>
              <xs:appinfo>
                <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                </b:fieldInfo>
              </xs:appinfo>
            </xs:annotation>
          </xs:attribute>
        </xs:extension>
      </xs:simpleContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""DiscountTotalsAmount"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""DiscountTotals"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Code"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Description"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Percent"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""BaseAmount"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Amount"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Quantity"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""UnitOfMeasure"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""RatePerUnit"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""VatInfo"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""CalculationSequence"">
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
  <xs:element name=""DiscountPercent"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""DiscountDays"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""Discount"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Code"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Description"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Percent"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""BaseAmount"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Amount"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Quantity"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""UnitOfMeasure"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""RatePerUnit"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""VatInfo"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""CalculationSequence"">
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
  <xs:element name=""Dimension"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""Details"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""LineItemNum"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Level"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""SuppliersProductId"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Description"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""BuyersProductId"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""AdditionalProductId"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""UnitPrice"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""PriceType"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""PerQuantity"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""LineItemPreDiscountAmount"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""PrePaidAmount"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""CommissionAmount"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""LineItemAmount"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""LineItemGrossAmount"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""QuantityInvoiced"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""UnitOfMeasure"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""ExchangeInformation"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""OrderInformation"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""DeliveryInformation"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""SuppliersOrderInformation"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""VatInfo"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""TaxInfo"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Discount"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Charges"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Invoicee"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Licencee"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""StartDate"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""EndDate"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""SpecialCond"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""PostingInformation"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""PostingDetails"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Ref"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""FreeText"">
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
  <xs:element name=""Description"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""Department"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""DeliveryTermsPlace"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""DeliveryTermsCode"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""DeliveryTerms"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""DeliveryPart"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""PartyId"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""LocationId"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Name"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""ContactInformation"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""StreetAddress"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""PostalAddress"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""ContactPerson"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""OrgNumber"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""VatId"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Department"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""AccountInformation"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""ProjectRef"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""ContractNumber"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Ref"">
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
  <xs:element name=""DeliveryNoteNum"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""DeliveryInformation"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""UnitOfMeasure"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""UnitPrice"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""PriceType"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Quantity"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""LineNum"">
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
  <xs:element name=""DeliveryDate"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""Date"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""CustomContent"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""Currency"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""CountryName"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""CountryCode"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""CopyIndicator"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""ContractNumber"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""ContactPerson"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Name"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""FirstName"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""LastName"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""ContactInformation"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Function"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Department"">
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
  <xs:element name=""ContactInformation"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""PhoneNumber"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""FaxNumber"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""EmailAddress"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""WebAddress"">
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
  <xs:element name=""CommissionAmount"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""Code"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""ChargesTotalsAmount"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""ChargesTotals"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Code"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Description"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Percent"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""BaseAmount"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Amount"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Quantity"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""UnitOfMeasure"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""RatePerUnit"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""VatInfo"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""CalculationSequence"">
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
  <xs:element name=""Charges"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Code"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Description"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Percent"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""BaseAmount"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Amount"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Quantity"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""UnitOfMeasure"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""RatePerUnit"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""VatInfo"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""CalculationSequence"">
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
  <xs:element name=""CardHeaderInformation"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""e2bCard_CardNumber"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""e2bCard_Company"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""e2bCard_FromDate"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""e2bCard_ToDate"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""e2bCard_Balance"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""e2bCard_PaymentsInPeriod"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""e2bCard_PaymentsInPeriodDetails"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""e2bCard_TransactionsInPeriod"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""e2bCard_OpenTransactions"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""e2bCard_OpenTransactionsDetails"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""e2bCard_AmountToPay"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""e2bCard_MinimumPayment"">
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
  <xs:element name=""CardDetailsInformation"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""e2bCard_CardNumber"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""e2bCard_CardHolderName"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""e2bCard_TransactionDate"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""e2bCard_NumberOfLines"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""e2bCard_TransactionReferences"">
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
  <xs:element name=""CalculationSequence"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""BuyersProjectCode"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""BuyersProductId"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""BuyersOrderNumber"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""BuyersOrderDate"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""Buyer"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""PartyId"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""LocationId"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Name"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""ContactInformation"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""StreetAddress"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""PostalAddress"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""ContactPerson"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""OrgNumber"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""VatId"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Department"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""AccountInformation"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""ProjectRef"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""ContractNumber"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Ref"">
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
  <xs:element name=""BaseItemDetails"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
        <xs:element minOccurs=""0"" ref=""SubInvoice"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""TelecomDetails"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""LineItemNum"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Level"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""SuppliersProductId"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Description"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""BuyersProductId"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""AdditionalProductId"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""UnitPrice"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""PriceDenomination"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""PriceType"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""PerQuantity"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""LineItemPreDiscountAmount"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""PrePaidAmount"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""CommissionAmount"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""LineItemAmount"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""LineItemGrossAmount"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""QuantityInvoiced"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""UnitOfMeasure"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""ExchangeInformation"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""OrderInformation"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""DeliveryInformation"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""SuppliersOrderInformation"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""VatInfo"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""TaxInfo"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""Discount"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""Charges"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""Invoicee"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""Licencee"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""Duration"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""StartDate"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""EndDate"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""SpecialCond"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""PostingInformation"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""PostingDetails"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Ref"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""FreeText"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""CardDetailsInformation"">
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
  <xs:element name=""BaseAmount"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""Attachments"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""AttachmentType"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""AttachmentNumber"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""AttachmentName"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""AttachmentLocation"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""Attachment"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" ref=""AttachmentNumber"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""CopyIndicator"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""AttachmentType"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""AttachmentName"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""AttachmentLocation"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""ProcessInstructions"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""FormatOptions"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:recordInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""CustomContent"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
      <xs:attribute name=""type"" type=""xs:string"" use=""required"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
            </b:fieldInfo>
          </xs:appinfo>
        </xs:annotation>
      </xs:attribute>
    </xs:complexType>
  </xs:element>
  <xs:element name=""Amount"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""AddressQualifier"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""Address3"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""Address2"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""Address1"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""Address"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:simpleContent>
        <xs:extension base=""xs:string"">
          <xs:attribute name=""schemeId"" type=""xs:string"" use=""optional"">
            <xs:annotation>
              <xs:appinfo>
                <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                </b:fieldInfo>
              </xs:appinfo>
            </xs:annotation>
          </xs:attribute>
          <xs:attribute name=""schemeName"" type=""xs:string"" use=""optional"">
            <xs:annotation>
              <xs:appinfo>
                <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                </b:fieldInfo>
              </xs:appinfo>
            </xs:annotation>
          </xs:attribute>
          <xs:attribute name=""schemeAgencyName"" type=""xs:string"" use=""optional"">
            <xs:annotation>
              <xs:appinfo>
                <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                </b:fieldInfo>
              </xs:appinfo>
            </xs:annotation>
          </xs:attribute>
        </xs:extension>
      </xs:simpleContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""AdditionalProductId"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Code"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""Text"">
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
  <xs:element name=""ActualPayment"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:simpleContent>
        <xs:extension base=""xs:string"">
          <xs:attribute name=""decimalValue"" type=""xs:string"">
            <xs:annotation>
              <xs:appinfo>
                <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                </b:fieldInfo>
              </xs:appinfo>
            </xs:annotation>
          </xs:attribute>
          <xs:attribute name=""integerValue"" type=""xs:string"">
            <xs:annotation>
              <xs:appinfo>
                <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                </b:fieldInfo>
              </xs:appinfo>
            </xs:annotation>
          </xs:attribute>
          <xs:attribute name=""modulus"" type=""xs:string"">
            <xs:annotation>
              <xs:appinfo>
                <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                </b:fieldInfo>
              </xs:appinfo>
            </xs:annotation>
          </xs:attribute>
          <xs:attribute name=""Currency"" type=""xs:string"">
            <xs:annotation>
              <xs:appinfo>
                <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
                </b:fieldInfo>
              </xs:appinfo>
            </xs:annotation>
          </xs:attribute>
        </xs:extension>
      </xs:simpleContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""AccountNumber"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:fieldInfo>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""AccountInformation"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
        </b:recordInfo>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""AccountNumber"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""IbanNumber"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"">
              </b:fieldInfo>
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" ref=""SwiftNumber"">
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
  <xs:simpleType name=""fixed.14.4"">
    <xs:restriction base=""xs:decimal"">
      <xs:fractionDigits value=""4"" />
      <xs:minInclusive value=""-922337203685477.5808"" />
      <xs:maxInclusive value=""922337203685477.5807"" />
    </xs:restriction>
  </xs:simpleType>
</xs:schema>";
        
        public E2B() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Interchange";
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
