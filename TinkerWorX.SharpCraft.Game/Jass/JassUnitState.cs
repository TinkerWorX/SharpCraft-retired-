using System;
using System.Runtime.InteropServices;

namespace TinkerWorX.SharpCraft.Game.Jass
{
    [JassType("Hunitstate;")]
    public struct JassUnitState
    {
        // constant native ConvertUnitState takes integer i returns unitstate
        private delegate JassUnitState ConvertUnitStatePrototype(JassInteger i);
        private static ConvertUnitStatePrototype _ConvertUnitState = WarcraftIII.Jass.GetNative("ConvertUnitState").ToDelegate<ConvertUnitStatePrototype>();

        // constant unitstate UNIT_STATE_LIFE = ConvertUnitState(0)
        public static readonly JassUnitState Life = ConvertUnitState(0);

        // constant unitstate UNIT_STATE_MAX_LIFE = ConvertUnitState(1)
        public static readonly JassUnitState MaxLife = ConvertUnitState(1);

        // constant unitstate UNIT_STATE_MANA = ConvertUnitState(2)
        public static readonly JassUnitState Mana = ConvertUnitState(2);

        // constant unitstate UNIT_STATE_MAX_MANA = ConvertUnitState(3)
        public static readonly JassUnitState MaxMana = ConvertUnitState(3);

        private static JassUnitState ConvertUnitState(Int32 i)
        {
            return _ConvertUnitState(i);
        }

        private readonly IntPtr Handle;

        public JassUnitState(IntPtr handle)
        {
            this.Handle = handle;
        }

        public override String ToString()
        {
            return this.Handle.ToString();
        }

        public String ToString(String format)
        {
            return this.Handle.ToString(format);
        }
    }
}
