using System;
using System.Runtime.InteropServices;

namespace TinkerWorX.SharpCraft.Types
{
    [StructLayout(LayoutKind.Sequential)]
    [Serializable]
    public struct Vector3
    {
        public Single X;

        public Single Y;

        public Single Z;

        public Vector3(Single x, Single y, Single z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public Vector3(Vector2 vector, Single z)
        {
            this.X = vector.X;
            this.Y = vector.Y;
            this.Z = z;
        }

        public override String ToString()
        {
            return String.Format("({0}; {1}; {2})", this.X, this.Y, this.Z);
        }
    }
}
