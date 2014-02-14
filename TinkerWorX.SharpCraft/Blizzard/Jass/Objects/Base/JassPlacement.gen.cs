using System;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Jass
{
    [JassType("Hplacement;")]
    [Serializable]
    public partial struct JassPlacement
    {
        public readonly IntPtr Handle;
        
        public JassPlacement(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
