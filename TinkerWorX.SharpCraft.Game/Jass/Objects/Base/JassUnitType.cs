using System;

namespace TinkerWorX.SharpCraft.Game.Jass
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
