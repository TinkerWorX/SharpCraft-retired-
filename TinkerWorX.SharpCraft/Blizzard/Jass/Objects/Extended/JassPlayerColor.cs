using System;
using TinkerWorX.SharpCraft.Blizzard.Types;
using TinkerWorX.SharpCraft.Types;
using SafeNatives = TinkerWorX.SharpCraft.Blizzard.GameModule.SafeAPI.Natives;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Jass
{
    public partial struct JassPlayerColor
    {
        public static JassPlayerColor Red = SafeNatives.ConvertPlayerColor(0);
        public static JassPlayerColor Blue = SafeNatives.ConvertPlayerColor(1);
        public static JassPlayerColor Cyan = SafeNatives.ConvertPlayerColor(2);
        public static JassPlayerColor Purple = SafeNatives.ConvertPlayerColor(3);
        public static JassPlayerColor Yellow = SafeNatives.ConvertPlayerColor(4);
        public static JassPlayerColor Orange = SafeNatives.ConvertPlayerColor(5);
        public static JassPlayerColor Green = SafeNatives.ConvertPlayerColor(6);
        public static JassPlayerColor Pink = SafeNatives.ConvertPlayerColor(7);
        public static JassPlayerColor LightGray = SafeNatives.ConvertPlayerColor(8);
        public static JassPlayerColor LightBlue = SafeNatives.ConvertPlayerColor(9);
        public static JassPlayerColor Aqua = SafeNatives.ConvertPlayerColor(10);
        public static JassPlayerColor Brown = SafeNatives.ConvertPlayerColor(11);

        public Color ToColor()
        {
            switch ((Int32)this.Handle)
            {
                case 0: return new Color(0xFF, 0x03, 0x03);
                case 1: return new Color(0x00, 0x42, 0xFF);
                case 2: return new Color(0x1C, 0xE6, 0xB9);
                case 3: return new Color(0x54, 0x00, 0x81);
                case 4: return new Color(0xFF, 0xFC, 0x01);
                case 5: return new Color(0xFE, 0xBA, 0x0E);
                case 6: return new Color(0x20, 0xC0, 0x00);
                case 7: return new Color(0xE5, 0x5B, 0xB0);
                case 8: return new Color(0x95, 0x96, 0x97);
                case 9: return new Color(0x7E, 0xBF, 0xF1);
                case 10: return new Color(0x10, 0x62, 0x46);
                case 11: return new Color(0x4E, 0x2A, 0x04);
                default: return new Color(0xFF, 0xFF, 0xFF);
            }
        }
    }
}
