using System;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Jass
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
