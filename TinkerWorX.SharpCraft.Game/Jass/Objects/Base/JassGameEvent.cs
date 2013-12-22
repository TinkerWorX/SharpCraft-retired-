using System;

namespace TinkerWorX.SharpCraft.Game.Jass
{
    [JassType("Hgameevent;")]
    [Serializable]
    public partial struct JassGameEvent
    {
        public readonly IntPtr Handle;
        
        public JassGameEvent(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
