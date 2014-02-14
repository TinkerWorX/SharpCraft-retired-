using System;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Jass
{
    [JassType("Hunit;")]
    [Serializable]
    public partial struct JassUnit
    {
        public readonly IntPtr Handle;
        
        public JassUnit(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
