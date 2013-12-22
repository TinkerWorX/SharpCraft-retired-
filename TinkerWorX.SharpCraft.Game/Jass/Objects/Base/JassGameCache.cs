using System;

namespace TinkerWorX.SharpCraft.Game.Jass
{
    [JassType("Hgamecache;")]
    [Serializable]
    public partial struct JassGameCache
    {
        public readonly IntPtr Handle;
        
        public JassGameCache(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
