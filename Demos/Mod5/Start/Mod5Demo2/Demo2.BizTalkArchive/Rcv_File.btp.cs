namespace Demo2.BizTalkArchive
{
    using System;
    using System.Collections.Generic;
    using Microsoft.BizTalk.PipelineOM;
    using Microsoft.BizTalk.Component;
    using Microsoft.BizTalk.Component.Interop;
    
    
    public sealed class Rcv_File : Microsoft.BizTalk.PipelineOM.ReceivePipeline
    {
        
        private const string _strPipeline = "<?xml version=\"1.0\" encoding=\"utf-16\"?><Document xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instanc"+
"e\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" MajorVersion=\"1\" MinorVersion=\"0\">  <Description /> "+
" <CategoryId>f66b9f5e-43ff-4f5f-ba46-885348ae1b4e</CategoryId>  <FriendlyName>Receive</FriendlyName>"+
"  <Stages>    <Stage>      <PolicyFileStage _locAttrData=\"Name\" _locID=\"1\" Name=\"Decode\" minOccurs=\""+
"0\" maxOccurs=\"-1\" execMethod=\"All\" stageId=\"9d0e4103-4cce-4536-83fa-4a5040674ad6\" />      <Component"+
"s>        <Component>          <Name>FileArchiveComponent.FileArchive,FileArchive, Version=1.0.0.0, "+
"Culture=neutral, PublicKeyToken=4ee6d40bbf9b517d</Name>          <ComponentName>ForwardOnlyStreaming"+
"</ComponentName>          <Description>Archiving message to disk</Description>          <Version>1.0"+
"</Version>          <Properties>            <Property Name=\"ForwardOnly\">              <Value xsi:ty"+
"pe=\"xsd:boolean\">false</Value>            </Property>            <Property Name=\"ArchiveTo\">        "+
"      <Value xsi:type=\"xsd:string\">C:\\Demos\\Mod5\\FileDrop\\Archive\\</Value>            </Property>   "+
"       </Properties>          <CachedDisplayName>ForwardOnlyStreaming</CachedDisplayName>          <"+
"CachedIsManaged>true</CachedIsManaged>        </Component>      </Components>    </Stage>    <Stage>"+
"      <PolicyFileStage _locAttrData=\"Name\" _locID=\"2\" Name=\"Disassemble\" minOccurs=\"0\" maxOccurs=\"-1"+
"\" execMethod=\"FirstMatch\" stageId=\"9d0e4105-4cce-4536-83fa-4a5040674ad6\" />      <Components />    <"+
"/Stage>    <Stage>      <PolicyFileStage _locAttrData=\"Name\" _locID=\"3\" Name=\"Validate\" minOccurs=\"0"+
"\" maxOccurs=\"-1\" execMethod=\"All\" stageId=\"9d0e410d-4cce-4536-83fa-4a5040674ad6\" />      <Components"+
" />    </Stage>    <Stage>      <PolicyFileStage _locAttrData=\"Name\" _locID=\"4\" Name=\"ResolveParty\" "+
"minOccurs=\"0\" maxOccurs=\"-1\" execMethod=\"All\" stageId=\"9d0e410e-4cce-4536-83fa-4a5040674ad6\" />     "+
" <Components />    </Stage>  </Stages></Document>";
        
        private const string _versionDependentGuid = "2c21d8df-0ee8-43f0-bf24-65a5e062abd9";
        
        public Rcv_File()
        {
            Microsoft.BizTalk.PipelineOM.Stage stage = this.AddStage(new System.Guid("9d0e4103-4cce-4536-83fa-4a5040674ad6"), Microsoft.BizTalk.PipelineOM.ExecutionMode.all);
            IBaseComponent comp0 = Microsoft.BizTalk.PipelineOM.PipelineManager.CreateComponent("FileArchiveComponent.FileArchive,FileArchive, Version=1.0.0.0, Culture=neutral, PublicKeyToken=4ee6d40bbf9b517d");;
            if (comp0 is IPersistPropertyBag)
            {
                string comp0XmlProperties = "<?xml version=\"1.0\" encoding=\"utf-16\"?><PropertyBag xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-inst"+
"ance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">  <Properties>    <Property Name=\"ForwardOnly\">  "+
"    <Value xsi:type=\"xsd:boolean\">false</Value>    </Property>    <Property Name=\"ArchiveTo\">      <"+
"Value xsi:type=\"xsd:string\">C:\\Demos\\Mod5\\FileDrop\\Archive\\</Value>    </Property>  </Properties></P"+
"ropertyBag>";
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
