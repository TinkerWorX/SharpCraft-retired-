using System;
using TinkerWorX.SharpCraft.Types;
using SafeNatives = TinkerWorX.SharpCraft.Blizzard.GameModule.SafeAPI.Natives;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Jass
{
    public partial struct JassMapControl
    {
        public static JassMapControl User = SafeNatives.ConvertMapControl(0);
        public static JassMapControl Computer = SafeNatives.ConvertMapControl(1);
        public static JassMapControl Rescuable = SafeNatives.ConvertMapControl(2);
        public static JassMapControl Neutral = SafeNatives.ConvertMapControl(3);
        public static JassMapControl Creep = SafeNatives.ConvertMapControl(4);
        public static JassMapControl None = SafeNatives.ConvertMapControl(5);
    }
}
