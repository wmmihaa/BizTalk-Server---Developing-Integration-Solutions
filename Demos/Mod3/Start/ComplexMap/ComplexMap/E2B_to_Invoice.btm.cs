namespace ComplexMap {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ComplexMap.E2B", typeof(global::ComplexMap.E2B))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ComplexMap.Invoice", typeof(global::ComplexMap.Invoice))]
    public sealed class E2B_to_Invoice : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:s0=""http://www.e2b.no/XMLSchema"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Interchange"" />
  </xsl:template>
  <xsl:template match=""/s0:Interchange"">
    <invoices>
      <xsl:for-each select=""s0:Invoice"">
        <xsl:variable name=""var:v17"" select=""userCSharp:DateCurrentDateTime()"" />
        <xsl:variable name=""var:v18"" select=""userCSharp:StringConcat(string(s0:InvoiceHeader/s0:InvoiceReferences/s0:BuyersOrderNumber/text()) , &quot; &quot; , string(s0:InvoiceHeader/s0:InvoiceReferences/s0:SuppliersOrderNumber/text()))"" />
        <xsl:variable name=""var:v19"" select=""userCSharp:StringTrimLeft(string($var:v18))"" />
        <xsl:variable name=""var:v20"" select=""userCSharp:StringTrimRight(string($var:v19))"" />
        <xsl:variable name=""var:v21"" select=""userCSharp:LogicalNe(string($var:v20) , &quot;&quot;)"" />
        <xsl:variable name=""var:v23"" select=""userCSharp:StringUpperCase(string(s0:InvoiceHeader/s0:Buyer/s0:Ref/s0:Code/text()))"" />
        <xsl:variable name=""var:v24"" select=""userCSharp:LogicalEq(string($var:v23) , &quot;ICAOrdreNr&quot;)"" />
        <xsl:variable name=""var:v26"" select=""userCSharp:LogicalEq(string(s0:InvoiceHeader/s0:Ref/s0:Code/text()) , &quot;FRAF&quot;)"" />
        <invoice>
          <messagetype>
            <xsl:text>Basware Invoice</xsl:text>
          </messagetype>
          <xsl:for-each select=""s0:InvoiceSummary"">
            <xsl:for-each select=""s0:InvoiceTotals"">
              <xsl:for-each select=""s0:NetAmount"">
                <xsl:variable name=""var:v1"" select=""userCSharp:InitCumulativeSum(0)"" />
                <xsl:for-each select=""../../../s0:InvoiceDetails/s0:BaseItemDetails/s0:LineItemAmount"">
                  <xsl:variable name=""var:v2"" select=""userCSharp:ReplaceDot1(string(./text()))"" />
                  <xsl:variable name=""var:v3"" select=""userCSharp:AddToCumulativeSum(0,string($var:v2),&quot;3&quot;)"" />
                </xsl:for-each>
                <xsl:variable name=""var:v4"" select=""userCSharp:GetCumulativeSum(0)"" />
                <xsl:variable name=""var:v5"" select=""string(./text())"" />
                <xsl:variable name=""var:v6"" select=""userCSharp:ReplaceDot2($var:v5)"" />
                <xsl:variable name=""var:v7"" select=""userCSharp:ReplaceDot11(string(../s0:DiscountTotalsAmount/text()))"" />
                <xsl:variable name=""var:v8"" select=""userCSharp:ReplaceDot12(string(../s0:ChargesTotalsAmount/text()))"" />
                <xsl:variable name=""var:v9"" select=""userCSharp:CheckTotal(string($var:v4) , string($var:v6) , string($var:v7) , string($var:v8))"" />
                <xsl:variable name=""var:v10"" select=""userCSharp:ReplaceDot7($var:v5)"" />
                <xsl:variable name=""var:v11"" select=""userCSharp:ReplaceDot8(string(../s0:VatTotalsAmount/text()))"" />
                <xsl:variable name=""var:v12"" select=""userCSharp:ReplaceDot10(string(../s0:RoundingAmount/text()))"" />
                <xsl:variable name=""var:v13"" select=""userCSharp:CalcVATTotal(string($var:v10) , string($var:v11) , string($var:v12))"" />
                <xsl:variable name=""var:v14"" select=""userCSharp:ReplaceDot9(string(../s0:GrossAmount/text()))"" />
                <xsl:variable name=""var:v15"" select=""userCSharp:CheckVATTotal(string($var:v13) , string($var:v14))"" />
                <xsl:variable name=""var:v16"" select=""userCSharp:MyFunction99(string($var:v9) , string($var:v15))"" />
                <messageversion>
                  <xsl:value-of select=""$var:v16"" />
                </messageversion>
              </xsl:for-each>
            </xsl:for-each>
          </xsl:for-each>
          <messagetimestamp>
            <xsl:value-of select=""$var:v17"" />
          </messagetimestamp>
          <docs>
            <xsl:if test=""s0:InvoiceHeader/s0:InvoiceType"">
              <invoicetype>
                <xsl:value-of select=""s0:InvoiceHeader/s0:InvoiceType/text()"" />
              </invoicetype>
            </xsl:if>
            <xsl:if test=""s0:InvoiceHeader/s0:InvoiceNumber"">
              <invoice_num>
                <xsl:value-of select=""s0:InvoiceHeader/s0:InvoiceNumber/text()"" />
              </invoice_num>
            </xsl:if>
            <xsl:if test=""s0:InvoiceHeader/s0:InvoiceDate"">
              <invoice_date>
                <xsl:value-of select=""s0:InvoiceHeader/s0:InvoiceDate/text()"" />
              </invoice_date>
            </xsl:if>
            <xsl:if test=""s0:InvoiceHeader/s0:Payment/s0:DueDate"">
              <invoice_last_date>
                <xsl:value-of select=""s0:InvoiceHeader/s0:Payment/s0:DueDate/text()"" />
              </invoice_last_date>
            </xsl:if>
            <xsl:if test=""s0:InvoiceSummary/s0:InvoiceTotals/s0:GrossAmount"">
              <invoice_sum>
                <xsl:value-of select=""s0:InvoiceSummary/s0:InvoiceTotals/s0:GrossAmount/text()"" />
              </invoice_sum>
            </xsl:if>
            <xsl:if test=""s0:InvoiceSummary/s0:InvoiceTotals/s0:GrossAmount"">
              <invoice_sum_calc>
                <xsl:value-of select=""s0:InvoiceSummary/s0:InvoiceTotals/s0:GrossAmount/text()"" />
              </invoice_sum_calc>
            </xsl:if>
            <xsl:if test=""s0:InvoiceHeader/s0:Payment/s0:Currency"">
              <currency>
                <xsl:value-of select=""s0:InvoiceHeader/s0:Payment/s0:Currency/text()"" />
              </currency>
            </xsl:if>
            <xsl:if test=""string($var:v21)='true'"">
              <xsl:variable name=""var:v22"" select=""string($var:v20)"" />
              <order_num>
                <xsl:value-of select=""$var:v22"" />
              </order_num>
            </xsl:if>
            <xsl:if test=""s0:InvoiceHeader/s0:InvoiceReferences/s0:DeliveryNoteNum"">
              <attrib_t6>
                <xsl:value-of select=""s0:InvoiceHeader/s0:InvoiceReferences/s0:DeliveryNoteNum/text()"" />
              </attrib_t6>
            </xsl:if>
            <xsl:if test=""s0:InvoiceHeader/s0:Buyer/s0:Department"">
              <attrib_t4>
                <xsl:value-of select=""s0:InvoiceHeader/s0:Buyer/s0:Department/text()"" />
              </attrib_t4>
            </xsl:if>
            <xsl:if test=""string($var:v24)='true'"">
              <xsl:variable name=""var:v25"" select=""s0:InvoiceHeader/s0:Buyer/s0:Ref/s0:Text/text()"" />
              <contract_num>
                <xsl:value-of select=""$var:v25"" />
              </contract_num>
            </xsl:if>
            <xsl:if test=""string($var:v26)='true'"">
              <xsl:variable name=""var:v27"" select=""s0:InvoiceHeader/s0:Ref/s0:Text/text()"" />
              <invoice_type>
                <xsl:value-of select=""$var:v27"" />
              </invoice_type>
            </xsl:if>
            <xsl:if test=""s0:InvoiceHeader/s0:InvoiceReferences/s0:DeliveryDate"">
              <attrib_d2>
                <xsl:value-of select=""s0:InvoiceHeader/s0:InvoiceReferences/s0:DeliveryDate/text()"" />
              </attrib_d2>
            </xsl:if>
            <xsl:if test=""s0:InvoiceSummary/s0:InvoiceTotals/s0:VatTotalsAmount"">
              <vat_sum>
                <xsl:value-of select=""s0:InvoiceSummary/s0:InvoiceTotals/s0:VatTotalsAmount/text()"" />
              </vat_sum>
            </xsl:if>
          </docs>
          <doc_data>
            <xsl:for-each select=""s0:InvoiceHeader"">
              <xsl:for-each select=""s0:Supplier"">
                <xsl:for-each select=""s0:AccountInformation"">
                  <xsl:for-each select=""s0:AccountNumber"">
                    <data_value_3>
                      <xsl:value-of select=""./text()"" />
                    </data_value_3>
                  </xsl:for-each>
                </xsl:for-each>
              </xsl:for-each>
            </xsl:for-each>
            <xsl:for-each select=""s0:InvoiceHeader"">
              <xsl:for-each select=""s0:Payment"">
                <xsl:for-each select=""s0:KidNumber"">
                  <data_value_13>
                    <xsl:value-of select=""./text()"" />
                  </data_value_13>
                </xsl:for-each>
              </xsl:for-each>
            </xsl:for-each>
            <xsl:for-each select=""s0:InvoiceHeader"">
              <xsl:for-each select=""s0:Buyer"">
                <xsl:for-each select=""s0:Ref"">
                  <xsl:for-each select=""s0:Code"">
                    <xsl:variable name=""var:v28"" select=""string(./text())"" />
                    <xsl:variable name=""var:v29"" select=""userCSharp:StringUpperCase($var:v28)"" />
                    <xsl:variable name=""var:v30"" select=""userCSharp:LogicalEq(&quot;ICA REF&quot; , string($var:v29))"" />
                    <xsl:if test=""string($var:v30)='true'"">
                      <xsl:variable name=""var:v31"" select=""../s0:Text/text()"" />
                      <data_value_17>
                        <xsl:value-of select=""$var:v31"" />
                      </data_value_17>
                    </xsl:if>
                  </xsl:for-each>
                </xsl:for-each>
              </xsl:for-each>
            </xsl:for-each>
            <xsl:for-each select=""s0:InvoiceHeader"">
              <xsl:for-each select=""s0:InvoiceReferences"">
                <xsl:for-each select=""s0:InvoiceNumber"">
                  <data_value_23>
                    <xsl:value-of select=""./text()"" />
                  </data_value_23>
                </xsl:for-each>
              </xsl:for-each>
            </xsl:for-each>
            <xsl:for-each select=""s0:InvoiceSummary"">
              <xsl:for-each select=""s0:VatTotalsInfo"">
                <xsl:for-each select=""s0:VatPercent"">
                  <xsl:variable name=""var:v32"" select=""string(./text())"" />
                  <xsl:variable name=""var:v33"" select=""userCSharp:setVatPercent_0($var:v32)"" />
                  <xsl:if test=""string($var:v33)='true'"">
                    <xsl:variable name=""var:v34"" select=""../s0:VatBaseAmount/text()"" />
                    <data_value_24>
                      <xsl:value-of select=""$var:v34"" />
                    </data_value_24>
                  </xsl:if>
                </xsl:for-each>
              </xsl:for-each>
            </xsl:for-each>
            <xsl:for-each select=""s0:InvoiceSummary"">
              <xsl:for-each select=""s0:VatTotalsInfo"">
                <xsl:for-each select=""s0:VatPercent"">
                  <xsl:variable name=""var:v35"" select=""string(./text())"" />
                  <xsl:variable name=""var:v36"" select=""userCSharp:setVatPercent_13($var:v35)"" />
                  <xsl:if test=""string($var:v36)='true'"">
                    <xsl:variable name=""var:v37"" select=""../s0:VatBaseAmount/text()"" />
                    <data_value_25>
                      <xsl:value-of select=""$var:v37"" />
                    </data_value_25>
                  </xsl:if>
                  <xsl:variable name=""var:v38"" select=""userCSharp:setVatPercent_14($var:v35)"" />
                  <xsl:if test=""string($var:v38)='true'"">
                    <xsl:variable name=""var:v39"" select=""../s0:VatBaseAmount/text()"" />
                    <data_value_25>
                      <xsl:value-of select=""$var:v39"" />
                    </data_value_25>
                  </xsl:if>
                </xsl:for-each>
              </xsl:for-each>
            </xsl:for-each>
            <xsl:for-each select=""s0:InvoiceSummary"">
              <xsl:for-each select=""s0:VatTotalsInfo"">
                <xsl:for-each select=""s0:VatPercent"">
                  <xsl:variable name=""var:v40"" select=""string(./text())"" />
                  <xsl:variable name=""var:v41"" select=""userCSharp:setVatPercent_25($var:v40)"" />
                  <xsl:if test=""string($var:v41)='true'"">
                    <xsl:variable name=""var:v42"" select=""../s0:VatBaseAmount/text()"" />
                    <data_value_26>
                      <xsl:value-of select=""$var:v42"" />
                    </data_value_26>
                  </xsl:if>
                </xsl:for-each>
              </xsl:for-each>
            </xsl:for-each>
            <xsl:for-each select=""s0:InvoiceSummary"">
              <xsl:for-each select=""s0:VatTotalsInfo"">
                <xsl:for-each select=""s0:VatPercent"">
                  <xsl:variable name=""var:v43"" select=""string(./text())"" />
                  <xsl:variable name=""var:v44"" select=""userCSharp:setVatPercent_25($var:v43)"" />
                  <xsl:if test=""string($var:v44)='true'"">
                    <xsl:variable name=""var:v45"" select=""../s0:VatAmount/text()"" />
                    <data_value_28>
                      <xsl:value-of select=""$var:v45"" />
                    </data_value_28>
                  </xsl:if>
                </xsl:for-each>
              </xsl:for-each>
            </xsl:for-each>
            <xsl:for-each select=""s0:InvoiceSummary"">
              <xsl:for-each select=""s0:InvoiceTotals"">
                <xsl:for-each select=""s0:DiscountTotalsAmount"">
                  <data_value_40>
                    <xsl:value-of select=""./text()"" />
                  </data_value_40>
                </xsl:for-each>
              </xsl:for-each>
            </xsl:for-each>
            <xsl:for-each select=""s0:InvoiceSummary"">
              <xsl:for-each select=""s0:VatTotalsInfo"">
                <xsl:for-each select=""s0:VatPercent"">
                  <xsl:variable name=""var:v46"" select=""string(./text())"" />
                  <xsl:variable name=""var:v47"" select=""userCSharp:setVatPercent_8($var:v46)"" />
                  <xsl:if test=""string($var:v47)='true'"">
                    <xsl:variable name=""var:v48"" select=""../s0:VatBaseAmount/text()"" />
                    <data_value_43>
                      <xsl:value-of select=""$var:v48"" />
                    </data_value_43>
                  </xsl:if>
                </xsl:for-each>
              </xsl:for-each>
            </xsl:for-each>
            <xsl:for-each select=""s0:InvoiceSummary"">
              <xsl:for-each select=""s0:VatTotalsInfo"">
                <xsl:for-each select=""s0:VatPercent"">
                  <xsl:variable name=""var:v49"" select=""string(./text())"" />
                  <xsl:variable name=""var:v50"" select=""userCSharp:setVatPercent_8($var:v49)"" />
                  <xsl:if test=""string($var:v50)='true'"">
                    <xsl:variable name=""var:v51"" select=""../s0:VatAmount/text()"" />
                    <data_value_44>
                      <xsl:value-of select=""$var:v51"" />
                    </data_value_44>
                  </xsl:if>
                </xsl:for-each>
              </xsl:for-each>
            </xsl:for-each>
            <data_value_45>
              <xsl:text>EDI</xsl:text>
            </data_value_45>
            <xsl:for-each select=""s0:InvoiceHeader"">
              <xsl:for-each select=""s0:Payment"">
                <xsl:for-each select=""s0:PaymentTerms"">
                  <data_value_49>
                    <xsl:value-of select=""./text()"" />
                  </data_value_49>
                </xsl:for-each>
              </xsl:for-each>
            </xsl:for-each>
            <xsl:for-each select=""s0:InvoiceHeader"">
              <xsl:for-each select=""s0:Supplier"">
                <xsl:for-each select=""s0:PostalAddress"">
                  <xsl:for-each select=""s0:CountryCode"">
                    <data_value_50>
                      <xsl:value-of select=""./text()"" />
                    </data_value_50>
                  </xsl:for-each>
                </xsl:for-each>
              </xsl:for-each>
            </xsl:for-each>
            <xsl:for-each select=""s0:InvoiceHeader"">
              <xsl:for-each select=""s0:Supplier"">
                <xsl:for-each select=""s0:VatId"">
                  <data_value_55>
                    <xsl:value-of select=""./text()"" />
                  </data_value_55>
                </xsl:for-each>
              </xsl:for-each>
            </xsl:for-each>
            <xsl:for-each select=""s0:InvoiceHeader"">
              <xsl:for-each select=""s0:Supplier"">
                <xsl:for-each select=""s0:ContactInformation"">
                  <xsl:for-each select=""s0:PhoneNumber"">
                    <data_value_56>
                      <xsl:value-of select=""./text()"" />
                    </data_value_56>
                  </xsl:for-each>
                </xsl:for-each>
              </xsl:for-each>
            </xsl:for-each>
            <xsl:for-each select=""s0:InvoiceHeader"">
              <xsl:for-each select=""s0:Supplier"">
                <xsl:for-each select=""s0:PostalAddress"">
                  <xsl:for-each select=""s0:Address1"">
                    <data_value_57>
                      <xsl:value-of select=""./text()"" />
                    </data_value_57>
                  </xsl:for-each>
                </xsl:for-each>
              </xsl:for-each>
            </xsl:for-each>
            <xsl:for-each select=""s0:InvoiceHeader"">
              <xsl:for-each select=""s0:Supplier"">
                <xsl:for-each select=""s0:PostalAddress"">
                  <xsl:for-each select=""s0:PostalCode"">
                    <data_value_58>
                      <xsl:value-of select=""./text()"" />
                    </data_value_58>
                  </xsl:for-each>
                </xsl:for-each>
              </xsl:for-each>
            </xsl:for-each>
            <xsl:for-each select=""s0:InvoiceHeader"">
              <xsl:for-each select=""s0:Supplier"">
                <xsl:for-each select=""s0:PostalAddress"">
                  <xsl:for-each select=""s0:PostalDistrict"">
                    <data_value_59>
                      <xsl:value-of select=""./text()"" />
                    </data_value_59>
                  </xsl:for-each>
                </xsl:for-each>
              </xsl:for-each>
            </xsl:for-each>
            <xsl:for-each select=""s0:InvoiceHeader"">
              <xsl:for-each select=""s0:Supplier"">
                <xsl:for-each select=""s0:AccountInformation"">
                  <xsl:for-each select=""s0:AccountNumber"">
                    <data_value_66>
                      <xsl:value-of select=""./text()"" />
                    </data_value_66>
                  </xsl:for-each>
                </xsl:for-each>
              </xsl:for-each>
            </xsl:for-each>
            <xsl:for-each select=""s0:InvoiceHeader/s0:Buyer/s0:ContactPerson"">
              <xsl:variable name=""var:v52"" select=""userCSharp:InitCumulativeConcat(0)"" />
              <xsl:for-each select=""s0:Name"">
                <xsl:variable name=""var:v53"" select=""string(./text())"" />
                <xsl:variable name=""var:v54"" select=""userCSharp:StringConcat($var:v53 , &quot; &quot;)"" />
                <xsl:variable name=""var:v55"" select=""userCSharp:AddToCumulativeConcat(0,string($var:v54),&quot;1&quot;)"" />
              </xsl:for-each>
              <xsl:variable name=""var:v56"" select=""userCSharp:GetCumulativeConcat(0)"" />
              <xsl:variable name=""var:v57"" select=""userCSharp:StringTrimLeft(string($var:v56))"" />
              <xsl:variable name=""var:v58"" select=""userCSharp:StringTrimRight(string($var:v57))"" />
              <xsl:variable name=""var:v59"" select=""userCSharp:LogicalNe(string($var:v58) , &quot;&quot;)"" />
              <xsl:if test=""string($var:v59)='true'"">
                <xsl:variable name=""var:v60"" select=""string($var:v58)"" />
                <data_value_100>
                  <xsl:value-of select=""$var:v60"" />
                </data_value_100>
              </xsl:if>
            </xsl:for-each>
          </doc_data>
          <xsl:for-each select=""s0:InvoiceDetails"">
            <xsl:for-each select=""s0:BaseItemDetails"">
              <ioc_invoice_detail>
                <xsl:if test=""s0:LineItemNum"">
                  <line_item_number>
                    <xsl:value-of select=""s0:LineItemNum/text()"" />
                  </line_item_number>
                </xsl:if>
                <xsl:if test=""s0:SuppliersProductId"">
                  <part_num_detail>
                    <xsl:value-of select=""s0:SuppliersProductId/text()"" />
                  </part_num_detail>
                </xsl:if>
                <xsl:if test=""s0:Description"">
                  <linedescription>
                    <xsl:value-of select=""s0:Description/text()"" />
                  </linedescription>
                </xsl:if>
                <xsl:if test=""s0:OrderInformation/s0:Quantity"">
                  <ordered_qty>
                    <xsl:value-of select=""s0:OrderInformation/s0:Quantity/text()"" />
                  </ordered_qty>
                </xsl:if>
                <xsl:if test=""s0:QuantityInvoiced"">
                  <delievered_qty>
                    <xsl:value-of select=""s0:QuantityInvoiced/text()"" />
                  </delievered_qty>
                </xsl:if>
                <xsl:if test=""s0:UnitPrice"">
                  <unit_price>
                    <xsl:value-of select=""s0:UnitPrice/text()"" />
                  </unit_price>
                </xsl:if>
                <xsl:if test=""s0:LineItemAmount"">
                  <gross_lineitem_subtotal>
                    <xsl:value-of select=""s0:LineItemAmount/text()"" />
                  </gross_lineitem_subtotal>
                </xsl:if>
                <xsl:if test=""s0:VatInfo/s0:VatPercent"">
                  <tax_percent>
                    <xsl:value-of select=""s0:VatInfo/s0:VatPercent/text()"" />
                  </tax_percent>
                </xsl:if>
                <xsl:if test=""s0:Discount/s0:Percent"">
                  <supplier_discrate>
                    <xsl:value-of select=""s0:Discount/s0:Percent/text()"" />
                  </supplier_discrate>
                </xsl:if>
              </ioc_invoice_detail>
            </xsl:for-each>
          </xsl:for-each>
          <xsl:for-each select=""s0:InvoiceDetails"">
            <xsl:for-each select=""s0:BaseItemDetails"">
              <xsl:variable name=""var:v61"" select=""userCSharp:LogicalExistence(boolean(s0:PostingDetails))"" />
              <xsl:if test=""$var:v61"">
                <acc_data>
                  <xsl:for-each select=""s0:PostingDetails"">
                    <xsl:for-each select=""s0:Dimension"">
                      <xsl:variable name=""var:v62"" select=""string(./text())"" />
                      <xsl:variable name=""var:v63"" select=""userCSharp:StringUpperCase($var:v62)"" />
                      <xsl:variable name=""var:v64"" select=""userCSharp:postKonto(string($var:v63))"" />
                      <xsl:variable name=""var:v65"" select=""userCSharp:LogicalEq(string($var:v64) , &quot;KONTO&quot;)"" />
                      <xsl:if test=""string($var:v65)='true'"">
                        <xsl:variable name=""var:v66"" select=""../s0:PostingCode/text()"" />
                        <t10>
                          <xsl:value-of select=""$var:v66"" />
                        </t10>
                      </xsl:if>
                    </xsl:for-each>
                  </xsl:for-each>
                  <xsl:for-each select=""s0:PostingDetails"">
                    <xsl:for-each select=""s0:Dimension"">
                      <xsl:variable name=""var:v67"" select=""string(./text())"" />
                      <xsl:variable name=""var:v68"" select=""userCSharp:StringUpperCase($var:v67)"" />
                      <xsl:variable name=""var:v69"" select=""userCSharp:postAvd(string($var:v68))"" />
                      <xsl:variable name=""var:v70"" select=""userCSharp:LogicalEq(string($var:v69) , &quot;AVDELING&quot;)"" />
                      <xsl:if test=""string($var:v70)='true'"">
                        <xsl:variable name=""var:v71"" select=""../s0:PostingCode/text()"" />
                        <t1>
                          <xsl:value-of select=""$var:v71"" />
                        </t1>
                      </xsl:if>
                    </xsl:for-each>
                  </xsl:for-each>
                  <xsl:for-each select=""s0:PostingDetails"">
                    <xsl:for-each select=""s0:Dimension"">
                      <xsl:variable name=""var:v72"" select=""string(./text())"" />
                      <xsl:variable name=""var:v73"" select=""userCSharp:StringUpperCase($var:v72)"" />
                      <xsl:variable name=""var:v74"" select=""userCSharp:LogicalEq(string($var:v73) , &quot;BAERER&quot;)"" />
                      <xsl:if test=""string($var:v74)='true'"">
                        <xsl:variable name=""var:v75"" select=""../s0:PostingCode/text()"" />
                        <t2>
                          <xsl:value-of select=""$var:v75"" />
                        </t2>
                      </xsl:if>
                    </xsl:for-each>
                  </xsl:for-each>
                  <xsl:for-each select=""s0:PostingDetails"">
                    <xsl:for-each select=""s0:Dimension"">
                      <xsl:variable name=""var:v76"" select=""string(./text())"" />
                      <xsl:variable name=""var:v77"" select=""userCSharp:StringUpperCase($var:v76)"" />
                      <xsl:variable name=""var:v78"" select=""userCSharp:LogicalEq(string($var:v77) , &quot;BRUTTOBELOP&quot;)"" />
                      <xsl:if test=""string($var:v78)='true'"">
                        <xsl:variable name=""var:v79"" select=""../s0:PostingCode/text()"" />
                        <brutto>
                          <xsl:value-of select=""$var:v79"" />
                        </brutto>
                      </xsl:if>
                    </xsl:for-each>
                  </xsl:for-each>
                  <xsl:for-each select=""s0:PostingDetails"">
                    <xsl:for-each select=""s0:Dimension"">
                      <xsl:variable name=""var:v80"" select=""string(./text())"" />
                      <xsl:variable name=""var:v81"" select=""userCSharp:StringUpperCase($var:v80)"" />
                      <xsl:variable name=""var:v82"" select=""userCSharp:LogicalEq(string($var:v81) , &quot;MVAKODE&quot;)"" />
                      <xsl:if test=""string($var:v82)='true'"">
                        <xsl:variable name=""var:v83"" select=""../s0:PostingCode/text()"" />
                        <t8>
                          <xsl:value-of select=""$var:v83"" />
                        </t8>
                      </xsl:if>
                    </xsl:for-each>
                  </xsl:for-each>
                  <xsl:for-each select=""s0:PostingDetails"">
                    <xsl:for-each select=""s0:Dimension"">
                      <xsl:variable name=""var:v84"" select=""string(./text())"" />
                      <xsl:variable name=""var:v85"" select=""userCSharp:StringUpperCase($var:v84)"" />
                      <xsl:variable name=""var:v86"" select=""userCSharp:LogicalEq(string($var:v85) , &quot;NETTOBELOP&quot;)"" />
                      <xsl:if test=""string($var:v86)='true'"">
                        <xsl:variable name=""var:v87"" select=""../s0:PostingCode/text()"" />
                        <brutto_calc>
                          <xsl:value-of select=""$var:v87"" />
                        </brutto_calc>
                      </xsl:if>
                    </xsl:for-each>
                  </xsl:for-each>
                  <xsl:for-each select=""s0:PostingDetails"">
                    <xsl:for-each select=""s0:Dimension"">
                      <xsl:variable name=""var:v88"" select=""string(./text())"" />
                      <xsl:variable name=""var:v89"" select=""userCSharp:StringUpperCase($var:v88)"" />
                      <xsl:variable name=""var:v90"" select=""userCSharp:LogicalEq(string($var:v89) , &quot;MVABELOP&quot;)"" />
                      <xsl:if test=""string($var:v90)='true'"">
                        <xsl:variable name=""var:v91"" select=""../s0:PostingCode/text()"" />
                        <vat>
                          <xsl:value-of select=""$var:v91"" />
                        </vat>
                      </xsl:if>
                    </xsl:for-each>
                  </xsl:for-each>
                  <xsl:for-each select=""s0:PostingDetails"">
                    <xsl:for-each select=""s0:Dimension"">
                      <xsl:variable name=""var:v92"" select=""string(./text())"" />
                      <xsl:variable name=""var:v93"" select=""userCSharp:StringUpperCase($var:v92)"" />
                      <xsl:variable name=""var:v94"" select=""userCSharp:LogicalEq(string($var:v93) , &quot;TEKST&quot;)"" />
                      <xsl:if test=""string($var:v94)='true'"">
                        <xsl:variable name=""var:v95"" select=""../s0:PostingCode/text()"" />
                        <t17>
                          <xsl:value-of select=""$var:v95"" />
                        </t17>
                      </xsl:if>
                    </xsl:for-each>
                  </xsl:for-each>
                  <xsl:for-each select=""s0:PostingDetails"">
                    <xsl:for-each select=""s0:Dimension"">
                      <xsl:variable name=""var:v96"" select=""string(./text())"" />
                      <xsl:variable name=""var:v97"" select=""userCSharp:StringUpperCase($var:v96)"" />
                      <xsl:variable name=""var:v98"" select=""userCSharp:LogicalEq(string($var:v97) , &quot;FORMÅL&quot;)"" />
                      <xsl:if test=""string($var:v98)='true'"">
                        <xsl:variable name=""var:v99"" select=""../s0:PostingCode/text()"" />
                        <t3>
                          <xsl:value-of select=""$var:v99"" />
                        </t3>
                      </xsl:if>
                    </xsl:for-each>
                  </xsl:for-each>
                  <xsl:for-each select=""s0:PostingDetails"">
                    <xsl:for-each select=""s0:Dimension"">
                      <xsl:variable name=""var:v100"" select=""string(./text())"" />
                      <xsl:variable name=""var:v101"" select=""userCSharp:StringUpperCase($var:v100)"" />
                      <xsl:variable name=""var:v102"" select=""userCSharp:LogicalEq(string($var:v101) , &quot;PERIODE&quot;)"" />
                      <xsl:if test=""string($var:v102)='true'"">
                        <xsl:variable name=""var:v103"" select=""../s0:PostingCode/text()"" />
                        <t5>
                          <xsl:value-of select=""$var:v103"" />
                        </t5>
                      </xsl:if>
                    </xsl:for-each>
                  </xsl:for-each>
                  <xsl:for-each select=""s0:PostingDetails"">
                    <xsl:for-each select=""s0:Dimension"">
                      <xsl:variable name=""var:v104"" select=""string(./text())"" />
                      <xsl:variable name=""var:v105"" select=""userCSharp:StringUpperCase($var:v104)"" />
                      <xsl:variable name=""var:v106"" select=""userCSharp:LogicalEq(string($var:v105) , &quot;MVAPROSENT&quot;)"" />
                      <xsl:if test=""string($var:v106)='true'"">
                        <xsl:variable name=""var:v107"" select=""../s0:PostingCode/text()"" />
                        <vat_pros>
                          <xsl:value-of select=""$var:v107"" />
                        </vat_pros>
                      </xsl:if>
                    </xsl:for-each>
                  </xsl:for-each>
                  <xsl:for-each select=""s0:PostingDetails"">
                    <xsl:for-each select=""s0:Dimension"">
                      <xsl:variable name=""var:v108"" select=""string(./text())"" />
                      <xsl:variable name=""var:v109"" select=""userCSharp:StringUpperCase($var:v108)"" />
                      <xsl:variable name=""var:v110"" select=""userCSharp:LogicalEq(string($var:v109) , &quot;RESOURCETYPE&quot;)"" />
                      <xsl:if test=""string($var:v110)='true'"">
                        <xsl:variable name=""var:v111"" select=""../s0:PostingCode/text()"" />
                        <t7>
                          <xsl:value-of select=""$var:v111"" />
                        </t7>
                      </xsl:if>
                    </xsl:for-each>
                  </xsl:for-each>
                  <xsl:for-each select=""s0:PostingDetails"">
                    <xsl:for-each select=""s0:Dimension"">
                      <xsl:variable name=""var:v112"" select=""string(./text())"" />
                      <xsl:variable name=""var:v113"" select=""userCSharp:StringUpperCase($var:v112)"" />
                      <xsl:variable name=""var:v114"" select=""userCSharp:LogicalEq(string($var:v113) , &quot;QUANTITY&quot;)"" />
                      <xsl:if test=""string($var:v114)='true'"">
                        <xsl:variable name=""var:v115"" select=""../s0:PostingCode/text()"" />
                        <t39>
                          <xsl:value-of select=""$var:v115"" />
                        </t39>
                      </xsl:if>
                    </xsl:for-each>
                  </xsl:for-each>
                  <xsl:for-each select=""s0:PostingDetails"">
                    <xsl:for-each select=""s0:Dimension"">
                      <xsl:variable name=""var:v116"" select=""string(./text())"" />
                      <xsl:variable name=""var:v117"" select=""userCSharp:StringUpperCase($var:v116)"" />
                      <xsl:variable name=""var:v118"" select=""userCSharp:LogicalEq(string($var:v117) , &quot;PROFILE&quot;)"" />
                      <xsl:if test=""string($var:v118)='true'"">
                        <xsl:variable name=""var:v119"" select=""../s0:PostingCode/text()"" />
                        <t9>
                          <xsl:value-of select=""$var:v119"" />
                        </t9>
                      </xsl:if>
                    </xsl:for-each>
                  </xsl:for-each>
                  <xsl:for-each select=""s0:PostingDetails"">
                    <xsl:for-each select=""s0:Dimension"">
                      <xsl:variable name=""var:v120"" select=""string(./text())"" />
                      <xsl:variable name=""var:v121"" select=""userCSharp:StringUpperCase($var:v120)"" />
                      <xsl:variable name=""var:v122"" select=""userCSharp:LogicalEq(string($var:v121) , &quot;ACTIVITY&quot;)"" />
                      <xsl:if test=""string($var:v122)='true'"">
                        <xsl:variable name=""var:v123"" select=""../s0:PostingCode/text()"" />
                        <t41>
                          <xsl:value-of select=""$var:v123"" />
                        </t41>
                      </xsl:if>
                    </xsl:for-each>
                  </xsl:for-each>
                  <xsl:for-each select=""s0:PostingDetails"">
                    <xsl:for-each select=""s0:Dimension"">
                      <xsl:variable name=""var:v124"" select=""string(./text())"" />
                      <xsl:variable name=""var:v125"" select=""userCSharp:StringUpperCase($var:v124)"" />
                      <xsl:variable name=""var:v126"" select=""userCSharp:LogicalEq(string($var:v125) , &quot;PRODUCT&quot;)"" />
                      <xsl:if test=""string($var:v126)='true'"">
                        <xsl:variable name=""var:v127"" select=""../s0:PostingCode/text()"" />
                        <t22>
                          <xsl:value-of select=""$var:v127"" />
                        </t22>
                      </xsl:if>
                    </xsl:for-each>
                  </xsl:for-each>
                  <xsl:for-each select=""s0:PostingDetails"">
                    <xsl:for-each select=""s0:Dimension"">
                      <xsl:variable name=""var:v128"" select=""string(./text())"" />
                      <xsl:variable name=""var:v129"" select=""userCSharp:StringUpperCase($var:v128)"" />
                      <xsl:variable name=""var:v130"" select=""userCSharp:LogicalEq(string($var:v129) , &quot;MVATYPE&quot;)"" />
                      <xsl:if test=""string($var:v130)='true'"">
                        <xsl:variable name=""var:v131"" select=""../s0:PostingCode/text()"" />
                        <t26>
                          <xsl:value-of select=""$var:v131"" />
                        </t26>
                      </xsl:if>
                    </xsl:for-each>
                  </xsl:for-each>
                  <xsl:for-each select=""s0:PostingDetails"">
                    <xsl:for-each select=""s0:Dimension"">
                      <xsl:variable name=""var:v132"" select=""string(./text())"" />
                      <xsl:variable name=""var:v133"" select=""userCSharp:StringUpperCase($var:v132)"" />
                      <xsl:variable name=""var:v134"" select=""userCSharp:LogicalEq(string($var:v133) , &quot;VATUSETYPE&quot;)"" />
                      <xsl:if test=""string($var:v134)='true'"">
                        <xsl:variable name=""var:v135"" select=""../s0:PostingCode/text()"" />
                        <t27>
                          <xsl:value-of select=""$var:v135"" />
                        </t27>
                      </xsl:if>
                    </xsl:for-each>
                  </xsl:for-each>
                  <xsl:for-each select=""s0:PostingDetails"">
                    <xsl:for-each select=""s0:Dimension"">
                      <xsl:variable name=""var:v136"" select=""string(./text())"" />
                      <xsl:variable name=""var:v137"" select=""userCSharp:StringUpperCase($var:v136)"" />
                      <xsl:variable name=""var:v138"" select=""userCSharp:LogicalEq(string($var:v137) , &quot;PROJECT&quot;)"" />
                      <xsl:if test=""string($var:v138)='true'"">
                        <xsl:variable name=""var:v139"" select=""../s0:PostingCode/text()"" />
                        <t31>
                          <xsl:value-of select=""$var:v139"" />
                        </t31>
                      </xsl:if>
                    </xsl:for-each>
                  </xsl:for-each>
                </acc_data>
              </xsl:if>
            </xsl:for-each>
          </xsl:for-each>
          <supplier>
            <xsl:for-each select=""s0:InvoiceHeader"">
              <xsl:for-each select=""s0:Supplier"">
                <xsl:for-each select=""s0:Name"">
                  <name>
                    <xsl:value-of select=""./text()"" />
                  </name>
                </xsl:for-each>
              </xsl:for-each>
            </xsl:for-each>
            <xsl:for-each select=""s0:InvoiceHeader"">
              <xsl:for-each select=""s0:Supplier"">
                <xsl:for-each select=""s0:PostalAddress"">
                  <xsl:for-each select=""s0:Address1"">
                    <address1>
                      <xsl:value-of select=""./text()"" />
                    </address1>
                  </xsl:for-each>
                </xsl:for-each>
              </xsl:for-each>
            </xsl:for-each>
            <xsl:for-each select=""s0:InvoiceHeader"">
              <xsl:for-each select=""s0:Supplier"">
                <xsl:for-each select=""s0:PostalAddress"">
                  <xsl:for-each select=""s0:PostalCode"">
                    <address2>
                      <xsl:value-of select=""./text()"" />
                    </address2>
                  </xsl:for-each>
                </xsl:for-each>
              </xsl:for-each>
            </xsl:for-each>
            <xsl:for-each select=""s0:InvoiceHeader"">
              <xsl:for-each select=""s0:Supplier"">
                <xsl:for-each select=""s0:PostalAddress"">
                  <xsl:for-each select=""s0:PostalDistrict"">
                    <address3>
                      <xsl:value-of select=""./text()"" />
                    </address3>
                  </xsl:for-each>
                </xsl:for-each>
              </xsl:for-each>
            </xsl:for-each>
            <xsl:for-each select=""s0:InvoiceHeader"">
              <xsl:for-each select=""s0:Supplier"">
                <xsl:for-each select=""s0:OrgNumber"">
                  <orgno>
                    <xsl:value-of select=""./text()"" />
                  </orgno>
                </xsl:for-each>
              </xsl:for-each>
            </xsl:for-each>
            <xsl:for-each select=""s0:InvoiceHeader"">
              <xsl:for-each select=""s0:Supplier"">
                <xsl:for-each select=""s0:LocationId"">
                  <locno>
                    <xsl:value-of select=""./text()"" />
                  </locno>
                </xsl:for-each>
              </xsl:for-each>
            </xsl:for-each>
            <xsl:for-each select=""s0:InvoiceHeader"">
              <xsl:for-each select=""s0:Supplier"">
                <xsl:for-each select=""s0:AccountInformation"">
                  <xsl:for-each select=""s0:AccountNumber"">
                    <bankacc>
                      <xsl:value-of select=""./text()"" />
                    </bankacc>
                  </xsl:for-each>
                </xsl:for-each>
              </xsl:for-each>
            </xsl:for-each>
          </supplier>
          <buyer>
            <xsl:for-each select=""s0:InvoiceHeader"">
              <xsl:for-each select=""s0:Buyer"">
                <xsl:for-each select=""s0:Name"">
                  <name>
                    <xsl:value-of select=""./text()"" />
                  </name>
                </xsl:for-each>
              </xsl:for-each>
            </xsl:for-each>
            <xsl:for-each select=""s0:InvoiceHeader"">
              <xsl:for-each select=""s0:Buyer"">
                <xsl:for-each select=""s0:PostalAddress"">
                  <xsl:for-each select=""s0:Address1"">
                    <address1>
                      <xsl:value-of select=""./text()"" />
                    </address1>
                  </xsl:for-each>
                </xsl:for-each>
              </xsl:for-each>
            </xsl:for-each>
            <xsl:for-each select=""s0:InvoiceHeader"">
              <xsl:for-each select=""s0:Buyer"">
                <xsl:for-each select=""s0:PostalAddress"">
                  <xsl:for-each select=""s0:PostalCode"">
                    <address2>
                      <xsl:value-of select=""./text()"" />
                    </address2>
                  </xsl:for-each>
                </xsl:for-each>
              </xsl:for-each>
            </xsl:for-each>
            <xsl:for-each select=""s0:InvoiceHeader"">
              <xsl:for-each select=""s0:Buyer"">
                <xsl:for-each select=""s0:PostalAddress"">
                  <xsl:for-each select=""s0:PostalDistrict"">
                    <address3>
                      <xsl:value-of select=""./text()"" />
                    </address3>
                  </xsl:for-each>
                </xsl:for-each>
              </xsl:for-each>
            </xsl:for-each>
            <xsl:for-each select=""s0:InvoiceHeader"">
              <xsl:for-each select=""s0:Buyer"">
                <xsl:for-each select=""s0:OrgNumber"">
                  <orgno>
                    <xsl:value-of select=""./text()"" />
                  </orgno>
                </xsl:for-each>
              </xsl:for-each>
            </xsl:for-each>
            <xsl:for-each select=""s0:InvoiceHeader"">
              <xsl:for-each select=""s0:Buyer"">
                <xsl:for-each select=""s0:LocationId"">
                  <locno>
                    <xsl:value-of select=""./text()"" />
                  </locno>
                </xsl:for-each>
              </xsl:for-each>
            </xsl:for-each>
          </buyer>
          <invoicee>
            <xsl:for-each select=""s0:InvoiceHeader"">
              <xsl:for-each select=""s0:Invoicee"">
                <xsl:for-each select=""s0:Name"">
                  <name>
                    <xsl:value-of select=""./text()"" />
                  </name>
                </xsl:for-each>
              </xsl:for-each>
            </xsl:for-each>
            <xsl:for-each select=""s0:InvoiceHeader"">
              <xsl:for-each select=""s0:Invoicee"">
                <xsl:for-each select=""s0:PostalAddress"">
                  <xsl:for-each select=""s0:Address1"">
                    <address1>
                      <xsl:value-of select=""./text()"" />
                    </address1>
                  </xsl:for-each>
                </xsl:for-each>
              </xsl:for-each>
            </xsl:for-each>
            <xsl:for-each select=""s0:InvoiceHeader"">
              <xsl:for-each select=""s0:Invoicee"">
                <xsl:for-each select=""s0:PostalAddress"">
                  <xsl:for-each select=""s0:PostalCode"">
                    <address2>
                      <xsl:value-of select=""./text()"" />
                    </address2>
                  </xsl:for-each>
                </xsl:for-each>
              </xsl:for-each>
            </xsl:for-each>
            <xsl:for-each select=""s0:InvoiceHeader"">
              <xsl:for-each select=""s0:Invoicee"">
                <xsl:for-each select=""s0:PostalAddress"">
                  <xsl:for-each select=""s0:PostalDistrict"">
                    <address3>
                      <xsl:value-of select=""./text()"" />
                    </address3>
                  </xsl:for-each>
                </xsl:for-each>
              </xsl:for-each>
            </xsl:for-each>
            <xsl:for-each select=""s0:InvoiceHeader"">
              <xsl:for-each select=""s0:Invoicee"">
                <xsl:for-each select=""s0:OrgNumber"">
                  <orgno>
                    <xsl:value-of select=""./text()"" />
                  </orgno>
                </xsl:for-each>
              </xsl:for-each>
            </xsl:for-each>
            <xsl:for-each select=""s0:InvoiceHeader"">
              <xsl:for-each select=""s0:Invoicee"">
                <xsl:for-each select=""s0:LocationId"">
                  <xsl:variable name=""var:v140"" select=""string(./text())"" />
                  <xsl:variable name=""var:v141"" select=""userCSharp:LogicalEq($var:v140 , &quot;7080000985135&quot;)"" />
                  <xsl:variable name=""var:v142"" select=""userCSharp:StringConcat(&quot;7080000068982&quot;)"" />
                  <xsl:if test=""string($var:v141)='true'"">
                    <xsl:variable name=""var:v143"" select=""string($var:v142)"" />
                    <locno>
                      <xsl:value-of select=""$var:v143"" />
                    </locno>
                  </xsl:if>
                  <xsl:variable name=""var:v144"" select=""userCSharp:LogicalNe($var:v140 , &quot;7080000985135&quot;)"" />
                  <xsl:if test=""string($var:v144)='true'"">
                    <xsl:variable name=""var:v145"" select=""./text()"" />
                    <locno>
                      <xsl:value-of select=""$var:v145"" />
                    </locno>
                  </xsl:if>
                </xsl:for-each>
              </xsl:for-each>
            </xsl:for-each>
          </invoicee>
          <xsl:for-each select=""s0:InvoiceHeader"">
            <xsl:for-each select=""s0:FreeText"">
              <xsl:variable name=""var:v146"" select=""string(./text())"" />
              <xsl:variable name=""var:v147"" select=""userCSharp:StringConcat($var:v146 , &quot; &quot; , string(../../s0:InvoiceDetails/s0:FreeText/text()))"" />
              <xsl:variable name=""var:v148"" select=""userCSharp:StringTrimLeft(string($var:v147))"" />
              <xsl:variable name=""var:v149"" select=""userCSharp:StringTrimRight(string($var:v148))"" />
              <textfield>
                <xsl:value-of select=""$var:v149"" />
              </textfield>
            </xsl:for-each>
          </xsl:for-each>
          <xsl:value-of select=""./text()"" />
        </invoice>
      </xsl:for-each>
    </invoices>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string DateCurrentDateTime()
{
	DateTime dt = DateTime.Now;
	string curdate = dt.ToString(""yyyy-MM-dd"", System.Globalization.CultureInfo.InvariantCulture);
	string curtime = dt.ToString(""T"", System.Globalization.CultureInfo.InvariantCulture);
	string retval = curdate + ""T"" + curtime;
	return retval;
}


