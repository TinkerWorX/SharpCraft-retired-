using System;
using System.Runtime.InteropServices;

namespace TinkerWorX.SharpCraft.Game.Jass
{
    [JassType("B")]
    public struct JassBoolean
    {
        private readonly Int32 value;

        private JassBoolean(Int32 value)
        {
            this.value = value;
        }

        // Implicit conversion from JassBoolean to Boolean
        public static implicit operator Boolean(JassBoolean from)
        {
            return from.value != 0;
        }

        // Implicit conversion from Boolean to JassBoolean
        public static implicit operator JassBoolean(Boolean from)
        {
            return new JassBoolean(from ? 1 : 0);
        }

        public override String ToString()
        {
            return ((Boolean)this).ToString();
        }

        public String ToString(IFormatProvider provider)
        {
            return ((Boolean)this).ToString(provider);
        }
    }
}
