using System;

namespace TinkerWorX.SharpCraft.Game.Jass
{
    [JassType("Htrigger;")]
    public partial struct JassTrigger
    {
        public readonly IntPtr Handle;
        
        public JassTrigger(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
