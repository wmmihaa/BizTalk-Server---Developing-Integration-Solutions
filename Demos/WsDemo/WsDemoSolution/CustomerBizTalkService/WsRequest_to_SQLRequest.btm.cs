namespace CustomerBizTalkService.CustomerBizTalkService2 {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"CustomerBizTalkService.GetCustomerNumerRequest", typeof(CustomerBizTalkService.GetCustomerNumerRequest))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"CustomerBizTalkService.CustomerBizTalkService2.TypedProcedure_dbo+sp_GetCustomerNumber", typeof(CustomerBizTalkService.CustomerBizTalkService2.TypedProcedure_dbo.sp_GetCustomerNumber))]
    public sealed class WsRequest_to_SQLRequest : Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:s0=""http://CustomerBizTalkService.GetCustomerNumerRequest"" xmlns:ns3=""http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/sp_GetCustomerNumber"" xmlns:ns0=""http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:GetCustomerNumerRequest"" />
  </xsl:template>
  <xsl:template match=""/s0:GetCustomerNumerRequest"">
    <ns0:sp_GetCustomerNumber>
      <xsl:if test=""@name"">
        <ns0:name>
          <xsl:value-of select=""@name"" />
        </ns0:name>
      </xsl:if>
    </ns0:sp_GetCustomerNumber>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"CustomerBizTalkService.GetCustomerNumerRequest";
        
        private const CustomerBizTalkService.GetCustomerNumerRequest _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"CustomerBizTalkService.CustomerBizTalkService2.TypedProcedure_dbo+sp_GetCustomerNumber";
        
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
                _SrcSchemas[0] = @"CustomerBizTalkService.GetCustomerNumerRequest";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"CustomerBizTalkService.CustomerBizTalkService2.TypedProcedure_dbo+sp_GetCustomerNumber";
                return _TrgSchemas;
            }
        }
    }
}
