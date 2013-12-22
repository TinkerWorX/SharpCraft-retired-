using System;

namespace TinkerWorX.SharpCraft.Game.Jass
{
    [JassType("Hunitpool;")]
    public partial struct JassUnitPool
    {
        public readonly IntPtr Handle;
        
        public JassUnitPool(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
