using System;

namespace TinkerWorX.SharpCraft.Game.Jass
{
    [JassType("Hlocation;")]
    public partial struct JassLocation
    {
        public readonly IntPtr Handle;
        
        public JassLocation(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
