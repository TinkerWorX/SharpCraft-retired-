using System;
using TinkerWorX.SharpCraft.Types;
using SafeNatives = TinkerWorX.SharpCraft.Blizzard.GameModule.SafeAPI.Natives;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Jass
{
    public partial struct JassPlayerSlotState
    {
        public static JassPlayerSlotState Empty = SafeNatives.ConvertPlayerSlotState(0);
        public static JassPlayerSlotState Playing = SafeNatives.ConvertPlayerSlotState(1);
        public static JassPlayerSlotState Left = SafeNatives.ConvertPlayerSlotState(2);
    }
}
