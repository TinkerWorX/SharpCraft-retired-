using System;
using System.Runtime.InteropServices;
using System.Text;

namespace TinkerWorX.SharpCraft.Blizzard.Types
{
    /// <summary>
    /// A little-endian encoded ObjectId.
    /// </summary>
    [Serializable]
    public struct ObjectIdL
    {
        private readonly Int32 value;

        public ObjectIdL(Int32 id)
        {
            this.value = id;
        }

        public ObjectIdL(String id)
        {
            if (id.Length != 4)
                throw new ArgumentOutOfRangeException("id", "Invalid id. Must be 4 characters long");

            this.value = (id[3]) | (id[2] << 8) | (id[1] << 16) | (id[0] << 24);
        }

        // Explicit conversion from ObjectIdL to Int32
        public static explicit operator Int32(ObjectIdL from)
        {
            return from.value;
        }

        // Explicit conversion from Int32 to ObjectIdL
        public static explicit operator ObjectIdL(Int32 from)
        {
            return new ObjectIdL(from);
        }

        // Explicit conversion from ObjectIdB to ObjectIdL
        public static explicit operator ObjectIdL(ObjectIdB from)
        {
            var bytes = BitConverter.GetBytes((Int32)from);
            Array.Reverse(bytes);
            return new ObjectIdL(BitConverter.ToInt32(bytes, 0));
        }

        public override String ToString()
        {
            var bytes = BitConverter.GetBytes(this.value);
            Array.Reverse(bytes);
            return Encoding.ASCII.GetString(bytes);
        }
    }
}