public bool LogicalEq(string val1, string val2)
{
	bool ret = false;
	double d1 = 0;
	double d2 = 0;
	if (IsNumeric(val1, ref d1) && IsNumeric(val2, ref d2))
	{
		ret = d1 == d2;
	}
	else
	{
		ret = String.Compare(val1, val2, StringComparison.Ordinal) == 0;
	}
	return ret;
}


public string StringUpperCase(string str)
{
	if (str == null)
	{
		return """";
	}
	return str.ToUpper(System.Globalization.CultureInfo.InvariantCulture);
}


public string StringConcat(string param0, string param1, string param2)
{
   return param0 + param1 + param2;
}


public string StringTrimLeft(string str)
{
	if (str == null)
	{
		return """";
	}
	return str.TrimStart(null);
}


public string StringTrimRight(string str)
{
	if (str == null)
	{
		return """";
	}
	return str.TrimEnd(null);
}


public string InitCumulativeConcat(int index)
{
	if (index >= 0)
	{
		if (index >= myCumulativeConcatArray.Count)
		{
			int i = myCumulativeConcatArray.Count;
			for (; i<=index; i++)
			{
				myCumulativeConcatArray.Add("""");
			}
		}
		else
		{
			myCumulativeConcatArray[index] = """";
		}
	}
	return """";
}

