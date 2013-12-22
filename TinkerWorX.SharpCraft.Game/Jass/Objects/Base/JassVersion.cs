using System;

namespace TinkerWorX.SharpCraft.Game.Jass
{
    [JassType("Hversion;")]
    public partial struct JassVersion
    {
        public readonly IntPtr Handle;
        
        public JassVersion(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
