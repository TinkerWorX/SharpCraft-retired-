using System;

namespace TinkerWorX.SharpCraft.Game.Jass
{
    [JassType("Hplayer;")]
    [Serializable]
    public partial struct JassPlayer
    {
        public readonly IntPtr Handle;
        
        public JassPlayer(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
