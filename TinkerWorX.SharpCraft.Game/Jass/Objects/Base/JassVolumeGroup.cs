using System;

namespace TinkerWorX.SharpCraft.Game.Jass
{
    [JassType("Hvolumegroup;")]
    public partial struct JassVolumeGroup
    {
        public readonly IntPtr Handle;
        
        public JassVolumeGroup(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
