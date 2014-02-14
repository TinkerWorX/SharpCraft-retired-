using System;
using System.Runtime.InteropServices;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Jass
{
    [JassType("I")]
    [Serializable]
    public struct JassInteger
    {
        private readonly Int32 value;

        private JassInteger(Int32 value)
        {
            this.value = value;
        }

        // Implicit conversion from JassInt to Int32
        public static implicit operator Int32(JassInteger from)
        {
            return from.value;
        }

        // Implicit conversion from Int32 to JassInt
        public static implicit operator JassInteger(Int32 from)
        {
            return new JassInteger(from);
        }

        public override String ToString()
        {
            return ((Int32)this).ToString();
        }

        public String ToString(String format)
        {
            return ((Int32)this).ToString(format);
        }

        public String ToString(IFormatProvider provider)
        {
            return ((Int32)this).ToString(provider);
        }

        public String ToString(String format, IFormatProvider provider)
        {
            return ((Int32)this).ToString(format, provider);
        }
    }
}
