using System;
using TinkerWorX.SharpCraft.Blizzard.GameModule.Types;
using SafeNatives = TinkerWorX.SharpCraft.Blizzard.GameModule.SafeAPI.Natives;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Jass
{
    public partial struct JassItemType
    {
        public static JassItemType Permanent = SafeNatives.ConvertItemType(0);
        public static JassItemType Charged = SafeNatives.ConvertItemType(1);
        public static JassItemType PowerUp = SafeNatives.ConvertItemType(2);
        public static JassItemType Artifact = SafeNatives.ConvertItemType(3);
        public static JassItemType Purchasable = SafeNatives.ConvertItemType(4);
        public static JassItemType Campaign = SafeNatives.ConvertItemType(5);
        public static JassItemType Miscellaneous = SafeNatives.ConvertItemType(6);
        public static JassItemType Unknown = SafeNatives.ConvertItemType(7);
        public static JassItemType Any = SafeNatives.ConvertItemType(8);
    }
}
