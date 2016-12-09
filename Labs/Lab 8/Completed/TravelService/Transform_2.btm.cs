namespace TravelService {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"TravelService.FlightBookingService_tempuri_org+SendFlightBookingRequestResponse", typeof(global::TravelService.FlightBookingService_tempuri_org.SendFlightBookingRequestResponse))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"TravelService.HotelBookingService_tempuri_org+SendHotelBookingRequestResponse", typeof(global::TravelService.HotelBookingService_tempuri_org.SendHotelBookingRequestResponse))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"TravelService.TravelResponse", typeof(global::TravelService.TravelResponse))]
    public sealed class Transform_2 : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s1 s0 s3 s2 userCSharp"" version=""1.0"" xmlns:s1=""http://tempuri.org/"" xmlns:s0=""http://schemas.microsoft.com/BizTalk/2003/aggschema"" xmlns:s2=""http://schemas.datacontract.org/2004/07/HotelBookingService"" xmlns:s3=""http://schemas.datacontract.org/2004/07/FlightBookingService"" xmlns:ns0=""http://TravelService.TravelResponse"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Root"" />
  </xsl:template>
  <xsl:template match=""/s0:Root"">
    <xsl:variable name=""var:v2"" select=""userCSharp:StringConcat(&quot;Flight booking notes:&quot; , string(InputMessagePart_0/s1:SendFlightBookingRequestResponse/s1:SendFlightBookingRequestResult/s3:BookingNotes/text()) , &quot;Hotel booking notes:&quot; , string(InputMessagePart_1/s1:SendHotelBookingRequestResponse/s1:SendHotelBookingRequestResult/s2:BookingNotes/text()))"" />
    <xsl:variable name=""var:v3"" select=""userCSharp:MathAdd(string(InputMessagePart_0/s1:SendFlightBookingRequestResponse/s1:SendFlightBookingRequestResult/s3:AmountCharged/text()) , string(InputMessagePart_1/s1:SendHotelBookingRequestResponse/s1:SendHotelBookingRequestResult/s2:AmountCharged/text()))"" />
    <ns0:TravelResponse>
      <xsl:for-each select=""InputMessagePart_0/s1:SendFlightBookingRequestResponse/s1:SendFlightBookingRequestResult"">
        <xsl:variable name=""var:v1"" select=""userCSharp:LogicalEq(string(s3:Approved/text()) , string(../../../InputMessagePart_1/s1:SendHotelBookingRequestResponse/s1:SendHotelBookingRequestResult/s2:Approved/text()))"" />
        <xsl:if test=""$var:v1"" />
      </xsl:for-each>
      <BookingNotes>
        <xsl:value-of select=""$var:v2"" />
      </BookingNotes>
      <AmountCharged>
        <xsl:value-of select=""$var:v3"" />
      </AmountCharged>
    </ns0:TravelResponse>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public bool LogicalEq(string val1, string val2)
{
	bool ret = false;
	double d1 = 0;
	double d2 = 0;
	if (IsNumeric(val1, ref d1) && IsNumeric(val2, ref d2))
	{
		ret = d1 == d2;
	}
	else
	{
		ret = String.Compare(val1, val2, StringComparison.Ordinal) == 0;
	}
	return ret;
}


public string StringConcat(string param0, string param1, string param2, string param3)
{
   return param0 + param1 + param2 + param3;
}


public string MathAdd(string param0, string param1)
{
	System.Collections.ArrayList listValues = new System.Collections.ArrayList();
	listValues.Add(param0);
	listValues.Add(param1);
	double ret = 0;
	foreach (string obj in listValues)
	{
	double d = 0;
		if (IsNumeric(obj, ref d))
		{
			ret += d;
		}
		else
		{
			return """";
		}
	}
	return ret.ToString(System.Globalization.CultureInfo.InvariantCulture);
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


]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"TravelService.FlightBookingService_tempuri_org+SendFlightBookingRequestResponse";
        
        private const string _strSrcSchemasList1 = @"TravelService.HotelBookingService_tempuri_org+SendHotelBookingRequestResponse";
        
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
                string[] _SrcSchemas = new string [2];
                _SrcSchemas[0] = @"TravelService.FlightBookingService_tempuri_org+SendFlightBookingRequestResponse";
                _SrcSchemas[1] = @"TravelService.HotelBookingService_tempuri_org+SendHotelBookingRequestResponse";
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
