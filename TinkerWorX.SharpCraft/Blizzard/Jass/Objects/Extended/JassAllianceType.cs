using System;
using TinkerWorX.SharpCraft.Types;
using SafeNatives = TinkerWorX.SharpCraft.Blizzard.GameModule.SafeAPI.Natives;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Jass
{
    public partial struct JassAllianceType
    {
        public static JassAllianceType Passive = SafeNatives.ConvertAllianceType(0);
        public static JassAllianceType HelpRequest = SafeNatives.ConvertAllianceType(1);
        public static JassAllianceType HelpResponse = SafeNatives.ConvertAllianceType(2);
        public static JassAllianceType SharedExperience = SafeNatives.ConvertAllianceType(3);
        public static JassAllianceType SharedSpells = SafeNatives.ConvertAllianceType(4);
        public static JassAllianceType SharedVision = SafeNatives.ConvertAllianceType(5);
        public static JassAllianceType SharedControl = SafeNatives.ConvertAllianceType(6);
        public static JassAllianceType SharedAdvancedControl = SafeNatives.ConvertAllianceType(7);
        public static JassAllianceType Rescuable = SafeNatives.ConvertAllianceType(8);
        public static JassAllianceType SharedVisionForced = SafeNatives.ConvertAllianceType(9);
    }
}
