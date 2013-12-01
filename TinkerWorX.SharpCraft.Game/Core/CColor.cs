using System;
using System.Runtime.InteropServices;

namespace TinkerWorX.SharpCraft.Game.Core
{
    [StructLayout(LayoutKind.Sequential)]
    public struct CColor
    {
        public static CColor White = new CColor(0xFF, 0xFF, 0xFF);

        public Byte B;
        public Byte G;
        public Byte R;
        public Byte A;

        public CColor(Byte r, Byte g, Byte b)
        {
            this.A = 0xFF;
            this.R = r;
            this.G = g;
            this.B = b;
        }

        public override String ToString()
        {
            return "(" + this.A.ToString("X2") + this.R.ToString("X2") + this.G.ToString("X2") + this.B.ToString("X2") + ")";
        }
    }
}
