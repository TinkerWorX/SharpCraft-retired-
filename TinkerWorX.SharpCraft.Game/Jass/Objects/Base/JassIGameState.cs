using System;

namespace TinkerWorX.SharpCraft.Game.Jass
{
    [JassType("Higamestate;")]
    public partial struct JassIGameState
    {
        public readonly IntPtr Handle;
        
        public JassIGameState(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
