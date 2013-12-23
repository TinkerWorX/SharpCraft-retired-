using System;
using System.Runtime.InteropServices;

namespace TinkerWorX.SharpCraft.Game.Jass
{
    [JassType("I")]
    [Serializable]
    public struct JassUnitId
    {
        private readonly Int32 value;

        public JassUnitId(Int32 value)
        {
            this.value = value;
        }

        public JassUnitId(String unitId)
        {
            if (unitId.Length != 4)
                throw new ArgumentOutOfRangeException("unitId", "Invalid unitId. unitId must be 4 characters long");
            this.value =
                (unitId[0] << 24) |
                (unitId[1] << 16) |
                (unitId[2] << 8) |
                (unitId[3]);
        }

        // Implicit conversion from JassUnitId to String
        public static implicit operator String(JassUnitId from)
        {
            return new String(new[] {
                (Char)((from.value & 0xFF000000) >> 24),
                (Char)((from.value & 0x00FF0000) >> 16),
                (Char)((from.value & 0x0000FF00) >> 8),
                (Char)((from.value & 0x000000FF)) });
        }

        // Explicit conversion from String to JassUnitId
        public static explicit operator JassUnitId(String from)
        {
            // This has to be explicit because general C# guidelines says the following about implicit:
            // [...] implicit conversion operators should never throw exceptions and never lose information  [...]
            // http://msdn.microsoft.com/en-us/library/z5z9kes2%28v=vs.110%29.aspx
            
            return new JassUnitId(from);
        }

        // Implicit conversion from JassUnitId to Int32
        public static implicit operator Int32(JassUnitId from)
        {
            return from.value;
        }

        // Explicit conversion from String to JassUnitId
        public static explicit operator JassUnitId(Int32 from)
        {
            // This has to be explicit because general C# guidelines says the following about implicit:
            // [...] implicit conversion operators should never throw exceptions and never lose information  [...]
            // http://msdn.microsoft.com/en-us/library/z5z9kes2%28v=vs.110%29.aspx

            return new JassUnitId(from);
        }

        public override String ToString()
        {
            return ((String)this).ToString();
        }

        public String ToString(IFormatProvider provider)
        {
            return ((String)this).ToString(provider);
        }
    }
}
