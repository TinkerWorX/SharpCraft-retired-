using System;

namespace TinkerWorX.SharpCraft.Game.Jass
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
