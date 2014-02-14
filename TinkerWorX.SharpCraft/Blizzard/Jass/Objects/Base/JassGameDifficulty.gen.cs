using System;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Jass
{
    [JassType("Hgamedifficulty;")]
    [Serializable]
    public partial struct JassGameDifficulty
    {
        public readonly IntPtr Handle;
        
        public JassGameDifficulty(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
