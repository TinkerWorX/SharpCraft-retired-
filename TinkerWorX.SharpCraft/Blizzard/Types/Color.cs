using System;
using System.Runtime.InteropServices;

namespace TinkerWorX.SharpCraft.Blizzard.Types
{
    [StructLayout(LayoutKind.Sequential)]
    [Serializable]
    public struct Color
    {
        public static Color FromRGB(Byte red, Byte green, Byte blue)
        {
            return new Color(red, green, blue);
        }

        public static Color FromARGB(Byte alpha, Byte red, Byte green, Byte blue)
        {
            return new Color(alpha, red, green, blue);
        }

        public static Color White = new Color(0xFF, 0xFF, 0xFF);
        public static Color Yellow = new Color(0xFF, 0xCC, 0x00);
        public static Color Unique = new Color(0x8B, 0x00, 0xFF);
        public static Color Consumable = new Color(0x87, 0xCE, 0xEB);
        public static Color Artifact = new Color(0xFF, 0x8C, 0x00);

        public Byte B;
        public Byte G;
        public Byte R;
        public Byte A;

        public Color(Byte alpha, Byte red, Byte green, Byte blue)
        {
            this.A = alpha;
            this.R = red;
            this.G = green;
            this.B = blue;
        }

        public Color(Byte red, Byte green, Byte blue)
        {
            this.A = 0xFF;
            this.R = red;
            this.G = green;
            this.B = blue;
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
