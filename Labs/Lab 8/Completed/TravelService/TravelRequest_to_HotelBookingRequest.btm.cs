namespace TravelService {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"TravelService.TravelRequest", typeof(global::TravelService.TravelRequest))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"TravelService.HotelBookingService_tempuri_org+SendHotelBookingRequest", typeof(global::TravelService.HotelBookingService_tempuri_org.SendHotelBookingRequest))]
    public sealed class TravelRequest_to_HotelBookingRequest : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:ns0=""http://tempuri.org/"" xmlns:ns1=""http://schemas.datacontract.org/2004/07/HotelBookingService"" xmlns:s0=""http://TravelService.TravelRequest"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:TravelRequest"" />
  </xsl:template>
  <xsl:template match=""/s0:TravelRequest"">
    <ns0:SendHotelBookingRequest>
      <ns0:hotelBookingRequest>
        <ns1:CreditCardNumber>
          <xsl:value-of select=""CreditCardNumber/text()"" />
        </ns1:CreditCardNumber>
        <ns1:Customer>
          <xsl:value-of select=""Customer/text()"" />
        </ns1:Customer>
        <ns1:FromDate>
          <xsl:value-of select=""DepartureDate/text()"" />
        </ns1:FromDate>
        <ns1:Notes>
          <xsl:value-of select=""Notes/text()"" />
        </ns1:Notes>
        <ns1:NumberOfNights>
          <xsl:value-of select=""NumberOfNights/text()"" />
        </ns1:NumberOfNights>
      </ns0:hotelBookingRequest>
    </ns0:SendHotelBookingRequest>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"TravelService.TravelRequest";
        
        private const string _strTrgSchemasList0 = @"TravelService.HotelBookingService_tempuri_org+SendHotelBookingRequest";
        
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
                _SrcSchemas[0] = @"TravelService.TravelRequest";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"TravelService.HotelBookingService_tempuri_org+SendHotelBookingRequest";
                return _TrgSchemas;
            }
        }
    }
}