public System.Collections.ArrayList myCumulativeConcatArray = new System.Collections.ArrayList();

public string AddToCumulativeConcat(int index, string val, string notused)
{
	if (index < 0 || index >= myCumulativeConcatArray.Count)
	{
		return """";
	}
	myCumulativeConcatArray[index] = (string)(myCumulativeConcatArray[index]) + val;
	return myCumulativeConcatArray[index].ToString();
}

public string GetCumulativeConcat(int index)
{
	if (index < 0 || index >= myCumulativeConcatArray.Count)
	{
		return """";
	}
	return myCumulativeConcatArray[index].ToString();
}

public string StringConcat(string param0, string param1)
{
   return param0 + param1;
}


public bool LogicalNe(string val1, string val2)
{
	bool ret = false;
	double d1 = 0;
	double d2 = 0;
	if (IsNumeric(val1, ref d1) && IsNumeric(val2, ref d2))
	{
		ret = d1 != d2;
	}
	else
	{
		ret = String.Compare(val1, val2, StringComparison.Ordinal) != 0;
	}
	return ret;
}


public bool setVatPercent_0(string value)
{
    value = value.Replace(""."", "","");
    Decimal number;
    bool result = Decimal.TryParse(value, out number);
    return (number.Equals(0)) ? true : false;
}

