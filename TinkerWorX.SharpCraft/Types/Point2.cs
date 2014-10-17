using System;
using System.Runtime.InteropServices;

namespace TinkerWorX.SharpCraft.Types
{
    [StructLayout(LayoutKind.Sequential)]
    [Serializable]
    public struct Point2
    {
        public Int32 X;

        public Int32 Y;

        public Point2(Int32 x, Int32 y)
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
