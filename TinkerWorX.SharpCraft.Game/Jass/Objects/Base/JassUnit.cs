using System;

namespace TinkerWorX.SharpCraft.Game.Jass
{
    [JassType("Hunit;")]
    public partial struct JassUnit
    {
        public readonly IntPtr Handle;
        
        public JassUnit(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
