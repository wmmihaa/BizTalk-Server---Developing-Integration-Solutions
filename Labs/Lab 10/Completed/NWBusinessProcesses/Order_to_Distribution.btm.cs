namespace NWBusinessProcesses {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"NWMessaging.CustomerOrder", typeof(NWMessaging.CustomerOrder))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"NWBusinessProcesses.DistributorService_northwind_com_services_DistributorService+ReserveDistributor", typeof(NWBusinessProcesses.DistributorService_northwind_com_services_DistributorService.ReserveDistributor))]
    public sealed class Order_to_Distribution : Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 s1"" version=""1.0"" xmlns:ns0=""http://northwind.com/services/DistributorService"" xmlns:s0=""http://NWMessaging.ShippingAddress"" xmlns:s1=""http://NWMessaging.CustomerOrder"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s1:CustomerOrder"" />
  </xsl:template>
  <xsl:template match=""/s1:CustomerOrder"">
    <ns0:ReserveDistributor>
      <ns0:msg>
        <ns0:City>
          <xsl:value-of select=""s0:ShippingAddress/City/text()"" />
        </ns0:City>
        <ns0:Country>
          <xsl:value-of select=""s0:ShippingAddress/Country/text()"" />
        </ns0:Country>
        <ns0:FreightAmount>
          <xsl:value-of select=""FreightAmount/text()"" />
        </ns0:FreightAmount>
        <ns0:OrderId>
          <xsl:value-of select=""CustomerPONumber/text()"" />
        </ns0:OrderId>
        <ns0:State>
          <xsl:value-of select=""s0:ShippingAddress/State/text()"" />
        </ns0:State>
        <ns0:Street>
          <xsl:value-of select=""s0:ShippingAddress/Street/text()"" />
        </ns0:Street>
      </ns0:msg>
    </ns0:ReserveDistributor>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"NWMessaging.CustomerOrder";
        
        private const NWMessaging.CustomerOrder _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"NWBusinessProcesses.DistributorService_northwind_com_services_DistributorService+ReserveDistributor";
        
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
                _SrcSchemas[0] = @"NWMessaging.CustomerOrder";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"NWBusinessProcesses.DistributorService_northwind_com_services_DistributorService+ReserveDistributor";
                return _TrgSchemas;
            }
        }
    }
}
