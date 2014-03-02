using System;
using TinkerWorX.SharpCraft.Types;
using SafeNatives = TinkerWorX.SharpCraft.Blizzard.GameModule.SafeAPI.Natives;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Jass
{
    public partial struct JassRacePreference
    {
        public static JassRacePreference Human = SafeNatives.ConvertRacePref(1);
        public static JassRacePreference Orc = SafeNatives.ConvertRacePref(2);
        public static JassRacePreference NightElf = SafeNatives.ConvertRacePref(4);
        public static JassRacePreference Undead = SafeNatives.ConvertRacePref(8);
        public static JassRacePreference Demon = SafeNatives.ConvertRacePref(16);
        public static JassRacePreference Random = SafeNatives.ConvertRacePref(32);
        public static JassRacePreference UserSelectable = SafeNatives.ConvertRacePref(64);
    }
}
