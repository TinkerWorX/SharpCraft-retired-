using System;
using System.Runtime.InteropServices;
using System.Text;

namespace TinkerWorX.SharpCraft.Blizzard.Types
{
    /// <summary>
    /// A big-endian encoded ObjectId.
    /// </summary>
    [Serializable]
    public struct ObjectIdB
    {
        private readonly Int32 value;

        public ObjectIdB(Int32 id)
        {
            this.value = id;
        }

        public ObjectIdB(String id)
        {
            if (id.Length != 4)
                throw new ArgumentOutOfRangeException("id", "Invalid id. Must be 4 characters long");

            this.value = (id[0]) | (id[1] << 8) | (id[2] << 16) | (id[3] << 24);
        }

        // Explicit conversion from ObjectIdB to Int32
        public static explicit operator Int32(ObjectIdB from)
        {
            return from.value;
        }

        // Explicit conversion from Int32 to ObjectIdB
        public static explicit operator ObjectIdB(Int32 from)
        {
            return new ObjectIdB(from);
        }

        // Explicit conversion from ObjectIdL to ObjectIdB
        public static explicit operator ObjectIdB(ObjectIdL from)
        {
            var bytes = BitConverter.GetBytes((Int32)from);
            Array.Reverse(bytes);
            return new ObjectIdB(BitConverter.ToInt32(bytes, 0));
        }

        public override String ToString()
        {
            var bytes = BitConverter.GetBytes(this.value);

            return Encoding.ASCII.GetString(bytes);
        }
    }
}
