using System;
using System.Runtime.InteropServices;

namespace TinkerWorX.SharpCraft.Types
{
    [StructLayout(LayoutKind.Sequential)]
    [Serializable]
    public struct Vector2
    {
        public Single X;

        public Single Y;

        public Vector2(Single x, Single y)
        {
            this.X = x;
            this.Y = y;
        }

        public override String ToString()
        {
            return String.Format("({0}; {1})", this.X, this.Y);
        }
    }
}
