using System;
using SafeNatives = TinkerWorX.SharpCraft.Blizzard.GameModule.SafeAPI.Natives;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Jass
{
    public partial struct JassFogState
    {
        public static JassFogState Masked = SafeNatives.ConvertFogState(1);
        public static JassFogState Fogged = SafeNatives.ConvertFogState(2);
        public static JassFogState Visible = SafeNatives.ConvertFogState(4);
    }
}
