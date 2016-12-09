namespace Lab7b {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Lab7b.Tweet", typeof(global::Lab7b.Tweet))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Lab7b.TableOperation_dbo_Tweets+Insert", typeof(global::Lab7b.TableOperation_dbo_Tweets.Insert))]
    public sealed class Tweet_to_Insert : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:ns0=""http://schemas.microsoft.com/Sql/2008/05/TableOp/dbo/Tweets"" xmlns:s0=""http://A372.Tweet"" xmlns:array=""http://schemas.microsoft.com/2003/10/Serialization/Arrays"" xmlns:ns3=""http://schemas.microsoft.com/Sql/2008/05/Types/Tables/dbo"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Tweet"" />
  </xsl:template>
  <xsl:template match=""/s0:Tweet"">
    <ns0:Insert>
      <ns0:Rows>
        <ns3:Tweets>
          <ns3:Author>
            <xsl:value-of select=""name/text()"" />
          </ns3:Author>
          <ns3:Tweet>
            <xsl:value-of select=""tweet/text()"" />
          </ns3:Tweet>
        </ns3:Tweets>
      </ns0:Rows>
    </ns0:Insert>
  </xsl:template>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"Lab7b.Tweet";
        
        private const global::Lab7b.Tweet _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"Lab7b.TableOperation_dbo_Tweets+Insert";
        
        private const global::Lab7b.TableOperation_dbo_Tweets.Insert _trgSchemaTypeReference0 = null;
        
        public override string XmlContent {
            get {
                return _strMap;
            }
        }
        
        public override int UseXSLTransform {
            get {
                return _useXSLTransform;
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
                _SrcSchemas[0] = @"Lab7b.Tweet";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"Lab7b.TableOperation_dbo_Tweets+Insert";
                return _TrgSchemas;
            }
        }
    }
}
