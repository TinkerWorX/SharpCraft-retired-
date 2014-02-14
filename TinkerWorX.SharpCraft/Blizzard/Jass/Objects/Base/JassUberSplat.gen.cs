using System;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Jass
{
    [JassType("Hubersplat;")]
    [Serializable]
    public partial struct JassUberSplat
    {
        public readonly IntPtr Handle;
        
        public JassUberSplat(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
