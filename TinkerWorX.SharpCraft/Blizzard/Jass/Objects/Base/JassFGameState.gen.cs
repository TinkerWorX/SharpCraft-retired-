using System;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Jass
{
    [JassType("Hfgamestate;")]
    [Serializable]
    public partial struct JassFGameState
    {
        public readonly IntPtr Handle;
        
        public JassFGameState(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
