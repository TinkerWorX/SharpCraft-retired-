using System;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Jass
{
    [JassType("Hgamestate;")]
    [Serializable]
    public partial struct JassGameState
    {
        public readonly IntPtr Handle;
        
        public JassGameState(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