public bool setVatPercent_8(string value)
{
    value = value.Replace(""."", "","");
    Decimal number;
    bool result = Decimal.TryParse(value, out number);
    return (number.Equals(8)) ? true : false;
}

public bool setVatPercent_13(string strParam)
{
     strParam = strParam.Trim();
     return (strParam.Length > 1 && strParam.Substring(0, 2).Equals(""13"")) ? true : false;
}

public bool setVatPercent_14(string strParam)
{
    strParam = strParam.Trim();
    return (strParam.Length > 1 && strParam.Substring(0, 2).Equals(""14"")) ? true : false;
}

public bool setVatPercent_25(string strParam)
{
    strParam = strParam.Trim();
    return (strParam.Length > 1 && strParam.Substring(0, 2).Equals(""25"")) ? true : false;
}

public string StringConcat(string param0)
{
   return param0;
}


public string postKonto(string strIn)
{
    return strIn.Trim().ToUpper().Equals(""PSKONTO"") ? ""KONTO"" : strIn;
}

public string postAvd(string strIn)
{
   return strIn.Trim().ToUpper().Equals(""PSAVDELING"") ? ""AVDELING"" : strIn;
}

public bool LogicalExistence(bool val)
{
	return val;
}


public string ReplaceDot7(string strPar)
{
     strPar = (strPar.Trim().Length == 0) ? ""0"" : strPar.Replace(""."", "","");
     return Double.Parse(strPar).ToString();
}

