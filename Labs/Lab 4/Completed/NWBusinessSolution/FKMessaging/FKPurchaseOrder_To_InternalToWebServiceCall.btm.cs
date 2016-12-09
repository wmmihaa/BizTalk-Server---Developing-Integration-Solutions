namespace FKMessaging {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"FKMessaging.SupplierPO", typeof(FKMessaging.SupplierPO))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"FKMessaging.localhost.Reference", typeof(FKMessaging.localhost.Reference))]
    public sealed class FKPurchaseOrder_To_InternalToWebServiceCall : Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns0=""http://tempuri.org/"" xmlns:s0=""http://FKMessaging.SupplierPO"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:PurchaseOrder"" />
  </xsl:template>
  <xsl:template match=""/s0:PurchaseOrder"">
    <xsl:variable name=""var:v1"" select=""userCSharp:DateCurrentDateTime()"" />
    <ns0:SuppOrder>
      <ns0:customerPONumber>
        <xsl:value-of select=""PONumber/text()"" />
      </ns0:customerPONumber>
      <ns0:ItemId>
        <xsl:value-of select=""Items/Item/ProdId/text()"" />
      </ns0:ItemId>
      <ns0:Quantity>
        <xsl:value-of select=""Items/Item/Qty/text()"" />
      </ns0:Quantity>
      <ns0:Priority>
        <xsl:text>1</xsl:text>
      </ns0:Priority>
      <ns0:OrderDate>
        <xsl:value-of select=""$var:v1"" />
      </ns0:OrderDate>
    </ns0:SuppOrder>
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



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"FKMessaging.SupplierPO";
        
        private const string _strTrgSchemasList0 = @"FKMessaging.localhost.Reference";
        
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
                _SrcSchemas[0] = @"FKMessaging.SupplierPO";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"FKMessaging.localhost.Reference";
                return _TrgSchemas;
            }
        }
    }
}
