using System;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Jass
{
    [JassType("Hunittype;")]
    [Serializable]
    public partial struct JassUnitType
    {
        public readonly IntPtr Handle;
        
        public JassUnitType(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
