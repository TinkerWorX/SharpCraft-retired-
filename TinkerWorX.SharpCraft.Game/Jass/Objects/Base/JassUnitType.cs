using System;

namespace TinkerWorX.SharpCraft.Game.Jass
{
    [JassType("Hunittype;")]
    public partial struct JassUnitType
    {
        public readonly IntPtr Handle;
        
        public JassUnitType(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
