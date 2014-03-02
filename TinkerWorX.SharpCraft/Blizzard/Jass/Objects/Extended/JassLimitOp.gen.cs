using System;
using SafeNatives = TinkerWorX.SharpCraft.Blizzard.GameModule.SafeAPI.Natives;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Jass
{
    public partial struct JassLimitOp
    {
        public static JassLimitOp LessThan = SafeNatives.ConvertLimitOp(0);
        public static JassLimitOp LessThanOrEqual = SafeNatives.ConvertLimitOp(1);
        public static JassLimitOp Equal = SafeNatives.ConvertLimitOp(2);
        public static JassLimitOp GreaterThanOrEqual = SafeNatives.ConvertLimitOp(3);
        public static JassLimitOp GreaterThan = SafeNatives.ConvertLimitOp(4);
        public static JassLimitOp NotEqual = SafeNatives.ConvertLimitOp(5);
    }
}
