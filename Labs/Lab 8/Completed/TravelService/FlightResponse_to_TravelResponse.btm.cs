namespace TravelService {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"TravelService.FlightBookingService_tempuri_org+SendFlightBookingRequestResponse", typeof(global::TravelService.FlightBookingService_tempuri_org.SendFlightBookingRequestResponse))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"TravelService.TravelResponse", typeof(global::TravelService.TravelResponse))]
    public sealed class FlightResponse_to_TravelResponse : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 s1"" version=""1.0"" xmlns:s1=""http://tempuri.org/"" xmlns:s0=""http://schemas.datacontract.org/2004/07/FlightBookingService"" xmlns:ns0=""http://TravelService.TravelResponse"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s1:SendFlightBookingRequestResponse"" />
  </xsl:template>
  <xsl:template match=""/s1:SendFlightBookingRequestResponse"">
    <ns0:TravelResponse>
      <xsl:if test=""s1:SendFlightBookingRequestResult/s0:Approved"">
        <Approved>
          <xsl:value-of select=""s1:SendFlightBookingRequestResult/s0:Approved/text()"" />
        </Approved>
      </xsl:if>
      <xsl:if test=""s1:SendFlightBookingRequestResult/s0:BookingNotes"">
        <BookingNotes>
          <xsl:value-of select=""s1:SendFlightBookingRequestResult/s0:BookingNotes/text()"" />
        </BookingNotes>
      </xsl:if>
      <xsl:if test=""s1:SendFlightBookingRequestResult/s0:AmountCharged"">
        <AmountCharged>
          <xsl:value-of select=""s1:SendFlightBookingRequestResult/s0:AmountCharged/text()"" />
        </AmountCharged>
      </xsl:if>
    </ns0:TravelResponse>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"TravelService.FlightBookingService_tempuri_org+SendFlightBookingRequestResponse";
        
        private const string _strTrgSchemasList0 = @"TravelService.TravelResponse";
        
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
                _SrcSchemas[0] = @"TravelService.FlightBookingService_tempuri_org+SendFlightBookingRequestResponse";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"TravelService.TravelResponse";
                return _TrgSchemas;
            }
        }
    }
}
