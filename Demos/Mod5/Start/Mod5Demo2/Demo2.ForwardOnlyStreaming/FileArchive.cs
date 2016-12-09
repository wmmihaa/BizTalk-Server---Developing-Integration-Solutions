namespace FileArchiveComponent
{
    using System;
    using System.IO;
    using System.Text;
    using System.Drawing;
    using System.Resources;
    using System.Reflection;
    using System.Diagnostics;
    using System.Collections;
    using System.ComponentModel;
    using Microsoft.BizTalk.Message.Interop;
    using Microsoft.BizTalk.Component.Interop;
    using Microsoft.BizTalk.Component;
    using Microsoft.BizTalk.Messaging;
    
    [ComponentCategory(CategoryTypes.CATID_PipelineComponent)]
    [System.Runtime.InteropServices.Guid("25e6817a-d3e3-4557-88ed-b369c6e0e149")]
    [ComponentCategory(CategoryTypes.CATID_Any)]
    public class FileArchive : Microsoft.BizTalk.Component.Interop.IComponent, IBaseComponent, IPersistPropertyBag, IComponentUI
    {
        #region Members
        private System.Resources.ResourceManager resourceManager = new System.Resources.ResourceManager("FileArchiveComponent.FileArchive", Assembly.GetExecutingAssembly());

        public string ArchiveTo
        {
            get
            {
                return _ArchiveTo;
            }
            set
            {
                _ArchiveTo = value;
            }
        } 
        public bool ForwardOnly
        {
            get
            {
                return _ForwardOnly;
            }
            set
            {
                _ForwardOnly = value;
            }
        }
       
        FileStream _fileSteam;
        private string _ArchiveTo;
        private bool _ForwardOnly;
        
        #endregion

        #region IBaseComponent members
        /// <summary>
        /// Name of the component
        /// </summary>
        [Browsable(false)]
        public string Name
        {
            get
            {
                return resourceManager.GetString("COMPONENTNAME", System.Globalization.CultureInfo.InvariantCulture);
            }
        }
        
        /// <summary>
        /// Version of the component
        /// </summary>
        [Browsable(false)]
        public string Version
        {
            get
            {
                return resourceManager.GetString("COMPONENTVERSION", System.Globalization.CultureInfo.InvariantCulture);
            }
        }
        
        /// <summary>
        /// Description of the component
        /// </summary>
        [Browsable(false)]
        public string Description
        {
            get
            {
                return resourceManager.GetString("COMPONENTDESCRIPTION", System.Globalization.CultureInfo.InvariantCulture);
            }
        }
        #endregion
        
        #region IPersistPropertyBag members
        /// <summary>
        /// Gets class ID of component for usage from unmanaged code.
        /// </summary>
        /// <param name="classid">
        /// Class ID of the component
        /// </param>
        public void GetClassID(out System.Guid classid)
        {
            classid = new System.Guid("25e6817a-d3e3-4557-88ed-b369c6e0e149");
        }
        
        /// <summary>
        /// not implemented
        /// </summary>
        public void InitNew()
        {
        }
        
        /// <summary>
        /// Loads configuration properties for the component
        /// </summary>
        /// <param name="pb">Configuration property bag</param>
        /// <param name="errlog">Error status</param>
        public virtual void Load(IPropertyBag pb, int errlog)
        {
            object val = null;
            val = this.ReadPropertyBag(pb, "ForwardOnly");
            if ((val != null))
            {
                this._ForwardOnly = ((bool)(val));
            }
            val = this.ReadPropertyBag(pb, "ArchiveTo");
            if ((val != null))
            {
                this._ArchiveTo = ((string)(val));
            }
        }
        
        /// <summary>
        /// Saves the current component configuration into the property bag
        /// </summary>
        /// <param name="pb">Configuration property bag</param>
        /// <param name="fClearDirty">not used</param>
        /// <param name="fSaveAllProperties">not used</param>
        public virtual void Save(IPropertyBag pb, bool fClearDirty, bool fSaveAllProperties)
        {
            this.WritePropertyBag(pb, "ForwardOnly", this.ForwardOnly);
            this.WritePropertyBag(pb, "ArchiveTo", this.ArchiveTo);
        }
        
        #region utility functionality
        /// <summary>
        /// Reads property value from property bag
        /// </summary>
        /// <param name="pb">Property bag</param>
        /// <param name="propName">Name of property</param>
        /// <returns>Value of the property</returns>
        private object ReadPropertyBag(IPropertyBag pb, string propName)
        {
            object val = null;
            try
            {
                pb.Read(propName, out val, 0);
            }
            catch (System.ArgumentException )
            {
                return val;
            }
            catch (System.Exception e)
            {
                throw new System.ApplicationException(e.Message);
            }
            return val;
        }
        
        /// <summary>
        /// Writes property values into a property bag.
        /// </summary>
        /// <param name="pb">Property bag.</param>
        /// <param name="propName">Name of property.</param>
        /// <param name="val">Value of property.</param>
        private void WritePropertyBag(IPropertyBag pb, string propName, object val)
        {
            try
            {
                pb.Write(propName, ref val);
            }
            catch (System.Exception e)
            {
                throw new System.ApplicationException(e.Message);
            }
        }
        #endregion
        #endregion
        
        #region IComponentUI members
        /// <summary>
        /// Component icon to use in BizTalk Editor
        /// </summary>
        [Browsable(false)]
        public IntPtr Icon
        {
            get
            {
                return ((System.Drawing.Bitmap)(this.resourceManager.GetObject("COMPONENTICON", System.Globalization.CultureInfo.InvariantCulture))).GetHicon();
            }
        }
        
        /// <summary>
        /// The Validate method is called by the BizTalk Editor during the build 
        /// of a BizTalk project.
        /// </summary>
        /// <param name="obj">An Object containing the configuration properties.</param>
        /// <returns>The IEnumerator enables the caller to enumerate through a collection of strings containing error messages. These error messages appear as compiler error messages. To report successful property validation, the method should return an empty enumerator.</returns>
        public System.Collections.IEnumerator Validate(object obj)
        {
            // example implementation:
            // ArrayList errorList = new ArrayList();
            // errorList.Add("This is a compiler error");
            // return errorList.GetEnumerator();
            return null;
        }
        #endregion
        
        #region IComponent members
        /// <summary>
        /// Implements IComponent.Execute method.
        /// </summary>
        /// <param name="pc">Pipeline context</param>
        /// <param name="inmsg">Input message</param>
        /// <returns>Original input message</returns>
        /// <remarks>
        /// IComponent.Execute method is used to initiate
        /// the processing of the message in this pipeline component.
        /// </remarks>
        public IBaseMessage Execute(IPipelineContext pc, IBaseMessage inmsg)
        {
            if (this.ForwardOnly)
                return ExecuteForwardOnly(pc, inmsg);
            else
                return ExecuteNotForwardOnly(pc, inmsg);
        }
        #endregion

        #region Custom Code

        public IBaseMessage ExecuteNotForwardOnly(IPipelineContext pc, IBaseMessage inmsg)
        {
            TraceStream traceStream = new TraceStream(inmsg.BodyPart.GetOriginalDataStream(), false);

            string archivePath = Path.Combine(ArchiveTo, Guid.NewGuid().ToString() + ".txt");
            FileStream fileStream = new FileStream(archivePath, FileMode.Create, FileAccess.Write);

            int length = 4096;
            Byte[] buffer = new Byte[length];
            int byteRead = traceStream.Read(buffer, 0, length);
            while (byteRead > 0)
            {
                fileStream.Write(buffer, 0, byteRead);
                byteRead = traceStream.Read(buffer, 0, length);
            }
            traceStream.Position = 0;
            inmsg.BodyPart.Data = traceStream;
            fileStream.Close();

            return inmsg;
        }
        public IBaseMessage ExecuteForwardOnly(IPipelineContext pc, IBaseMessage inmsg)
        {
            TraceStream traceStream = new TraceStream(inmsg.BodyPart.GetOriginalDataStream(), true);
            Microsoft.BizTalk.Streaming.CForwardOnlyEventingReadStream eventStream = 
                new Microsoft.BizTalk.Streaming.CForwardOnlyEventingReadStream(traceStream);

            eventStream.BeforeFirstReadEvent += new Microsoft.BizTalk.Streaming.BeforeFirstReadEventHandler(eventStream_BeforeFirstReadEvent);
            eventStream.ReadEvent += new Microsoft.BizTalk.Streaming.ReadEventHandler(eventStream_ReadEvent);
            eventStream.AfterLastReadEvent += new Microsoft.BizTalk.Streaming.AfterLastReadEventHandler(eventStream_AfterLastReadEvent);

            inmsg.BodyPart.Data = eventStream;
            
            return inmsg;
        }

        void eventStream_BeforeFirstReadEvent(object src, EventArgs args)
        {
            _fileSteam = 
                new FileStream(Path.Combine(this.ArchiveTo, Guid.NewGuid() + ".txt"), 
                    FileMode.Create, 
                    FileAccess.Write);
        }
        void eventStream_ReadEvent(object src, EventArgs args)
        {
            byte[] buffer = ((Microsoft.BizTalk.Streaming.ReadEventArgs)args).buffer;
            int length = ((Microsoft.BizTalk.Streaming.ReadEventArgs)args).bytesRead;
            this._fileSteam.Write(buffer, 0, length);
        }
        void eventStream_AfterLastReadEvent(object src, EventArgs args)
        {
            this._fileSteam.Flush();
            this._fileSteam.Close();
        }
       
        #endregion
    }
}
