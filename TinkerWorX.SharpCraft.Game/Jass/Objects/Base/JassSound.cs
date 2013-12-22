using System;

namespace TinkerWorX.SharpCraft.Game.Jass
{
    [JassType("Hsound;")]
    public partial struct JassSound
    {
        public readonly IntPtr Handle;
        
        public JassSound(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
