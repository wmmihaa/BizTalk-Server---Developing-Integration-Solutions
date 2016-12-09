namespace NWBusinessProcesses {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"NWMessaging.CustomerOrder", typeof(NWMessaging.CustomerOrder))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"NWBusinessProcesses.StaffService_northwind_com_services_StaffService+ReserveStaff", typeof(NWBusinessProcesses.StaffService_northwind_com_services_StaffService.ReserveStaff))]
    public sealed class Order_to_StaffRequest : Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 s1"" version=""1.0"" xmlns:ns0=""http://northwind.com/services/StaffService"" xmlns:s0=""http://NWMessaging.ShippingAddress"" xmlns:s1=""http://NWMessaging.CustomerOrder"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s1:CustomerOrder"" />
  </xsl:template>
  <xsl:template match=""/s1:CustomerOrder"">
    <ns0:ReserveStaff>
      <ns0:msg>
        <ns0:Items>
          <xsl:for-each select=""Lines/SalesOrderLine"">
            <ns0:ItemData>
              <ns0:ItemId>
                <xsl:value-of select=""ItemID/text()"" />
              </ns0:ItemId>
              <ns0:Quantity>
                <xsl:value-of select=""Quantity/text()"" />
              </ns0:Quantity>
            </ns0:ItemData>
          </xsl:for-each>
        </ns0:Items>
        <ns0:OrderId>
          <xsl:value-of select=""CustomerPONumber/text()"" />
        </ns0:OrderId>
      </ns0:msg>
    </ns0:ReserveStaff>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"NWMessaging.CustomerOrder";
        
        private const NWMessaging.CustomerOrder _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"NWBusinessProcesses.StaffService_northwind_com_services_StaffService+ReserveStaff";
        
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
                _TrgSchemas[0] = @"NWBusinessProcesses.StaffService_northwind_com_services_StaffService+ReserveStaff";
                return _TrgSchemas;
            }
        }
    }
}
