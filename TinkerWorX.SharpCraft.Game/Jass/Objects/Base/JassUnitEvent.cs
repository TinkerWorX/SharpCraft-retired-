using System;

namespace TinkerWorX.SharpCraft.Game.Jass
{
    [JassType("Hunitevent;")]
    [Serializable]
    public partial struct JassUnitEvent
    {
        public readonly IntPtr Handle;
        
        public JassUnitEvent(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
