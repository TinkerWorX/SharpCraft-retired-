using System;

namespace TinkerWorX.SharpCraft.Game.Jass
{
    [JassType("Hleaderboard;")]
    public partial struct JassLeaderboard
    {
        public readonly IntPtr Handle;
        
        public JassLeaderboard(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
