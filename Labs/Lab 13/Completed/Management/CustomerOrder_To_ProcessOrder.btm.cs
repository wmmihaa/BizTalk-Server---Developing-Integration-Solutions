namespace Management {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Management.CustomerOrder", typeof(global::Management.CustomerOrder))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Management.ProcessOrder", typeof(global::Management.ProcessOrder))]
    public sealed class CustomerOrder_To_ProcessOrder : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:s0=""http://Management.CustomerOrder"" xmlns:ns0=""http://Management.ProcessOrder"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:CustomerOrder"" />
  </xsl:template>
  <xsl:template match=""/s0:CustomerOrder"">
    <xsl:variable name=""var:v1"" select=""userCSharp:DateCurrentDate()"" />
    <ns0:ProcessOrder>
      <OrderInfo>
        <POId>
          <xsl:value-of select=""CustomerPONumber/text()"" />
        </POId>
        <OrderDate>
          <xsl:value-of select=""CreatedDate/text()"" />
        </OrderDate>
        <SalesRepID>
          <xsl:value-of select=""SalesOrderReferenceID/text()"" />
        </SalesRepID>
        <Quote>
          <xsl:value-of select=""QuoteReferenceID/text()"" />
        </Quote>
        <ProcessDate>
          <xsl:value-of select=""$var:v1"" />
        </ProcessDate>
      </OrderInfo>
      <CustomerInfo>
        <xsl:attribute name=""Title"">
          <xsl:value-of select=""Title/text()"" />
        </xsl:attribute>
        <xsl:attribute name=""FirstName"">
          <xsl:value-of select=""FirstName/text()"" />
        </xsl:attribute>
        <xsl:attribute name=""LastName"">
          <xsl:value-of select=""LastName/text()"" />
        </xsl:attribute>
        <Address>
          <Street>
            <xsl:value-of select=""Address/Street/text()"" />
          </Street>
          <City>
            <xsl:value-of select=""Address/City/text()"" />
          </City>
          <State>
            <xsl:value-of select=""Address/State/text()"" />
          </State>
          <Zip>
            <xsl:value-of select=""Address/Zip/text()"" />
          </Zip>
        </Address>
        <PhoneNumber>
          <xsl:value-of select=""CustomerContact/text()"" />
        </PhoneNumber>
      </CustomerInfo>
      <Items>
        <ItemInfo>
          <ProductNumber>
            <xsl:value-of select=""Lines/SalesOrderLine/ItemID/text()"" />
          </ProductNumber>
          <Qty>
            <xsl:value-of select=""Lines/SalesOrderLine/Quantity/text()"" />
          </Qty>
          <Price>
            <xsl:value-of select=""Lines/SalesOrderLine/UnitPrice/text()"" />
          </Price>
        </ItemInfo>
      </Items>
      <Comment>
        <xsl:value-of select=""Comments/text()"" />
      </Comment>
      <xsl:variable name=""var:v2"" select=""userCSharp:InitCumulativeSum(0)"" />
      <xsl:for-each select=""/s0:CustomerOrder/Lines/SalesOrderLine/UnitPrice"">
        <xsl:variable name=""var:v3"" select=""userCSharp:MathMultiply(string(./text()) , string(../Quantity/text()))"" />
        <xsl:variable name=""var:v4"" select=""userCSharp:AddToCumulativeSum(0,string($var:v3),&quot;1000&quot;)"" />
      </xsl:for-each>
      <xsl:variable name=""var:v5"" select=""userCSharp:GetCumulativeSum(0)"" />
      <Total>
        <xsl:value-of select=""$var:v5"" />
      </Total>
      <Priority>
        <xsl:value-of select=""Priority/text()"" />
      </Priority>
      <Status>
        <xsl:value-of select=""Status/text()"" />
      </Status>
    </ns0:ProcessOrder>
  </xsl:template>
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


public string DateCurrentDate()
{
	DateTime dt = DateTime.Now;
	return dt.ToString(""yyyy-MM-dd"", System.Globalization.CultureInfo.InvariantCulture);
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
        
        private const string _strSrcSchemasList0 = @"Management.CustomerOrder";
        
        private const string _strTrgSchemasList0 = @"Management.ProcessOrder";
        
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
                _SrcSchemas[0] = @"Management.CustomerOrder";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"Management.ProcessOrder";
                return _TrgSchemas;
            }
        }
    }
}
