using System;

namespace TinkerWorX.SharpCraft.Game.Jass
{
    [JassType("Hunitpool;")]
    [Serializable]
    public partial struct JassUnitPool
    {
        public readonly IntPtr Handle;
        
        public JassUnitPool(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
