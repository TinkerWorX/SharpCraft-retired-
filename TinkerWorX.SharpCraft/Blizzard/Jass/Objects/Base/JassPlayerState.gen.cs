using System;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Jass
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
