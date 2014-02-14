using System;
using System.Runtime.InteropServices;
using TinkerWorX.SharpCraft.Blizzard.Types;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Jass
{
    /// <summary>
    /// JassObjectId is a wrapper for the four byte literal syntax in JASS.
    /// </summary>
    /// <remarks>Used with units, items, abilities, destructables, upgrades and doodads.</remarks>
    [JassType("I")]
    [Serializable]
    public struct JassObjectId
    {
        private readonly Int32 value;

        public JassObjectId(Int32 value)
        {
            this.value = value;
        }

        public JassObjectId(String objectId)
        {
            if (objectId.Length != 4)
                throw new ArgumentOutOfRangeException("objectId", "Invalid objectId. id must be 4 characters long");
            this.value =
                (objectId[0] << 24) |
                (objectId[1] << 16) |
                (objectId[2] << 8) |
                (objectId[3]);
        }

        // Implicit conversion from JassObjectId to String
        public static implicit operator String(JassObjectId from)
        {
            return new String(new[] {
                (Char)((from.value & 0xFF000000) >> 24),
                (Char)((from.value & 0x00FF0000) >> 16),
                (Char)((from.value & 0x0000FF00) >> 8),
                (Char)((from.value & 0x000000FF)) });
        }

        // Explicit conversion from String to JassObjectId
        public static explicit operator JassObjectId(String from)
        {
            // This has to be explicit because general C# guidelines says the following about implicit:
            // [...] implicit conversion operators should never throw exceptions and never lose information  [...]
            // http://msdn.microsoft.com/en-us/library/z5z9kes2%28v=vs.110%29.aspx
            
            return new JassObjectId(from);
        }

        // Implicit conversion from JassObjectId to Int32
        public static implicit operator Int32(JassObjectId from)
        {
            return from.value;
        }

        // Implicit conversion from Int32 to JassObjectId
        public static implicit operator JassObjectId(Int32 from)
        {
            return new JassObjectId(from);
        }

        // Implicit conversion from JassObjectId to ObjectIdL
        public static implicit operator ObjectIdL(JassObjectId from)
        {
            return new ObjectIdL(from.value);
        }

        // Implicit conversion from JassObjectId to ObjectIdB
        public static implicit operator ObjectIdB(JassObjectId from)
        {
            return (ObjectIdB)(new ObjectIdL(from.value));
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
