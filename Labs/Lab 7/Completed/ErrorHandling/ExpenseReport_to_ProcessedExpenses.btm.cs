namespace ErrorHandling {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ErrorHandling.ExpenseReportMessageType+ExpenseReport", typeof(global::ErrorHandling.ExpenseReportMessageType.ExpenseReport))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ErrorHandling.ProcessedExpenses", typeof(global::ErrorHandling.ProcessedExpenses))]
    public sealed class ExpenseReport_to_ProcessedExpenses : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:s0=""http://ExpenseReports.ExpenseReport"" xmlns:ns0=""http://ErrorHandling.ProcessedExpenses"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:ExpenseReport"" />
  </xsl:template>
  <xsl:template match=""/s0:ExpenseReport"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(string(s0:Employee/s0:FirstName/text()) , &quot; &quot; , string(s0:Employee/s0:LastName/text()))"" />
    <ns0:Expenses>
      <ProcessedExpenses>
        <Name>
          <xsl:value-of select=""$var:v1"" />
        </Name>
        <Status>
          <xsl:value-of select=""s0:Header/s0:Status/text()"" />
        </Status>
        <SubmissionDate>
          <xsl:value-of select=""s0:Header/s0:SubmissionDate/text()"" />
        </SubmissionDate>
      </ProcessedExpenses>
      <TotalExpenses>
        <xsl:value-of select=""s0:TotalExpenses/text()"" />
      </TotalExpenses>
      <Explaination>
        <xsl:value-of select=""s0:Header/text()"" />
      </Explaination>
    </ns0:Expenses>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringConcat(string param0, string param1, string param2)
{
   return param0 + param1 + param2;
}



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"ErrorHandling.ExpenseReportMessageType+ExpenseReport";
        
        private const string _strTrgSchemasList0 = @"ErrorHandling.ProcessedExpenses";
        
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
                _SrcSchemas[0] = @"ErrorHandling.ExpenseReportMessageType+ExpenseReport";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"ErrorHandling.ProcessedExpenses";
                return _TrgSchemas;
            }
        }
    }
}
