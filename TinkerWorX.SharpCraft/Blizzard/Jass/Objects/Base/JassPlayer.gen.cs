using System;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Jass
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
