using System;

namespace TinkerWorX.SharpCraft.Game.Jass
{
    [JassType("Hmapflag;")]
    public partial struct JassMapFlag
    {
        public readonly IntPtr Handle;
        
        public JassMapFlag(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
