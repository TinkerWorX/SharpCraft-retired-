using System;

namespace TinkerWorX.SharpCraft.Game.Jass
{
    [JassType("Hgamedifficulty;")]
    public partial struct JassGameDifficulty
    {
        public readonly IntPtr Handle;
        
        public JassGameDifficulty(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
