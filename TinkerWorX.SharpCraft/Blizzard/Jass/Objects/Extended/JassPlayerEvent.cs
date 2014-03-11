using System;
using TinkerWorX.SharpCraft.Types;
using SafeNatives = TinkerWorX.SharpCraft.Blizzard.GameModule.SafeAPI.Natives;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Jass
{
    public partial struct JassPlayerEvent
    {
        public static JassPlayerEvent StateLimit = SafeNatives.ConvertPlayerEvent(11);
        public static JassPlayerEvent AllianceChanged = SafeNatives.ConvertPlayerEvent(12);

        public static JassPlayerEvent Defeat = SafeNatives.ConvertPlayerEvent(13);
        public static JassPlayerEvent Victory = SafeNatives.ConvertPlayerEvent(14);
        public static JassPlayerEvent Leave = SafeNatives.ConvertPlayerEvent(15);
        public static JassPlayerEvent Chat = SafeNatives.ConvertPlayerEvent(16);
        public static JassPlayerEvent EndCinematic = SafeNatives.ConvertPlayerEvent(17);

        public static JassPlayerEvent ArrowLeftDown = SafeNatives.ConvertPlayerEvent(261);
        public static JassPlayerEvent ArrowLeftUp = SafeNatives.ConvertPlayerEvent(262);
        public static JassPlayerEvent ArrowRightDown = SafeNatives.ConvertPlayerEvent(263);
        public static JassPlayerEvent ArrowRightUp = SafeNatives.ConvertPlayerEvent(264);
        public static JassPlayerEvent ArrowDownDown = SafeNatives.ConvertPlayerEvent(265);
        public static JassPlayerEvent ArrowDownUp = SafeNatives.ConvertPlayerEvent(266);
        public static JassPlayerEvent ArrowUpDown = SafeNatives.ConvertPlayerEvent(267);
        public static JassPlayerEvent ArrowUpUp = SafeNatives.ConvertPlayerEvent(268);
    }
}
