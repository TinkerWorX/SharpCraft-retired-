using System;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Jass
{
    [JassType("Hvolumegroup;")]
    [Serializable]
    public partial struct JassVolumeGroup
    {
        public readonly IntPtr Handle;
        
        public JassVolumeGroup(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
