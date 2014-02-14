using System;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Jass
{
    [JassType("Hlimitop;")]
    [Serializable]
    public partial struct JassLimitOp
    {
        public readonly IntPtr Handle;
        
        public JassLimitOp(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
