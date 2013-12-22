using System;

namespace TinkerWorX.SharpCraft.Game.Jass
{
    public partial struct JassUnitState
    {
        // constant unitstate UNIT_STATE_LIFE = ConvertUnitState(0)
        public static readonly JassUnitState Life = WarcraftIII.Jass.Natives.ConvertUnitState(0);

        // constant unitstate UNIT_STATE_MAX_LIFE = ConvertUnitState(1)
        public static readonly JassUnitState MaxLife = WarcraftIII.Jass.Natives.ConvertUnitState(1);

        // constant unitstate UNIT_STATE_MANA = ConvertUnitState(2)
        public static readonly JassUnitState Mana = WarcraftIII.Jass.Natives.ConvertUnitState(2);

        // constant unitstate UNIT_STATE_MAX_MANA = ConvertUnitState(3)
        public static readonly JassUnitState MaxMana = WarcraftIII.Jass.Natives.ConvertUnitState(3);
    }
}
