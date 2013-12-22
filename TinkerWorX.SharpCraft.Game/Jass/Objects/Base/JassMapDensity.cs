using System;

namespace TinkerWorX.SharpCraft.Game.Jass
{
    [JassType("Hmapdensity;")]
    [Serializable]
    public partial struct JassMapDensity
    {
        public readonly IntPtr Handle;
        
        public JassMapDensity(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
