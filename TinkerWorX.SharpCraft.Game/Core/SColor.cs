using System;
using System.Runtime.InteropServices;

namespace TinkerWorX.SharpCraft.Game.Core
{
    [StructLayout(LayoutKind.Sequential)]
    public struct SColor
    {
        public static SColor White = new SColor(0xFF, 0xFF, 0xFF);
        public static SColor Yellow = new SColor(0xFF, 0xCC, 0x00);
        public static SColor Unique = new SColor(0x8B, 0x00, 0xFF);
        public static SColor Consumable = new SColor(0x87, 0xCE, 0xEB);
        public static SColor Artifact = new SColor(0xFF, 0x8C, 0x00);

        public Byte B;
        public Byte G;
        public Byte R;
        public Byte A;

        public SColor(Byte r, Byte g, Byte b)
        {
            this.A = 0xFF;
            this.R = r;
            this.G = g;
            this.B = b;
        }

        public String ToHexString()
        {
            return this.A.ToString("X2") + this.R.ToString("X2") + this.G.ToString("X2") + this.B.ToString("X2");
        }

        public override String ToString()
        {
            return "(a:" + this.A.ToString("X2") + "; r:" + this.R.ToString("X2") + "; g:" + this.G.ToString("X2") + "; b:" + this.B.ToString("X2") + ")";
        }
    }
}
