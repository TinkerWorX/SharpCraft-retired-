using System;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Jass
{
    [JassType("Hunitstate;")]
    [Serializable]
    public partial struct JassUnitState
    {
        public readonly IntPtr Handle;
        
        public JassUnitState(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
