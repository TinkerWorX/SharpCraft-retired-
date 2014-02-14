using System;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Jass
{
    [JassType("Hstartlocprio;")]
    [Serializable]
    public partial struct JassStartLocationPriority
    {
        public readonly IntPtr Handle;
        
        public JassStartLocationPriority(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