public string ReplaceDot8(string strPar)
{
    strPar = (strPar.Trim().Length == 0) ? ""0"" : strPar.Replace(""."", "","");
    return Double.Parse(strPar).ToString();
}

public bool CheckVATTotal(string strCalc, string strSum)
{
        double calc = double.Parse(strCalc.Replace(""."", "",""));
        calc = Math.Round(calc, 2);

        double sum = double.Parse(strSum.Replace(""."", "",""));
        sum = Math.Round(sum, 2);

        double strOpr = Math.Abs(calc - sum); 
       
        if (strOpr > 1)
            throw new Exception(""Momssumman felaktig (kalkylerad="" + calc.ToString() + "" och filsumman= "" + sum.ToString() + "") O="" + Math.Round(strOpr, 2).ToString() + "")"");

        return true;
}

public string ReplaceDot9(string strPar)
{
    strPar = (strPar.Trim().Length == 0) ? ""0"" : strPar.Replace(""."", "","");
    return Double.Parse(strPar).ToString();
}

public string ReplaceDot10(string strPar)
{
    strPar = (strPar.Trim().Length == 0) ? ""0"" : strPar.Replace(""."", "","");
     return Double.Parse(strPar).ToString();
}

public string CalcVATTotal(string strNet, string strVAT, string strRound)
{
    double net = Double.Parse(strNet.Replace(""."", "",""));
    double vat = Double.Parse(strVAT.Replace(""."", "",""));
    double round = Double.Parse(strRound.Replace(""."", "",""));

    //string errMsg = ""N="" + net.ToString() + "";V="" + vat.ToString() + "";R="" + round.ToString() + "";"";

    return (net + vat + round).ToString();
}

