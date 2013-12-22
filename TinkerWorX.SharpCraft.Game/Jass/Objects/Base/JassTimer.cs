using System;

namespace TinkerWorX.SharpCraft.Game.Jass
{
    [JassType("Htimer;")]
    public partial struct JassTimer
    {
        public readonly IntPtr Handle;
        
        public JassTimer(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
