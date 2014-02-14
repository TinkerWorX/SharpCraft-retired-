using System;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Jass
{
    [JassType("Hplayerslotstate;")]
    [Serializable]
    public partial struct JassPlayerSlotState
    {
        public readonly IntPtr Handle;
        
        public JassPlayerSlotState(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
