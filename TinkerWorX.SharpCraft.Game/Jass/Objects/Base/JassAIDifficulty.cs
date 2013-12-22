using System;

namespace TinkerWorX.SharpCraft.Game.Jass
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
