using System;

namespace TinkerWorX.SharpCraft.Game.Jass
{
    [JassType("Htexmapflags;")]
    [Serializable]
    public partial struct JassTextureMapFlags
    {
        public readonly IntPtr Handle;
        
        public JassTextureMapFlags(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
