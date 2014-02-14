using System;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Jass
{
    [JassType("Hevent;")]
    [Serializable]
    public partial struct JassEvent
    {
        public readonly IntPtr Handle;
        
        public JassEvent(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
