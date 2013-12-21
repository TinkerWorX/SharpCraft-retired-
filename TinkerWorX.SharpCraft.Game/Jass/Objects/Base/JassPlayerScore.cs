using System;

namespace TinkerWorX.SharpCraft.Game.Jass
{
    [JassType("Hplayerscore;")]
    public partial struct JassPlayerScore
    {
        public readonly IntPtr Handle;
        
        public JassPlayerScore(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
