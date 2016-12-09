namespace ErrorHandling
{
    using System;
    using System.Collections.Generic;
    using Microsoft.BizTalk.PipelineOM;
    using Microsoft.BizTalk.Component;
    using Microsoft.BizTalk.Component.Interop;
    
    
    public sealed class SendError : Microsoft.BizTalk.PipelineOM.SendPipeline
    {
        
        private const string _strPipeline = "<?xml version=\"1.0\" encoding=\"utf-16\"?><Document xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instanc"+
"e\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" MajorVersion=\"1\" MinorVersion=\"0\">  <Description /> "+
" <CategoryId>8c6b051c-0ff5-4fc2-9ae5-5016cb726282</CategoryId>  <FriendlyName>Transmit</FriendlyName"+
">  <Stages>    <Stage>      <PolicyFileStage _locAttrData=\"Name\" _locID=\"1\" Name=\"Pre-Assemble\" minO"+
"ccurs=\"0\" maxOccurs=\"-1\" execMethod=\"All\" stageId=\"9d0e4101-4cce-4536-83fa-4a5040674ad6\" />      <Co"+
"mponents />    </Stage>    <Stage>      <PolicyFileStage _locAttrData=\"Name\" _locID=\"2\" Name=\"Assemb"+
"le\" minOccurs=\"0\" maxOccurs=\"1\" execMethod=\"All\" stageId=\"9d0e4107-4cce-4536-83fa-4a5040674ad6\" />  "+
"    <Components>        <Component>          <Name>Microsoft.BizTalk.Component.XmlAsmComp,Microsoft."+
"BizTalk.Pipeline.Components, Version=3.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35</Name"+
">          <ComponentName>XML assembler</ComponentName>          <Description>XML assembler componen"+
"t.</Description>          <Version>1.0</Version>          <Properties>            <Property Name=\"En"+
"velopeDocSpecNames\">              <Value xsi:type=\"xsd:string\" />            </Property>            "+
"<Property Name=\"EnvelopeSpecTargetNamespaces\">              <Value xsi:type=\"xsd:string\" />         "+
"   </Property>            <Property Name=\"DocumentSpecNames\">              <Value xsi:type=\"xsd:stri"+
"ng\" />            </Property>            <Property Name=\"DocumentSpecTargetNamespaces\">             "+
" <Value xsi:type=\"xsd:string\" />            </Property>            <Property Name=\"XmlAsmProcessingI"+
"nstructions\">              <Value xsi:type=\"xsd:string\">&lt;?mso-infoPathSolution solutionVersion=\"1"+
".0.0.35\" productVersion=\"11.0.6357\" PIVersion=\"1.0.0.0\" href=\"http://localhost:13016/Failed%20Expens"+
"e%20Reports/Forms/template.xsn\" name=\"urn:schemas-microsoft-com:office:infopath:Expense-Reports:http"+
"---ExpenseReports-ExpenseReport\" language=\"en-us\" ?&gt;&lt;?mso-application progid=\"InfoPath.Documen"+
"t\"?&gt;</Value>            </Property>            <Property Name=\"ProcessingInstructionsOptions\">   "+
"           <Value xsi:type=\"xsd:int\">1</Value>            </Property>            <Property Name=\"Pro"+
"cessingInstructionsScope\">              <Value xsi:type=\"xsd:int\">0</Value>            </Property>  "+
"          <Property Name=\"AddXmlDeclaration\">              <Value xsi:type=\"xsd:boolean\">true</Value"+
">            </Property>            <Property Name=\"TargetCharset\">              <Value xsi:type=\"xs"+
"d:string\" />            </Property>            <Property Name=\"TargetCodePage\">              <Value "+
"xsi:type=\"xsd:int\">0</Value>            </Property>            <Property Name=\"PreserveBom\">        "+
"      <Value xsi:type=\"xsd:boolean\">true</Value>            </Property>            <Property Name=\"H"+
"iddenProperties\">              <Value xsi:type=\"xsd:string\">EnvelopeSpecTargetNamespaces,DocumentSpe"+
"cTargetNamespaces,TargetCodePage</Value>            </Property>          </Properties>          <Cac"+
"hedDisplayName>XML assembler</CachedDisplayName>          <CachedIsManaged>true</CachedIsManaged>   "+
"     </Component>      </Components>    </Stage>    <Stage>      <PolicyFileStage _locAttrData=\"Name"+
"\" _locID=\"3\" Name=\"Encode\" minOccurs=\"0\" maxOccurs=\"-1\" execMethod=\"All\" stageId=\"9d0e4108-4cce-4536"+
"-83fa-4a5040674ad6\" />      <Components />    </Stage>  </Stages></Document>";
        
        private const string _versionDependentGuid = "735e0ed3-84f7-463a-b456-d2a7ad22ac76";
        
        public SendError()
        {
            Microsoft.BizTalk.PipelineOM.Stage stage = this.AddStage(new System.Guid("9d0e4107-4cce-4536-83fa-4a5040674ad6"), Microsoft.BizTalk.PipelineOM.ExecutionMode.all);
            IBaseComponent comp0 = Microsoft.BizTalk.PipelineOM.PipelineManager.CreateComponent("Microsoft.BizTalk.Component.XmlAsmComp,Microsoft.BizTalk.Pipeline.Components, Version=3.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35");;
            if (comp0 is IPersistPropertyBag)
            {
                string comp0XmlProperties = "<?xml version=\"1.0\" encoding=\"utf-16\"?><PropertyBag xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-inst"+
"ance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">  <Properties>    <Property Name=\"EnvelopeDocSpec"+
"Names\">      <Value xsi:type=\"xsd:string\" />    </Property>    <Property Name=\"EnvelopeSpecTargetNam"+
"espaces\">      <Value xsi:type=\"xsd:string\" />    </Property>    <Property Name=\"DocumentSpecNames\">"+
"      <Value xsi:type=\"xsd:string\" />    </Property>    <Property Name=\"DocumentSpecTargetNamespaces"+
"\">      <Value xsi:type=\"xsd:string\" />    </Property>    <Property Name=\"XmlAsmProcessingInstructio"+
"ns\">      <Value xsi:type=\"xsd:string\">&lt;?mso-infoPathSolution solutionVersion=\"1.0.0.35\" productV"+
"ersion=\"11.0.6357\" PIVersion=\"1.0.0.0\" href=\"http://localhost:13016/Failed%20Expense%20Reports/Forms"+
"/template.xsn\" name=\"urn:schemas-microsoft-com:office:infopath:Expense-Reports:http---ExpenseReports"+
"-ExpenseReport\" language=\"en-us\" ?&gt;&lt;?mso-application progid=\"InfoPath.Document\"?&gt;</Value>  "+
"  </Property>    <Property Name=\"ProcessingInstructionsOptions\">      <Value xsi:type=\"xsd:int\">1</V"+
"alue>    </Property>    <Property Name=\"ProcessingInstructionsScope\">      <Value xsi:type=\"xsd:int\""+
">0</Value>    </Property>    <Property Name=\"AddXmlDeclaration\">      <Value xsi:type=\"xsd:boolean\">"+
"true</Value>    </Property>    <Property Name=\"TargetCharset\">      <Value xsi:type=\"xsd:string\" /> "+
"   </Property>    <Property Name=\"TargetCodePage\">      <Value xsi:type=\"xsd:int\">0</Value>    </Pro"+
"perty>    <Property Name=\"PreserveBom\">      <Value xsi:type=\"xsd:boolean\">true</Value>    </Propert"+
"y>    <Property Name=\"HiddenProperties\">      <Value xsi:type=\"xsd:string\">EnvelopeSpecTargetNamespa"+
"ces,DocumentSpecTargetNamespaces,TargetCodePage</Value>    </Property>  </Properties></PropertyBag>";
                PropertyBag pb = PropertyBag.DeserializeFromXml(comp0XmlProperties);;
                ((IPersistPropertyBag)(comp0)).Load(pb, 0);
            }
            this.AddComponent(stage, comp0);
        }
        
        public override string XmlContent
        {
            get
            {
                return _strPipeline;
            }
        }
        
        public override System.Guid VersionDependentGuid
        {
            get
            {
                return new System.Guid(_versionDependentGuid);
            }
        }
    }
}
