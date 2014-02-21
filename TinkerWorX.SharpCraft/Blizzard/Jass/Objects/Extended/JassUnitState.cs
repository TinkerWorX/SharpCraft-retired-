using System;
using SafeNatives = TinkerWorX.SharpCraft.Blizzard.GameModule.SafeAPI.Natives;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Jass
{
    public partial struct JassUnitState
    {
        // constant unitstate UNIT_STATE_LIFE = ConvertUnitState(0)
        public static readonly JassUnitState Life = SafeNatives.ConvertUnitState(0);

        // constant unitstate UNIT_STATE_MAX_LIFE = ConvertUnitState(1)
        public static readonly JassUnitState MaxLife = SafeNatives.ConvertUnitState(1);

        // constant unitstate UNIT_STATE_MANA = ConvertUnitState(2)
        public static readonly JassUnitState Mana = SafeNatives.ConvertUnitState(2);

        // constant unitstate UNIT_STATE_MAX_MANA = ConvertUnitState(3)
        public static readonly JassUnitState MaxMana = SafeNatives.ConvertUnitState(3);
    }
}