public string ReplaceDot1(string strPar)
{
    return (strPar.Trim().Length == 0) ? ""0"" : strPar;
}

public string ReplaceDot2(string strPar)
{
    strPar = (strPar.Trim().Length == 0) ? ""0"" : strPar.Replace(""."", "","");
    return Double.Parse(strPar).ToString();
}

public string ReplaceDot11(string strPar)
{
    strPar = (strPar.Trim().Length == 0) ? ""0"" : strPar.Replace(""."", "","");
    return Double.Parse(strPar).ToString();
}

public string ReplaceDot12(string strPar)
{
    strPar = (strPar.Trim().Length == 0) ? ""0"" : strPar.Replace(""."", "","");
     return Double.Parse(strPar).ToString();
}

public bool CheckTotal(string strCalc, string strSum, string strDiscount, string strCharges)
{
        double calc = double.Parse(strCalc.Replace(""."", "",""));
        calc = Math.Round(calc, 2);

        double sum = double.Parse(strSum.Replace(""."", "",""));
        sum = Math.Round(sum, 2);

        double discount = double.Parse(strDiscount.Replace(""."", "",""));
        discount = Math.Round(discount, 2);

        double charges = double.Parse(strCharges.Replace(""."", "",""));
        charges = Math.Round(charges, 2);

        calc = calc - discount + charges;

        if (Math.Abs(calc - sum) > 1)
            throw new Exception(""Totalsumman felaktig (kalkylerad="" + calc.ToString() + "" och filsumman= "" + sum.ToString() + "")"");

        return true;
}

