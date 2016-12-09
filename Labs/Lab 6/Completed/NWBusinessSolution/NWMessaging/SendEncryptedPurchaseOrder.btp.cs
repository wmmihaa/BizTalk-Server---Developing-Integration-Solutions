namespace NWMessaging
{
    using System;
    using System.Collections.Generic;
    using Microsoft.BizTalk.PipelineOM;
    using Microsoft.BizTalk.Component;
    using Microsoft.BizTalk.Component.Interop;
    
    
    public sealed class SendEncryptedPurchaseOrder : Microsoft.BizTalk.PipelineOM.SendPipeline
    {
        
        private const string _strPipeline = "<?xml version=\"1.0\" encoding=\"utf-16\"?><Document xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instanc"+
"e\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" MajorVersion=\"1\" MinorVersion=\"0\">  <Description /> "+
" <CategoryId>8c6b051c-0ff5-4fc2-9ae5-5016cb726282</CategoryId>  <FriendlyName>Transmit</FriendlyName"+
">  <Stages>    <Stage>      <PolicyFileStage _locAttrData=\"Name\" _locID=\"1\" Name=\"Pre-Assemble\" minO"+
"ccurs=\"0\" maxOccurs=\"-1\" execMethod=\"All\" stageId=\"9d0e4101-4cce-4536-83fa-4a5040674ad6\" />      <Co"+
"mponents />    </Stage>    <Stage>      <PolicyFileStage _locAttrData=\"Name\" _locID=\"2\" Name=\"Assemb"+
"le\" minOccurs=\"0\" maxOccurs=\"1\" execMethod=\"All\" stageId=\"9d0e4107-4cce-4536-83fa-4a5040674ad6\" />  "+
"    <Components />    </Stage>    <Stage>      <PolicyFileStage _locAttrData=\"Name\" _locID=\"3\" Name="+
"\"Encode\" minOccurs=\"0\" maxOccurs=\"-1\" execMethod=\"All\" stageId=\"9d0e4108-4cce-4536-83fa-4a5040674ad6"+
"\" />      <Components>        <Component>          <Name>Microsoft.BizTalk.Component.MIME_SMIME_Enco"+
"der,Microsoft.BizTalk.Pipeline.Components, Version=3.0.1.0, Culture=neutral, PublicKeyToken=31bf3856"+
"ad364e35</Name>          <ComponentName>MIME/SMIME encoder</ComponentName>          <Description>MIM"+
"E/SMIME encoder component.</Description>          <Version>1.0</Version>          <Properties>      "+
"      <Property Name=\"SendBodyPartAsAttachment\">              <Value xsi:type=\"xsd:boolean\">true</Va"+
"lue>            </Property>            <Property Name=\"ContentTransferEncoding\">              <Value"+
" xsi:type=\"xsd:string\">base64</Value>            </Property>            <Property Name=\"SignatureTyp"+
"e\">              <Value xsi:type=\"xsd:int\">0</Value>            </Property>            <Property Nam"+
"e=\"EnableEncryption\">              <Value xsi:type=\"xsd:boolean\">false</Value>            </Property"+
">            <Property Name=\"EncryptionAlgorithm\">              <Value xsi:type=\"xsd:int\">0</Value> "+
"           </Property>            <Property Name=\"AddSigningCertToMessage\">              <Value xsi:"+
"type=\"xsd:boolean\">true</Value>            </Property>            <Property Name=\"ValidateCRL\">     "+
"         <Value xsi:type=\"xsd:boolean\">false</Value>            </Property>          </Properties>  "+
"        <CachedDisplayName>MIME/SMIME encoder</CachedDisplayName>          <CachedIsManaged>true</Ca"+
"chedIsManaged>        </Component>      </Components>    </Stage>  </Stages></Document>";
        
        private const string _versionDependentGuid = "cc2003bf-3271-465a-8328-06ce60dabff7";
        
        public SendEncryptedPurchaseOrder()
        {
            Microsoft.BizTalk.PipelineOM.Stage stage = this.AddStage(new System.Guid("9d0e4108-4cce-4536-83fa-4a5040674ad6"), Microsoft.BizTalk.PipelineOM.ExecutionMode.all);
            IBaseComponent comp0 = Microsoft.BizTalk.PipelineOM.PipelineManager.CreateComponent("Microsoft.BizTalk.Component.MIME_SMIME_Encoder,Microsoft.BizTalk.Pipeline.Components, Version=3.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35");;
            if (comp0 is IPersistPropertyBag)
            {
                string comp0XmlProperties = "<?xml version=\"1.0\" encoding=\"utf-16\"?><PropertyBag xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-inst"+
"ance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">  <Properties>    <Property Name=\"SendBodyPartAsA"+
"ttachment\">      <Value xsi:type=\"xsd:boolean\">true</Value>    </Property>    <Property Name=\"Conten"+
"tTransferEncoding\">      <Value xsi:type=\"xsd:string\">base64</Value>    </Property>    <Property Nam"+
"e=\"SignatureType\">      <Value xsi:type=\"xsd:int\">0</Value>    </Property>    <Property Name=\"Enable"+
"Encryption\">      <Value xsi:type=\"xsd:boolean\">false</Value>    </Property>    <Property Name=\"Encr"+
"yptionAlgorithm\">      <Value xsi:type=\"xsd:int\">0</Value>    </Property>    <Property Name=\"AddSign"+
"ingCertToMessage\">      <Value xsi:type=\"xsd:boolean\">true</Value>    </Property>    <Property Name="+
"\"ValidateCRL\">      <Value xsi:type=\"xsd:boolean\">false</Value>    </Property>  </Properties></Prope"+
"rtyBag>";
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
