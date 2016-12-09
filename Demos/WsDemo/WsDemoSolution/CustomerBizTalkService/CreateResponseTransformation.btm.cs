namespace CustomerBizTalkService {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"CustomerBizTalkService.GetCustomerNumerRequest", typeof(global::CustomerBizTalkService.GetCustomerNumerRequest))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"CustomerBizTalkService.GetCustomerNumerResponse", typeof(global::CustomerBizTalkService.GetCustomerNumerResponse))]
    public sealed class CreateResponseTransformation : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:ns0=""http://CustomerBizTalkService.GetCustomerNumerResponse"" xmlns:s0=""http://CustomerBizTalkService.GetCustomerNumerRequest"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:GetCustomerNumerRequest"" />
  </xsl:template>
  <xsl:template match=""/s0:GetCustomerNumerRequest"">
    <ns0:GetCustomerNumerResponse>
      <xsl:attribute name=""CustomerNumber"">
        <xsl:text>0</xsl:text>
      </xsl:attribute>
    </ns0:GetCustomerNumerResponse>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"CustomerBizTalkService.GetCustomerNumerRequest";
        
        private const string _strTrgSchemasList0 = @"CustomerBizTalkService.GetCustomerNumerResponse";
        
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
                _TrgSchemas[0] = @"CustomerBizTalkService.GetCustomerNumerResponse";
                return _TrgSchemas;
            }
        }
    }
}
