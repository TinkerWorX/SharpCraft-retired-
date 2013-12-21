using System;

namespace TinkerWorX.SharpCraft.Game.Jass
{
    [JassType("Hbuff;")]
    public partial struct JassBuff
    {
        public readonly IntPtr Handle;
        
        public JassBuff(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
