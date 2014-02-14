using System;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Jass
{
    [JassType("Hitem;")]
    [Serializable]
    public partial struct JassItem
    {
        public readonly IntPtr Handle;
        
        public JassItem(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
