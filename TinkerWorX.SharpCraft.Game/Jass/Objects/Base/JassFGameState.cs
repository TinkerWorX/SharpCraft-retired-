using System;

namespace TinkerWorX.SharpCraft.Game.Jass
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
