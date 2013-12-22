using System;

namespace TinkerWorX.SharpCraft.Game.Jass
{
    [JassType("Hplayerevent;")]
    [Serializable]
    public partial struct JassPlayerEvent
    {
        public readonly IntPtr Handle;
        
        public JassPlayerEvent(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
