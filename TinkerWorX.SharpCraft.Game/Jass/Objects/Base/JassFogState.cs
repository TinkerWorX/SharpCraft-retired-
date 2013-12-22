using System;

namespace TinkerWorX.SharpCraft.Game.Jass
{
    [JassType("Hfogstate;")]
    public partial struct JassFogState
    {
        public readonly IntPtr Handle;
        
        public JassFogState(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
