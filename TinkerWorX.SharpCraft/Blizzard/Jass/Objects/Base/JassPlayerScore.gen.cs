using System;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Jass
{
    [JassType("Hplayerscore;")]
    [Serializable]
    public partial struct JassPlayerScore
    {
        public readonly IntPtr Handle;
        
        public JassPlayerScore(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
