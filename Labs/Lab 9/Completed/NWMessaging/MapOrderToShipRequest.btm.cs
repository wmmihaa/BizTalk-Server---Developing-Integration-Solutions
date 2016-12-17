namespace NWMessaging {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"NWMessaging.CustomerOrder", typeof(global::NWMessaging.CustomerOrder))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"NWMessaging.WarehouseShipRequest", typeof(global::NWMessaging.WarehouseShipRequest))]
    public sealed class MapOrderToShipRequest : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s1 s0"" version=""1.0"" xmlns:s1=""http://NWMessaging.CustomerOrder"" xmlns:ns0=""http://NWMessaging.WarehouseShipRequest"" xmlns:s0=""http://NWMessaging.ShippingAddress"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s1:CustomerOrder"" />
  </xsl:template>
  <xsl:template match=""/s1:CustomerOrder"">
    <ns0:ShipRequest>
      <CustomerOrderNumber>
        <xsl:value-of select=""CustomerPONumber/text()"" />
      </CustomerOrderNumber>
    </ns0:ShipRequest>
  </xsl:template>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"NWMessaging.CustomerOrder";
        
        private const global::NWMessaging.CustomerOrder _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"NWMessaging.WarehouseShipRequest";
        
        private const global::NWMessaging.WarehouseShipRequest _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"NWMessaging.CustomerOrder";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"NWMessaging.WarehouseShipRequest";
                return _TrgSchemas;
            }
        }
    }
}
