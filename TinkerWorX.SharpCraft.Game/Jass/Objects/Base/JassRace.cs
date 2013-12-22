using System;

namespace TinkerWorX.SharpCraft.Game.Jass
{
    [JassType("Hrace;")]
    public partial struct JassRace
    {
        public readonly IntPtr Handle;
        
        public JassRace(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
