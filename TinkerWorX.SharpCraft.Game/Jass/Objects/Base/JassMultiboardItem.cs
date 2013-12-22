using System;

namespace TinkerWorX.SharpCraft.Game.Jass
{
    [JassType("Hmultiboarditem;")]
    [Serializable]
    public partial struct JassMultiboardItem
    {
        public readonly IntPtr Handle;
        
        public JassMultiboardItem(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
