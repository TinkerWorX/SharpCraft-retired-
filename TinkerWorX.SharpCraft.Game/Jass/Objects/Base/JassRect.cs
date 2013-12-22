using System;

namespace TinkerWorX.SharpCraft.Game.Jass
{
    [JassType("Hrect;")]
    [Serializable]
    public partial struct JassRect
    {
        public readonly IntPtr Handle;
        
        public JassRect(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