public string InitCumulativeSum(int index)
{
	if (index >= 0)
	{
		if (index >= myCumulativeSumArray.Count)
		{
			int i = myCumulativeSumArray.Count;
			for (; i<=index; i++)
			{
				myCumulativeSumArray.Add("""");
			}
		}
		else
		{
			myCumulativeSumArray[index] = """";
		}
	}
	return """";
}

public System.Collections.ArrayList myCumulativeSumArray = new System.Collections.ArrayList();

public string AddToCumulativeSum(int index, string val, string notused)
{
	if (index < 0 || index >= myCumulativeSumArray.Count)
	{
		return """";
    }
	double d = 0;
	if (IsNumeric(val, ref d))
	{
		if (myCumulativeSumArray[index] == """")
		{
			myCumulativeSumArray[index] = d;
		}
		else
		{
			myCumulativeSumArray[index] = (double)(myCumulativeSumArray[index]) + d;
		}
	}
	return (myCumulativeSumArray[index] is double) ? ((double)myCumulativeSumArray[index]).ToString(System.Globalization.CultureInfo.InvariantCulture) : """";
}

public string GetCumulativeSum(int index)
{
	if (index < 0 || index >= myCumulativeSumArray.Count)
	{
		return """";
	}
	return (myCumulativeSumArray[index] is double) ? ((double)myCumulativeSumArray[index]).ToString(System.Globalization.CultureInfo.InvariantCulture) : """";
}

public string MyFunction99(bool p_strParm0, bool p_strParm01)
{
        return """";
}

public bool IsNumeric(string val)
{
	if (val == null)
	{
		return false;
	}
	double d = 0;
	return Double.TryParse(val, System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out d);
}

public bool IsNumeric(string val, ref double d)
{
	if (val == null)
	{
		return false;
	}
	return Double.TryParse(val, System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out d);
}


]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"ComplexMap.E2B";
        
        private const string _strTrgSchemasList0 = @"ComplexMap.Invoice";
        
        public override string XmlContent {
            get {
                return _strMap;
            }
        }
        
        public override string XsltArgumentListContent {
            get {
                return _strArgList;
            }
        }
        
        public override string[] SourceSchemas {
            get {
                string[] _SrcSchemas = new string [1];
                _SrcSchemas[0] = @"ComplexMap.E2B";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"ComplexMap.Invoice";
                return _TrgSchemas;
            }
        }
    }
}
