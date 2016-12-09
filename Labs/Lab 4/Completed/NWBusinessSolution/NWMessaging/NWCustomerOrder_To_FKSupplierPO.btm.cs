namespace NWMessaging {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"NWMessaging.CustomerOrder", typeof(global::NWMessaging.CustomerOrder))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"FKMessaging.SupplierPO", typeof(global::FKMessaging.SupplierPO))]
    public sealed class NWCustomerOrder_To_FKSupplierPO : global::Microsoft.BizTalk.TestTools.Mapper.TestableMapBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp userVB"" version=""1.0"" xmlns:ns0=""http://FKMessaging.SupplierPO"" xmlns:s0=""http://NWMessaging.CustomerOrder"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"" xmlns:userVB=""http://schemas.microsoft.com/BizTalk/2003/userVB"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:CustomerOrder"" />
  </xsl:template>
  <xsl:template match=""/s0:CustomerOrder"">
    <ns0:PurchaseOrder>
      <PONumber>
        <xsl:value-of select=""CustomerPONumber/text()"" />
      </PONumber>
      <xsl:variable name=""var:v1"" select=""userCSharp:InitCumulativeSum(0)"" />
      <xsl:for-each select=""/s0:CustomerOrder/Lines/SalesOrderLine"">
        <xsl:variable name=""var:v2"" select=""userCSharp:AddToCumulativeSum(0,string(Quantity/text()),&quot;1000&quot;)"" />
      </xsl:for-each>
      <xsl:variable name=""var:v3"" select=""userCSharp:GetCumulativeSum(0)"" />
      <TotalQty>
        <xsl:value-of select=""$var:v3"" />
      </TotalQty>
      <xsl:variable name=""var:v4"" select=""userCSharp:InitCumulativeSum(1)"" />
      <xsl:for-each select=""/s0:CustomerOrder/Lines/SalesOrderLine"">
        <xsl:variable name=""var:v5"" select=""userCSharp:MathMultiply(string(UnitPrice/text()) , string(Quantity/text()))"" />
        <xsl:variable name=""var:v6"" select=""userCSharp:AddToCumulativeSum(1,string($var:v5),&quot;1000&quot;)"" />
      </xsl:for-each>
      <xsl:variable name=""var:v7"" select=""userCSharp:GetCumulativeSum(1)"" />
      <TotalCost>
        <xsl:value-of select=""$var:v7"" />
      </TotalCost>
      <Items>
        <xsl:for-each select=""Lines/SalesOrderLine"">
          <Item>
            <ProdId>
              <xsl:value-of select=""ItemID/text()"" />
            </ProdId>
            <Qty>
              <xsl:value-of select=""Quantity/text()"" />
            </Qty>
            <Cost>
              <xsl:value-of select=""UnitPrice/text()"" />
            </Cost>
          </Item>
        </xsl:for-each>
      </Items>
      <Status>
        <xsl:value-of select=""Status/text()"" />
      </Status>
      <xsl:variable name=""var:v8"" select=""userVB:PriorityConversion(string(Priority/text()))"" />
      <Priority>
        <xsl:value-of select=""$var:v8"" />
      </Priority>
    </ns0:PurchaseOrder>
  </xsl:template>
  <msxsl:script language=""VB"" implements-prefix=""userVB""><![CDATA[
Public Function PriorityConversion(ByVal param1 As String) _
 As String
Select  param1
  Case “1”
    Return “High”
  Case “2”
    Return “Medium”
  Case “3”
    Return “Low”
  Case Else
    Return “Error”
End Select
End Function


]]></msxsl:script>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string InitCumulativeSum(int index)
{
	if (index >= 0)
	{
		if (index >= myCumulativeSumArray.Count)
		{
			int i = myCumulativeSumArray.Count;
			for (; i<=index; i++)
			{
				myCumulativeSumArray.Add("""");
			}
		}
		else
		{
			myCumulativeSumArray[index] = """";
		}
	}
	return """";
}

public System.Collections.ArrayList myCumulativeSumArray = new System.Collections.ArrayList();

public string AddToCumulativeSum(int index, string val, string notused)
{
	if (index < 0 || index >= myCumulativeSumArray.Count)
	{
		return """";
    }
	double d = 0;
	if (IsNumeric(val, ref d))
	{
		if (myCumulativeSumArray[index] == """")
		{
			myCumulativeSumArray[index] = d;
		}
		else
		{
			myCumulativeSumArray[index] = (double)(myCumulativeSumArray[index]) + d;
		}
	}
	return (myCumulativeSumArray[index] is double) ? ((double)myCumulativeSumArray[index]).ToString(System.Globalization.CultureInfo.InvariantCulture) : """";
}

public string GetCumulativeSum(int index)
{
	if (index < 0 || index >= myCumulativeSumArray.Count)
	{
		return """";
	}
	return (myCumulativeSumArray[index] is double) ? ((double)myCumulativeSumArray[index]).ToString(System.Globalization.CultureInfo.InvariantCulture) : """";
}

public string MathMultiply(string param0, string param1)
{
	System.Collections.ArrayList listValues = new System.Collections.ArrayList();
	listValues.Add(param0);
	listValues.Add(param1);
	double ret = 1;
	bool first = true;
	foreach (string obj in listValues)
	{
		double d = 0;
		if (IsNumeric(obj, ref d))
		{
			if (first)
			{
				first = false;
				ret = d;
			}
			else
			{
				ret *= d;
			}
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
        
        private const string _strSrcSchemasList0 = @"NWMessaging.CustomerOrder";
        
        private const string _strTrgSchemasList0 = @"FKMessaging.SupplierPO";
        
        private const global::FKMessaging.SupplierPO _trgSchemaTypeReference0 = null;
        
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
                _TrgSchemas[0] = @"FKMessaging.SupplierPO";
                return _TrgSchemas;
            }
        }
    }
}
