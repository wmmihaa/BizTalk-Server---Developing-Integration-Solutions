namespace ErrorHandling
{
    using System;
    using System.Collections.Generic;
    using Microsoft.BizTalk.PipelineOM;
    using Microsoft.BizTalk.Component;
    using Microsoft.BizTalk.Component.Interop;
    
    
    public sealed class XMLValidateReceivePipe : Microsoft.BizTalk.PipelineOM.ReceivePipeline
    {
        
        private const string _strPipeline = "<?xml version=\"1.0\" encoding=\"utf-16\"?><Document xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instanc"+
"e\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" MajorVersion=\"1\" MinorVersion=\"0\">  <Description /> "+
" <CategoryId>f66b9f5e-43ff-4f5f-ba46-885348ae1b4e</CategoryId>  <FriendlyName>Receive</FriendlyName>"+
"  <Stages>    <Stage>      <PolicyFileStage _locAttrData=\"Name\" _locID=\"1\" Name=\"Decode\" minOccurs=\""+
"0\" maxOccurs=\"-1\" execMethod=\"All\" stageId=\"9d0e4103-4cce-4536-83fa-4a5040674ad6\" />      <Component"+
"s />    </Stage>    <Stage>      <PolicyFileStage _locAttrData=\"Name\" _locID=\"2\" Name=\"Disassemble\" "+
"minOccurs=\"0\" maxOccurs=\"-1\" execMethod=\"FirstMatch\" stageId=\"9d0e4105-4cce-4536-83fa-4a5040674ad6\" "+
"/>      <Components>        <Component>          <Name>Microsoft.BizTalk.Component.XmlDasmComp,Micro"+
"soft.BizTalk.Pipeline.Components, Version=3.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35<"+
"/Name>          <ComponentName>XML disassembler</ComponentName>          <Description>Streaming XML "+
"disassembler</Description>          <Version>1.0</Version>          <Properties>            <Propert"+
"y Name=\"EnvelopeSpecNames\">              <Value xsi:type=\"xsd:string\" />            </Property>     "+
"       <Property Name=\"EnvelopeSpecTargetNamespaces\">              <Value xsi:type=\"xsd:string\" />  "+
"          </Property>            <Property Name=\"DocumentSpecNames\">              <Value xsi:type=\"x"+
"sd:string\">ErrorHandling.ExpenseReportMessageType+ExpenseReport</Value>            </Property>      "+
"      <Property Name=\"DocumentSpecTargetNamespaces\">              <Value xsi:type=\"xsd:string\">http:"+
"//ExpenseReports.ExpenseReport</Value>            </Property>            <Property Name=\"AllowUnreco"+
"gnizedMessage\">              <Value xsi:type=\"xsd:boolean\">false</Value>            </Property>     "+
"       <Property Name=\"ValidateDocument\">              <Value xsi:type=\"xsd:boolean\">true</Value>   "+
"         </Property>            <Property Name=\"AtomicInterchangeProcessing\">              <Value xs"+
"i:type=\"xsd:boolean\">true</Value>            </Property>            <Property Name=\"RecoverableInter"+
"changeProcessing\">              <Value xsi:type=\"xsd:boolean\">false</Value>            </Property>  "+
"          <Property Name=\"HiddenProperties\">              <Value xsi:type=\"xsd:string\">EnvelopeSpecT"+
"argetNamespaces,DocumentSpecTargetNamespaces</Value>            </Property>          </Properties>  "+
"        <CachedDisplayName>XML disassembler</CachedDisplayName>          <CachedIsManaged>true</Cach"+
"edIsManaged>        </Component>      </Components>    </Stage>    <Stage>      <PolicyFileStage _lo"+
"cAttrData=\"Name\" _locID=\"3\" Name=\"Validate\" minOccurs=\"0\" maxOccurs=\"-1\" execMethod=\"All\" stageId=\"9"+
"d0e410d-4cce-4536-83fa-4a5040674ad6\" />      <Components />    </Stage>    <Stage>      <PolicyFileS"+
"tage _locAttrData=\"Name\" _locID=\"4\" Name=\"ResolveParty\" minOccurs=\"0\" maxOccurs=\"-1\" execMethod=\"All"+
"\" stageId=\"9d0e410e-4cce-4536-83fa-4a5040674ad6\" />      <Components />    </Stage>  </Stages></Docu"+
"ment>";
        
        private const string _versionDependentGuid = "9101f4c1-302c-4567-ba16-f01dd45cad6e";
        
        public XMLValidateReceivePipe()
        {
            Microsoft.BizTalk.PipelineOM.Stage stage = this.AddStage(new System.Guid("9d0e4105-4cce-4536-83fa-4a5040674ad6"), Microsoft.BizTalk.PipelineOM.ExecutionMode.firstRecognized);
            IBaseComponent comp0 = Microsoft.BizTalk.PipelineOM.PipelineManager.CreateComponent("Microsoft.BizTalk.Component.XmlDasmComp,Microsoft.BizTalk.Pipeline.Components, Version=3.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35");;
            if (comp0 is IPersistPropertyBag)
            {
                string comp0XmlProperties = "<?xml version=\"1.0\" encoding=\"utf-16\"?><PropertyBag xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-inst"+
"ance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">  <Properties>    <Property Name=\"EnvelopeSpecNam"+
"es\">      <Value xsi:type=\"xsd:string\" />    </Property>    <Property Name=\"EnvelopeSpecTargetNamesp"+
"aces\">      <Value xsi:type=\"xsd:string\" />    </Property>    <Property Name=\"DocumentSpecNames\">   "+
"   <Value xsi:type=\"xsd:string\">ErrorHandling.ExpenseReportMessageType+ExpenseReport</Value>    </Pr"+
"operty>    <Property Name=\"DocumentSpecTargetNamespaces\">      <Value xsi:type=\"xsd:string\">http://E"+
"xpenseReports.ExpenseReport</Value>    </Property>    <Property Name=\"AllowUnrecognizedMessage\">    "+
"  <Value xsi:type=\"xsd:boolean\">false</Value>    </Property>    <Property Name=\"ValidateDocument\">  "+
"    <Value xsi:type=\"xsd:boolean\">true</Value>    </Property>    <Property Name=\"AtomicInterchangePr"+
"ocessing\">      <Value xsi:type=\"xsd:boolean\">true</Value>    </Property>    <Property Name=\"Recover"+
"ableInterchangeProcessing\">      <Value xsi:type=\"xsd:boolean\">false</Value>    </Property>    <Prop"+
"erty Name=\"HiddenProperties\">      <Value xsi:type=\"xsd:string\">EnvelopeSpecTargetNamespaces,Documen"+
"tSpecTargetNamespaces</Value>    </Property>  </Properties></PropertyBag>";
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
