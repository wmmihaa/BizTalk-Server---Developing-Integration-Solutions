namespace Lab12 {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Lab12.OrderFF", typeof(global::Lab12.OrderFF))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Lab12.Order", typeof(global::Lab12.Order))]
    public sealed class OrderFF_to_Order : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:s0=""http://Lab12.OrderFF"" xmlns:ns0=""http://Lab12.Order"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Order"" />
  </xsl:template>
  <xsl:template match=""/s0:Order"">
    <ns0:Order>
      <OrderId>
        <xsl:value-of select=""id/text()"" />
      </OrderId>
      <CustomerName>
        <xsl:value-of select=""name/text()"" />
      </CustomerName>
      <OrderDate>
        <xsl:value-of select=""orderDate/text()"" />
      </OrderDate>
      <ShippingDate>
        <xsl:value-of select=""shippingDate/text()"" />
      </ShippingDate>
      <ItemData>
        <xsl:value-of select=""data/text()"" />
      </ItemData>
      <TotalSum>
        <xsl:value-of select=""total/text()"" />
      </TotalSum>
      <Approved>
        <xsl:value-of select=""approved/text()"" />
      </Approved>
      <DeliveryNotes>
        <xsl:value-of select=""notes/text()"" />
      </DeliveryNotes>
    </ns0:Order>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"Lab12.OrderFF";
        
        private const string _strTrgSchemasList0 = @"Lab12.Order";
        
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
                _SrcSchemas[0] = @"Lab12.OrderFF";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"Lab12.Order";
                return _TrgSchemas;
            }
        }
    }
}
