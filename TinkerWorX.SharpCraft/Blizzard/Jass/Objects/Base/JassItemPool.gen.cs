using System;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Jass
{
    [JassType("Hitempool;")]
    [Serializable]
    public partial struct JassItemPool
    {
        public readonly IntPtr Handle;
        
        public JassItemPool(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
