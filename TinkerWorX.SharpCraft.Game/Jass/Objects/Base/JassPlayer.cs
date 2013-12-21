using System;

namespace TinkerWorX.SharpCraft.Game.Jass
{
    [JassType("Hplayer;")]
    public partial struct JassPlayer
    {
        public readonly IntPtr Handle;
        
        public JassPlayer(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
