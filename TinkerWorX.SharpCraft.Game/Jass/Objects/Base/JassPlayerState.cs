using System;

namespace TinkerWorX.SharpCraft.Game.Jass
{
    [JassType("Hplayerstate;")]
    [Serializable]
    public partial struct JassPlayerState
    {
        public readonly IntPtr Handle;
        
        public JassPlayerState(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
