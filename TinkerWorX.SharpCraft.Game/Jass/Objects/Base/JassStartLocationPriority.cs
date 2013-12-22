using System;

namespace TinkerWorX.SharpCraft.Game.Jass
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
