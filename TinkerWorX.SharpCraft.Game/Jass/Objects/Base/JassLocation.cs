using System;

namespace TinkerWorX.SharpCraft.Game.Jass
{
    [JassType("Hlocation;")]
    [Serializable]
    public partial struct JassLocation
    {
        public readonly IntPtr Handle;
        
        public JassLocation(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
