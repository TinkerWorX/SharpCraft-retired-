using System;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Jass
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
