using System;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Jass
{
    [JassType("Hterraindeformation;")]
    [Serializable]
    public partial struct JassTerrainDeformation
    {
        public readonly IntPtr Handle;
        
        public JassTerrainDeformation(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
