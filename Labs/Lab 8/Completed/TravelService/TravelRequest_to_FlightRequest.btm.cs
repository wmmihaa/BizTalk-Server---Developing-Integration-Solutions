namespace TravelService {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"TravelService.TravelRequest", typeof(global::TravelService.TravelRequest))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"TravelService.FlightBookingService_tempuri_org+SendFlightBookingRequest", typeof(global::TravelService.FlightBookingService_tempuri_org.SendFlightBookingRequest))]
    public sealed class TravelRequest_to_FlightRequest : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns0=""http://tempuri.org/"" xmlns:ns1=""http://schemas.datacontract.org/2004/07/FlightBookingService"" xmlns:s0=""http://TravelService.TravelRequest"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:TravelRequest"" />
  </xsl:template>
  <xsl:template match=""/s0:TravelRequest"">
    <xsl:variable name=""var:v1"" select=""userCSharp:DateAddDays(string(DepartureDate/text()) , string(NumberOfNights/text()))"" />
    <ns0:SendFlightBookingRequest>
      <ns0:FlightBookingRequest>
        <ns1:CreditCardNumber>
          <xsl:value-of select=""CreditCardNumber/text()"" />
        </ns1:CreditCardNumber>
        <ns1:Customer>
          <xsl:value-of select=""Customer/text()"" />
        </ns1:Customer>
        <ns1:DepartureDate>
          <xsl:value-of select=""DepartureDate/text()"" />
        </ns1:DepartureDate>
        <ns1:DepartureFrom>
          <xsl:value-of select=""DepartureFrom/text()"" />
        </ns1:DepartureFrom>
        <ns1:Destination>
          <xsl:value-of select=""Destination/text()"" />
        </ns1:Destination>
        <ns1:Notes>
          <xsl:value-of select=""Notes/text()"" />
        </ns1:Notes>
        <ns1:ReturnDate>
          <xsl:value-of select=""$var:v1"" />
        </ns1:ReturnDate>
      </ns0:FlightBookingRequest>
    </ns0:SendFlightBookingRequest>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string DateAddDays(string date, string days)
{
	string retval = """";
	double db = 0;
	if (IsDate(date) && IsNumeric(days, ref db))
	{
		DateTime dt = DateTime.Parse(date);
		int d = (int) db;
		dt = dt.AddDays(d);
		retval = dt.ToString(""yyyy-MM-dd"", System.Globalization.CultureInfo.InvariantCulture);
	}
	return retval;
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

public bool IsDate(string val)
{
	bool retval = true;
	try
	{
		DateTime dt = Convert.ToDateTime(val, System.Globalization.CultureInfo.InvariantCulture);
	}
	catch (Exception)
	{
		retval = false;
	}
	return retval;
}


]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"TravelService.TravelRequest";
        
        private const string _strTrgSchemasList0 = @"TravelService.FlightBookingService_tempuri_org+SendFlightBookingRequest";
        
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
                _TrgSchemas[0] = @"TravelService.FlightBookingService_tempuri_org+SendFlightBookingRequest";
                return _TrgSchemas;
            }
        }
    }
}
