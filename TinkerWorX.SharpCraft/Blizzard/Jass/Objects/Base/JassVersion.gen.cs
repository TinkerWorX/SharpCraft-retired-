using System;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Jass
{
    [JassType("Hversion;")]
    [Serializable]
    public partial struct JassVersion
    {
        public readonly IntPtr Handle;
        
        public JassVersion(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
