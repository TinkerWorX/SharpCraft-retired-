using System;

namespace TinkerWorX.SharpCraft.Game.Jass
{
    [JassType("Hgametype;")]
    public partial struct JassGameType
    {
        public readonly IntPtr Handle;
        
        public JassGameType(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
