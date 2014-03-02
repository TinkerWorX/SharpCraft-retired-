using System;
using SafeNatives = TinkerWorX.SharpCraft.Blizzard.GameModule.SafeAPI.Natives;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Jass
{
    public partial struct JassPlayerState
    {
        public static JassPlayerState GameResult = SafeNatives.ConvertPlayerState(0);
        public static JassPlayerState ResourceGold = SafeNatives.ConvertPlayerState(1);
        public static JassPlayerState ResourceLumber = SafeNatives.ConvertPlayerState(2);
        public static JassPlayerState ResourceHeroTokens = SafeNatives.ConvertPlayerState(3);
        public static JassPlayerState ResourceFoodCap = SafeNatives.ConvertPlayerState(4);
        public static JassPlayerState ResourceFoodUsed = SafeNatives.ConvertPlayerState(5);
        public static JassPlayerState FoodCapCeiling = SafeNatives.ConvertPlayerState(6);
        public static JassPlayerState GivesBounty = SafeNatives.ConvertPlayerState(7);
        public static JassPlayerState AlliedVictory = SafeNatives.ConvertPlayerState(8);
        public static JassPlayerState Placed = SafeNatives.ConvertPlayerState(9);
        public static JassPlayerState ObserverOnDeath = SafeNatives.ConvertPlayerState(10);
        public static JassPlayerState Observer = SafeNatives.ConvertPlayerState(11);
        public static JassPlayerState Unfollowable = SafeNatives.ConvertPlayerState(12);
        public static JassPlayerState GoldUpkeepRate = SafeNatives.ConvertPlayerState(13);
        public static JassPlayerState LumberUpkeepRate = SafeNatives.ConvertPlayerState(14);
        public static JassPlayerState GoldGathered = SafeNatives.ConvertPlayerState(15);
        public static JassPlayerState LumberGathered = SafeNatives.ConvertPlayerState(16);

        public static JassPlayerState NoCreepSleep = SafeNatives.ConvertPlayerState(25);
    }
}
