using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;

namespace FileArchiveComponent
{
    class TraceStream :Stream
    {
        public bool IsForwardOnly;
        private long _readCount;
        private Stream _stream;
        public TraceStream(Stream stream, bool isForwardOnly)
        {
            this.IsForwardOnly = isForwardOnly;
            this._stream=stream;
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            _readCount++;

            if (IsForwardOnly)
                Trace.WriteLine(string.Format("FORWARDONLY {0} bytes, {1} count", buffer.Length, _readCount));
            else
                Trace.WriteLine(string.Format("NOT FORWARDONLY {0} bytes, {1} count", buffer.Length, _readCount));

            return _stream.Read(buffer, offset, count);
        }

        public override bool CanRead
        {
            get { return _stream.CanRead; }
        }
        public override bool CanTimeout
        {
            get{ return _stream.CanTimeout;}
        }
        public override bool CanSeek
        {
            get { return _stream.CanSeek; }
        }
        public override bool CanWrite
        {
            get { return _stream.CanWrite; }
        }
        public override void Flush()
        {
            _stream.Flush();
        }
        public override long Length
        {
            get { return _stream.Length; }
        }
        public override long Position
        {
            get
            {
                return _stream.Position;
            }
            set
            {
                _stream.Position=value;
            }
        }
        public override long Seek(long offset, SeekOrigin origin)
        {
            return _stream.Seek(offset,origin);
        }
        public override void SetLength(long value)
        {
            _stream.SetLength(value);
        }
        public override void Write(byte[] buffer, int offset, int count)
        {
            _stream.Write(buffer, offset, count);
        }
    }
}
