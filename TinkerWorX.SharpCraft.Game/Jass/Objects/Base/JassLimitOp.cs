using System;

namespace TinkerWorX.SharpCraft.Game.Jass
{
    [JassType("Hlimitop;")]
    public partial struct JassLimitOp
    {
        public readonly IntPtr Handle;
        
        public JassLimitOp(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
