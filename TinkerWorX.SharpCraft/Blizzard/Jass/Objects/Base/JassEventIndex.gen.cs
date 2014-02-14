using System;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Jass
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
