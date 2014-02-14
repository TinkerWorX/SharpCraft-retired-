using System;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Jass
{
    [JassType("Htrackable;")]
    [Serializable]
    public partial struct JassTrackable
    {
        public readonly IntPtr Handle;
        
        public JassTrackable(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
