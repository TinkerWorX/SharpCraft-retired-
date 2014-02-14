using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Ionic.Zip;

namespace TinkerWorX.SharpCraft
{
    public static class ZipEntryExtensions
    {
        public static Stream ToStream(this ZipEntry @this)
        {
            var stream = new MemoryStream();
            @this.Extract(stream);
            return stream;
        }

        public static Byte[] ToBytes(this ZipEntry @this)
        {
            using (var stream = @this.ToStream())
            using (var reader = new BinaryReader(stream))
            {
                return reader.ReadBytes((Int32)stream.Length);
            }
        }
    }
}
