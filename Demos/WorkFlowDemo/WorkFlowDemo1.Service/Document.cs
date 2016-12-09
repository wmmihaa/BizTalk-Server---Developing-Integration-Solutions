using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace WorkFlowDemo1.Service
{
    [DataContract]
    public class Document
    {
        [DataMember]
        public string DocumentId { get; set; }
        [DataMember]
        public string Content { get; set; }
        [DataMember]
        public bool Done { get; set; }
    }
    [DataContract]
    public class DocumentResponse
    {
        [DataMember]
        public string DocumentId { get; set; }
        [DataMember]
        public string Message { get; set; }
        public static DocumentResponse Create(string id, string msg)
        {
            return new DocumentResponse { DocumentId = id, Message = msg };
        }
    }
}