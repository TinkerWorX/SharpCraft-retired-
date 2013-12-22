using System;

namespace TinkerWorX.SharpCraft.Game.Jass
{
    [JassType("Heventid;")]
    [Serializable]
    public partial struct JassEventIndex
    {
        public readonly IntPtr Handle;
        
        public JassEventIndex(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
