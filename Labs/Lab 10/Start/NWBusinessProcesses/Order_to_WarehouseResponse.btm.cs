namespace NWBusinessProcesses {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"NWMessaging.CustomerOrder", typeof(NWMessaging.CustomerOrder))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"NWBusinessProcesses.DistributorService_northwind_com_services_DistributorService+ReserveDistributorResponse", typeof(NWBusinessProcesses.DistributorService_northwind_com_services_DistributorService.ReserveDistributorResponse))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"NWMessaging.DistResp", typeof(NWMessaging.DistResp))]
    public sealed class Order_to_WarehouseResponse : Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 s2 s3 s1 userCSharp"" version=""1.0"" xmlns:ns0=""http://NWMessaging.DistResp"" xmlns:s0=""http://northwind.com/services/DistributorService"" xmlns:s2=""http://schemas.microsoft.com/BizTalk/2003/aggschema"" xmlns:s3=""http://NWMessaging.ShippingAddress"" xmlns:s1=""http://NWMessaging.CustomerOrder"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s2:Root"" />
  </xsl:template>
  <xsl:template match=""/s2:Root"">
    <xsl:variable name=""var:v1"" select=""userCSharp:LogicalNot(string(InputMessagePart_1/s0:ReserveDistributorResponse/s0:ReserveDistributorResult/s0:Accepted/text()))"" />
    <ns0:WarehouseResponse>
      <CustomerPONumber>
        <xsl:value-of select=""InputMessagePart_0/s1:CustomerOrder/CustomerPONumber/text()"" />
      </CustomerPONumber>
      <xsl:if test=""string($var:v1)='true'"">
        <xsl:variable name=""var:v2"" select=""&quot;Rejected&quot;"" />
        <Status>
          <xsl:value-of select=""$var:v2"" />
        </Status>
      </xsl:if>
      <xsl:if test=""InputMessagePart_1/s0:ReserveDistributorResponse/s0:ReserveDistributorResult/s0:Accepted/text()='true'"">
        <xsl:variable name=""var:v3"" select=""&quot;Shipped&quot;"" />
        <Status>
          <xsl:value-of select=""$var:v3"" />
        </Status>
      </xsl:if>
      <xsl:if test=""InputMessagePart_1/s0:ReserveDistributorResponse/s0:ReserveDistributorResult/s0:ShippingDate"">
        <DeliveryDate>
          <xsl:value-of select=""InputMessagePart_1/s0:ReserveDistributorResponse/s0:ReserveDistributorResult/s0:ShippingDate/text()"" />
        </DeliveryDate>
      </xsl:if>
    </ns0:WarehouseResponse>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public bool LogicalNot(string val)
{
	return !ValToBool(val);
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

public bool ValToBool(string val)
{
	if (val != null)
	{
		if (string.Compare(val, bool.TrueString, StringComparison.OrdinalIgnoreCase) == 0)
		{
			return true;
		}
		if (string.Compare(val, bool.FalseString, StringComparison.OrdinalIgnoreCase) == 0)
		{
			return false;
		}
		val = val.Trim();
		if (string.Compare(val, bool.TrueString, StringComparison.OrdinalIgnoreCase) == 0)
		{
			return true;
		}
		if (string.Compare(val, bool.FalseString, StringComparison.OrdinalIgnoreCase) == 0)
		{
			return false;
		}
		double d = 0;
		if (IsNumeric(val, ref d))
		{
			return (d > 0);
		}
	}
	return false;
}


]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"NWMessaging.CustomerOrder";
        
        private const NWMessaging.CustomerOrder _srcSchemaTypeReference0 = null;
        
        private const string _strSrcSchemasList1 = @"NWBusinessProcesses.DistributorService_northwind_com_services_DistributorService+ReserveDistributorResponse";
        
        private const string _strTrgSchemasList0 = @"NWMessaging.DistResp";
        
        private const NWMessaging.DistResp _trgSchemaTypeReference0 = null;
        
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
                string[] _SrcSchemas = new string [2];
                _SrcSchemas[0] = @"NWMessaging.CustomerOrder";
                _SrcSchemas[1] = @"NWBusinessProcesses.DistributorService_northwind_com_services_DistributorService+ReserveDistributorResponse";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"NWMessaging.DistResp";
                return _TrgSchemas;
            }
        }
    }
}
