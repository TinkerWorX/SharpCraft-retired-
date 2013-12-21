using System;

namespace TinkerWorX.SharpCraft.Game.Jass
{
    [JassType("Hgamestate;")]
    public partial struct JassGameState
    {
        public readonly IntPtr Handle;
        
        public JassGameState(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
