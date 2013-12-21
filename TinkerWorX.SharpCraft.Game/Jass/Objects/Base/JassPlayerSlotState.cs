using System;

namespace TinkerWorX.SharpCraft.Game.Jass
{
    [JassType("Hplayerslotstate;")]
    public partial struct JassPlayerSlotState
    {
        public readonly IntPtr Handle;
        
        public JassPlayerSlotState(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
