using System;
using System.IO;
using System.Runtime.InteropServices;

namespace TinkerWorX.SharpCraft.Game.Jass
{
    [JassType("R")]
    public struct JassRealArg
    {
        private readonly IntPtr valueAsPtr;

        private JassRealArg(IntPtr valueAsPtr)
        {
            this.valueAsPtr = valueAsPtr;
        }

        // Implicit conversion from JassRealArg to Single
        public static implicit operator Single(JassRealArg from)
        {
            var data = new Byte[4];
            Marshal.Copy(from.valueAsPtr, data, 0, 4);
            return BitConverter.ToSingle(data, 0);
        }

        // Implicit conversion from Single to JassRealArg
        public static implicit operator JassRealArg(Single from)
        {
            var ptr = Marshal.AllocHGlobal(sizeof(Single));
            Marshal.Copy(BitConverter.GetBytes(from), 0, ptr, sizeof(Single));
            return new JassRealArg(ptr);
        }

        // Implicit conversion from JassRealArg to JassRealRet
        public static implicit operator JassRealRet(JassRealArg from)
        {
            return (Single)from;
        }

        public override String ToString()
        {
            return ((Single)this).ToString();
        }

        public String ToString(String format)
        {
            return ((Single)this).ToString(format);
        }

        public String ToString(IFormatProvider provider)
        {
            return ((Single)this).ToString(provider);
        }

        public String ToString(String format, IFormatProvider provider)
        {
            return ((Single)this).ToString(format, provider);
        }
    }

    [JassType("R")]
    public struct JassRealRet
    {
        private readonly Int32 valueAsInt32;

        private JassRealRet(Int32 valueAsInt32)
        {
            this.valueAsInt32 = valueAsInt32;
        }

        // Implicit conversion from JassRealRet to Single
        public static implicit operator Single(JassRealRet from)
        {
            var stream = new MemoryStream(4);
            var writer = new BinaryWriter(stream);
            writer.Write(from.valueAsInt32);
            return BitConverter.ToSingle(stream.ToArray(), 0);
        }

        // Implicit conversion from Single to JassRealRet
        public static implicit operator JassRealRet(Single from)
        {
            var stream = new MemoryStream(4);
            var writer = new BinaryWriter(stream);
            writer.Write(from);
            return new JassRealRet(BitConverter.ToInt32(stream.ToArray(), 0));
        }

        // Implicit conversion from JassRealRet to JassRealArg
        public static implicit operator JassRealArg(JassRealRet from)
        {
            return (Single)from;
        }

        public override String ToString()
        {
            return ((Single)this).ToString();
        }

        public String ToString(String format)
        {
            return ((Single)this).ToString(format);
        }

        public String ToString(IFormatProvider provider)
        {
            return ((Single)this).ToString(provider);
        }

        public String ToString(String format, IFormatProvider provider)
        {
            return ((Single)this).ToString(format, provider);
        }
    }
}
