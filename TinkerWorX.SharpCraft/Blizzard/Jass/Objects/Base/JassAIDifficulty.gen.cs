using System;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Jass
{
    [JassType("Haidifficulty;")]
    [Serializable]
    public partial struct JassAIDifficulty
    {
        public readonly IntPtr Handle;
        
        public JassAIDifficulty(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
