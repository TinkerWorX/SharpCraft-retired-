using System;

namespace TinkerWorX.SharpCraft.Game.Jass
{
    [JassType("Hplayerevent;")]
    public partial struct JassPlayerEvent
    {
        public readonly IntPtr Handle;
        
        public JassPlayerEvent(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
