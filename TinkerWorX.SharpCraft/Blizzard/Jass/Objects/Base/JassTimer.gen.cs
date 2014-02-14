using System;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Jass
{
    [JassType("Htimer;")]
    [Serializable]
    public partial struct JassTimer
    {
        public readonly IntPtr Handle;
        
        public JassTimer(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
