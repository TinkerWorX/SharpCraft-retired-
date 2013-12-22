using System;

namespace TinkerWorX.SharpCraft.Game.Jass
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
