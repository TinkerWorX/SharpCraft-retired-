using System;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Jass
{
    [JassType("Higamestate;")]
    [Serializable]
    public partial struct JassIGameState
    {
        public readonly IntPtr Handle;
        
        public JassIGameState(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
