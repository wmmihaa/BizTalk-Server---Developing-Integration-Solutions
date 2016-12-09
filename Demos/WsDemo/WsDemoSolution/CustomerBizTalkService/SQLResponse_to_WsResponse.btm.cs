namespace CustomerBizTalkService.CustomerBizTalkService2 {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"CustomerBizTalkService.CustomerBizTalkService2.TypedProcedure_dbo+sp_GetCustomerNumberResponse", typeof(CustomerBizTalkService.CustomerBizTalkService2.TypedProcedure_dbo.sp_GetCustomerNumberResponse))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"CustomerBizTalkService.GetCustomerNumerResponse", typeof(CustomerBizTalkService.GetCustomerNumerResponse))]
    public sealed class SQLResponse_to_WsResponse : Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 s1 userCSharp"" version=""1.0"" xmlns:s0=""http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/sp_GetCustomerNumber"" xmlns:s1=""http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo"" xmlns:ns0=""http://CustomerBizTalkService.GetCustomerNumerResponse"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s1:sp_GetCustomerNumberResponse"" />
  </xsl:template>
  <xsl:template match=""/s1:sp_GetCustomerNumberResponse"">
    <xsl:variable name=""var:v1"" select=""position()"" />
    <xsl:variable name=""var:v2"" select=""userCSharp:LogicalEq(string($var:v1) , &quot;1&quot;)"" />
    <xsl:if test=""$var:v2"">
      <ns0:GetCustomerNumerResponse>
        <xsl:if test=""s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:CustomerNo"">
          <xsl:attribute name=""CustomerNumber"">
            <xsl:value-of select=""s1:StoredProcedureResultSet0/s0:StoredProcedureResultSet0/s0:CustomerNo/text()"" />
          </xsl:attribute>
        </xsl:if>
      </ns0:GetCustomerNumerResponse>
    </xsl:if>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
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
        
        private const string _strSrcSchemasList0 = @"CustomerBizTalkService.CustomerBizTalkService2.TypedProcedure_dbo+sp_GetCustomerNumberResponse";
        
        private const string _strTrgSchemasList0 = @"CustomerBizTalkService.GetCustomerNumerResponse";
        
        private const CustomerBizTalkService.GetCustomerNumerResponse _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"CustomerBizTalkService.CustomerBizTalkService2.TypedProcedure_dbo+sp_GetCustomerNumberResponse";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"CustomerBizTalkService.GetCustomerNumerResponse";
                return _TrgSchemas;
            }
        }
    }
}
