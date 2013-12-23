using System;

namespace TinkerWorX.SharpCraft.Game.Jass
{
    [JassType("Hitemtype;")]
    [Serializable]
    public partial struct JassItemType
    {
        public readonly IntPtr Handle;
        
        public JassItemType(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}