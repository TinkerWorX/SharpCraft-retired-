using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace TinkerWorX.SharpCraft.Blizzard.Storm
{
    public class StormFileStream : Stream
    {
        public StormFileStream(IntPtr handle)
        {
            if (handle == IntPtr.Zero)
                throw new ArgumentNullException(nameof(handle), $"{nameof(handle)} cannot be null/zero.");
            this.Handle = handle;

            this.Length = SFile.GetFileSizeLong(this.Handle);
        }

        public IntPtr Handle { get; }

        public override bool CanRead => true;

        public override bool CanSeek => true;

        public override bool CanWrite => false;

        public override long Length { get; }

        public override long Position
        {
            get { throw new NotSupportedException(); }

            set { this.Seek(value, SeekOrigin.Begin); }
        }

        public override void Flush() { /* Do nothing? */ }

        public override int Read(byte[] buffer, int offset, int count)
        {
            int read;
            var pBuffer = Marshal.AllocHGlobal(count);
            SFile.ReadFile(this.Handle, pBuffer, count, out read);
            Marshal.Copy(pBuffer, buffer, offset, count);
            return read;
        }

        public override long Seek(long offset, SeekOrigin origin)
        {
            return SFile.SetFilePointerLong(this.Handle, offset, origin);
        }

        public override void SetLength(long value)
        {
            throw new NotSupportedException();
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
            throw new NotSupportedException();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
                SFile.CloseFile(this.Handle);

            base.Dispose(disposing);
        }
    }
}
