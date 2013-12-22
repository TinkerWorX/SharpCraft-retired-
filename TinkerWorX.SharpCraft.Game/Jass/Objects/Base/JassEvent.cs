using System;

namespace TinkerWorX.SharpCraft.Game.Jass
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
