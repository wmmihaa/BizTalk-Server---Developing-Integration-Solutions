namespace NWMessaging
{
    using System;
    using System.Collections.Generic;
    using Microsoft.BizTalk.PipelineOM;
    using Microsoft.BizTalk.Component;
    using Microsoft.BizTalk.Component.Interop;
    
    
    public sealed class ReceiveEncryptedPurchaseOrder : Microsoft.BizTalk.PipelineOM.ReceivePipeline
    {
        
        private const string _strPipeline = "<?xml version=\"1.0\" encoding=\"utf-16\"?><Document xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instanc"+
"e\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" MajorVersion=\"1\" MinorVersion=\"0\">  <Description /> "+
" <CategoryId>f66b9f5e-43ff-4f5f-ba46-885348ae1b4e</CategoryId>  <FriendlyName>Receive</FriendlyName>"+
"  <Stages>    <Stage>      <PolicyFileStage _locAttrData=\"Name\" _locID=\"1\" Name=\"Decode\" minOccurs=\""+
"0\" maxOccurs=\"-1\" execMethod=\"All\" stageId=\"9d0e4103-4cce-4536-83fa-4a5040674ad6\" />      <Component"+
"s>        <Component>          <Name>Microsoft.BizTalk.Component.MIME_SMIME_Decoder,Microsoft.BizTal"+
"k.Pipeline.Components, Version=3.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35</Name>     "+
"     <ComponentName>MIME/SMIME decoder</ComponentName>          <Description>MIME/SMIME decoder comp"+
"onent.</Description>          <Version>1.0</Version>          <Properties>            <Property Name"+
"=\"AllowNonMIMEMessage\">              <Value xsi:type=\"xsd:boolean\">false</Value>            </Proper"+
"ty>            <Property Name=\"ValidateCRL\">              <Value xsi:type=\"xsd:boolean\">false</Value"+
">            </Property>            <Property Name=\"BodyPartContentType\" />            <Property Nam"+
"e=\"BodyPartIndex\">              <Value xsi:type=\"xsd:unsignedInt\">0</Value>            </Property>  "+
"        </Properties>          <CachedDisplayName>MIME/SMIME decoder</CachedDisplayName>          <C"+
"achedIsManaged>true</CachedIsManaged>        </Component>      </Components>    </Stage>    <Stage> "+
"     <PolicyFileStage _locAttrData=\"Name\" _locID=\"2\" Name=\"Disassemble\" minOccurs=\"0\" maxOccurs=\"-1\""+
" execMethod=\"FirstMatch\" stageId=\"9d0e4105-4cce-4536-83fa-4a5040674ad6\" />      <Components>        "+
"<Component>          <Name>Microsoft.BizTalk.Component.XmlDasmComp,Microsoft.BizTalk.Pipeline.Compon"+
"ents, Version=3.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35</Name>          <ComponentNa"+
"me>XML disassembler</ComponentName>          <Description>Streaming XML disassembler</Description>  "+
"        <Version>1.0</Version>          <Properties>            <Property Name=\"EnvelopeSpecNames\"> "+
"             <Value xsi:type=\"xsd:string\" />            </Property>            <Property Name=\"Envel"+
"opeSpecTargetNamespaces\">              <Value xsi:type=\"xsd:string\" />            </Property>       "+
"     <Property Name=\"DocumentSpecNames\">              <Value xsi:type=\"xsd:string\" />            </P"+
"roperty>            <Property Name=\"DocumentSpecTargetNamespaces\">              <Value xsi:type=\"xsd"+
":string\" />            </Property>            <Property Name=\"AllowUnrecognizedMessage\">            "+
"  <Value xsi:type=\"xsd:boolean\">false</Value>            </Property>            <Property Name=\"Vali"+
"dateDocument\">              <Value xsi:type=\"xsd:boolean\">false</Value>            </Property>      "+
"      <Property Name=\"RecoverableInterchangeProcessing\">              <Value xsi:type=\"xsd:boolean\">"+
"false</Value>            </Property>            <Property Name=\"HiddenProperties\">              <Val"+
"ue xsi:type=\"xsd:string\">EnvelopeSpecTargetNamespaces,DocumentSpecTargetNamespaces</Value>          "+
"  </Property>          </Properties>          <CachedDisplayName>XML disassembler</CachedDisplayName"+
">          <CachedIsManaged>true</CachedIsManaged>        </Component>      </Components>    </Stage"+
">    <Stage>      <PolicyFileStage _locAttrData=\"Name\" _locID=\"3\" Name=\"Validate\" minOccurs=\"0\" maxO"+
"ccurs=\"-1\" execMethod=\"All\" stageId=\"9d0e410d-4cce-4536-83fa-4a5040674ad6\" />      <Components>     "+
"   <Component>          <Name>Microsoft.BizTalk.Component.XmlValidator,Microsoft.BizTalk.Pipeline.Co"+
"mponents, Version=3.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35</Name>          <Compone"+
"ntName>XML validator</ComponentName>          <Description>XML validator component.</Description>   "+
"       <Version>1.0</Version>          <Properties>            <Property Name=\"DocumentSpecName\">   "+
"           <Value xsi:type=\"xsd:string\">NWMessaging.CustomerOrder</Value>            </Property>    "+
"        <Property Name=\"DocumentSpecTargetNamespaces\">              <Value xsi:type=\"xsd:string\">htt"+
"p://NWMessaging.CustomerOrder</Value>            </Property>            <Property Name=\"HiddenProper"+
"ties\">              <Value xsi:type=\"xsd:string\">DocumentSpecTargetNamespaces</Value>            </P"+
"roperty>            <Property Name=\"RecoverableInterchangeProcessing\">              <Value xsi:type="+
"\"xsd:boolean\">false</Value>            </Property>          </Properties>          <CachedDisplayNam"+
"e>XML validator</CachedDisplayName>          <CachedIsManaged>true</CachedIsManaged>        </Compon"+
"ent>      </Components>    </Stage>    <Stage>      <PolicyFileStage _locAttrData=\"Name\" _locID=\"4\" "+
"Name=\"ResolveParty\" minOccurs=\"0\" maxOccurs=\"-1\" execMethod=\"All\" stageId=\"9d0e410e-4cce-4536-83fa-4"+
"a5040674ad6\" />      <Components />    </Stage>  </Stages></Document>";
        
        private const string _versionDependentGuid = "d6f1f4d2-ae23-40c8-9b7b-a827eb4d3c8f";
        
        public ReceiveEncryptedPurchaseOrder()
        {
            Microsoft.BizTalk.PipelineOM.Stage stage = this.AddStage(new System.Guid("9d0e4103-4cce-4536-83fa-4a5040674ad6"), Microsoft.BizTalk.PipelineOM.ExecutionMode.all);
            IBaseComponent comp0 = Microsoft.BizTalk.PipelineOM.PipelineManager.CreateComponent("Microsoft.BizTalk.Component.MIME_SMIME_Decoder,Microsoft.BizTalk.Pipeline.Components, Version=3.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35");;
            if (comp0 is IPersistPropertyBag)
            {
                string comp0XmlProperties = "<?xml version=\"1.0\" encoding=\"utf-16\"?><PropertyBag xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-inst"+
"ance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">  <Properties>    <Property Name=\"AllowNonMIMEMes"+
"sage\">      <Value xsi:type=\"xsd:boolean\">false</Value>    </Property>    <Property Name=\"ValidateCR"+
"L\">      <Value xsi:type=\"xsd:boolean\">false</Value>    </Property>    <Property Name=\"BodyPartConte"+
"ntType\" />    <Property Name=\"BodyPartIndex\">      <Value xsi:type=\"xsd:unsignedInt\">0</Value>    </"+
"Property>  </Properties></PropertyBag>";
                PropertyBag pb = PropertyBag.DeserializeFromXml(comp0XmlProperties);;
                ((IPersistPropertyBag)(comp0)).Load(pb, 0);
            }
            this.AddComponent(stage, comp0);
            stage = this.AddStage(new System.Guid("9d0e4105-4cce-4536-83fa-4a5040674ad6"), Microsoft.BizTalk.PipelineOM.ExecutionMode.firstRecognized);
            IBaseComponent comp1 = Microsoft.BizTalk.PipelineOM.PipelineManager.CreateComponent("Microsoft.BizTalk.Component.XmlDasmComp,Microsoft.BizTalk.Pipeline.Components, Version=3.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35");;
            if (comp1 is IPersistPropertyBag)
            {
                string comp1XmlProperties = "<?xml version=\"1.0\" encoding=\"utf-16\"?><PropertyBag xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-inst"+
"ance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">  <Properties>    <Property Name=\"EnvelopeSpecNam"+
"es\">      <Value xsi:type=\"xsd:string\" />    </Property>    <Property Name=\"EnvelopeSpecTargetNamesp"+
"aces\">      <Value xsi:type=\"xsd:string\" />    </Property>    <Property Name=\"DocumentSpecNames\">   "+
"   <Value xsi:type=\"xsd:string\" />    </Property>    <Property Name=\"DocumentSpecTargetNamespaces\"> "+
"     <Value xsi:type=\"xsd:string\" />    </Property>    <Property Name=\"AllowUnrecognizedMessage\">   "+
"   <Value xsi:type=\"xsd:boolean\">false</Value>    </Property>    <Property Name=\"ValidateDocument\"> "+
"     <Value xsi:type=\"xsd:boolean\">false</Value>    </Property>    <Property Name=\"RecoverableInterc"+
"hangeProcessing\">      <Value xsi:type=\"xsd:boolean\">false</Value>    </Property>    <Property Name="+
"\"HiddenProperties\">      <Value xsi:type=\"xsd:string\">EnvelopeSpecTargetNamespaces,DocumentSpecTarge"+
"tNamespaces</Value>    </Property>  </Properties></PropertyBag>";
                PropertyBag pb = PropertyBag.DeserializeFromXml(comp1XmlProperties);;
                ((IPersistPropertyBag)(comp1)).Load(pb, 0);
            }
            this.AddComponent(stage, comp1);
            stage = this.AddStage(new System.Guid("9d0e410d-4cce-4536-83fa-4a5040674ad6"), Microsoft.BizTalk.PipelineOM.ExecutionMode.all);
            IBaseComponent comp2 = Microsoft.BizTalk.PipelineOM.PipelineManager.CreateComponent("Microsoft.BizTalk.Component.XmlValidator,Microsoft.BizTalk.Pipeline.Components, Version=3.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35");;
            if (comp2 is IPersistPropertyBag)
            {
                string comp2XmlProperties = "<?xml version=\"1.0\" encoding=\"utf-16\"?><PropertyBag xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-inst"+
"ance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">  <Properties>    <Property Name=\"DocumentSpecNam"+
"e\">      <Value xsi:type=\"xsd:string\">NWMessaging.CustomerOrder</Value>    </Property>    <Property "+
"Name=\"DocumentSpecTargetNamespaces\">      <Value xsi:type=\"xsd:string\">http://NWMessaging.CustomerOr"+
"der</Value>    </Property>    <Property Name=\"HiddenProperties\">      <Value xsi:type=\"xsd:string\">D"+
"ocumentSpecTargetNamespaces</Value>    </Property>    <Property Name=\"RecoverableInterchangeProcessi"+
"ng\">      <Value xsi:type=\"xsd:boolean\">false</Value>    </Property>  </Properties></PropertyBag>";
                PropertyBag pb = PropertyBag.DeserializeFromXml(comp2XmlProperties);;
                ((IPersistPropertyBag)(comp2)).Load(pb, 0);
            }
            this.AddComponent(stage, comp2);
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
