using System;

namespace TinkerWorX.SharpCraft.Game.Jass
{
    [JassType("Hregion;")]
    [Serializable]
    public partial struct JassRegion
    {
        public readonly IntPtr Handle;
        
        public JassRegion(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
