using System;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Jass
{
    [JassType("Hsound;")]
    [Serializable]
    public partial struct JassSound
    {
        public readonly IntPtr Handle;
        
        public JassSound(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
