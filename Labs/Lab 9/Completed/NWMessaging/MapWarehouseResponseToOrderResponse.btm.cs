namespace NWMessaging {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"NWMessaging.DistResp", typeof(global::NWMessaging.DistResp))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"NWMessaging.OrderResponse", typeof(global::NWMessaging.OrderResponse))]
    public sealed class MapWarehouseResponseToOrderResponse : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:s0=""http://NWMessaging.DistResp"" xmlns:ns0=""http://NWMessaging.OrderResponse"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:WarehouseResponse"" />
  </xsl:template>
  <xsl:template match=""/s0:WarehouseResponse"">
    <ns0:OrderResponse>
      <CustomerPONumber>
        <xsl:value-of select=""CustomerPONumber/text()"" />
      </CustomerPONumber>
      <Expected_x0020_Date>
        <xsl:value-of select=""DeliveryDate/text()"" />
      </Expected_x0020_Date>
      <Status>
        <xsl:value-of select=""Status/text()"" />
      </Status>
    </ns0:OrderResponse>
  </xsl:template>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"NWMessaging.DistResp";
        
        private const global::NWMessaging.DistResp _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"NWMessaging.OrderResponse";
        
        private const global::NWMessaging.OrderResponse _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"NWMessaging.DistResp";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"NWMessaging.OrderResponse";
                return _TrgSchemas;
            }
        }
    }
}
