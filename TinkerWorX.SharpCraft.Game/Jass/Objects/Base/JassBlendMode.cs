using System;

namespace TinkerWorX.SharpCraft.Game.Jass
{
    [JassType("Hblendmode;")]
    [Serializable]
    public partial struct JassBlendMode
    {
        public readonly IntPtr Handle;
        
        public JassBlendMode(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
